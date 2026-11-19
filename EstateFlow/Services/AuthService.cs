using System.Security.Cryptography;
using EstateFlow.Helpers;
using EstateFlow.Models;

namespace EstateFlow.Services
{
    public static class Session
    {
        public static User CurrentUser { get; set; }
        public static void Logout() => CurrentUser = null;
    }

    public static class AuthService
    {
        public static User Authenticate(string identity, string password)
        {
            if (string.IsNullOrWhiteSpace(identity) || string.IsNullOrEmpty(password))
                return null;

            var user = UserService.FindByIdentity(identity);
            if (user == null || !PasswordHasher.Verify(password, user.PasswordHash))
                return null;
            return user;
        }

        /// <summary>
        /// Публичная саморегистрация нового пользователя. Всегда назначает роль «Клиент» (RoleId = 3).
        /// </summary>
        public static int Register(User user, string password)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            // Саморегистрация всегда создаёт только Клиента (RoleId = 3), независимо от переданного RoleId.
            user.RoleId = (int)UserRole.Client;
            user.RoleName = "Клиент";

            string fullName = (user.FullName ?? "").Trim();
            string login = (user.Login ?? "").Trim();
            string email = (user.Email ?? "").Trim();
            string phone = (user.Phone ?? "").Trim();

            string nameErr = Validator.FullName(fullName);
            if (nameErr != null) throw new InvalidOperationException(nameErr);

            string loginErr = Validator.Login(login);
            if (loginErr != null) throw new InvalidOperationException(loginErr);

            string emailErr = Validator.Email(email);
            if (emailErr != null) throw new InvalidOperationException(emailErr);

            string phoneErr = Validator.Phone(phone);
            if (phoneErr != null) throw new InvalidOperationException(phoneErr);

            string passErr = Validator.Password(password);
            if (passErr != null) throw new InvalidOperationException(passErr);

            if (UserService.LoginExists(login))
                throw new InvalidOperationException("Такой логин уже занят.");
            if (UserService.EmailExists(email))
                throw new InvalidOperationException("Такой email уже зарегистрирован.");
            if (UserService.PhoneExists(phone))
                throw new InvalidOperationException("Такой телефон уже зарегистрирован.");

            var clientUser = new User
            {
                FullName = fullName,
                Login = login,
                Email = email,
                Phone = phone,
                RoleId = (int)UserRole.Client
            };

            return UserService.Create(clientUser, password);
        }

        public static string SendRecoveryCode(string emailInput, out string code, out bool emailSent, out User matchedUser)
        {
            code = null;
            emailSent = false;
            matchedUser = null;

            string email = (emailInput ?? "").Trim();
            string emailErr = Validator.Email(email);
            if (emailErr != null)
                return emailErr;

            matchedUser = UserService.FindByEmail(email);
            if (matchedUser == null)
                return "Пользователь с таким email не найден.";

            code = RandomNumberGenerator.GetInt32(100000, 1000000).ToString();
            emailSent = EmailService.TrySend(matchedUser.Email, "EstateFlow — код восстановления пароля",
                $"Здравствуйте, {matchedUser.FullName}!\n\n" +
                $"Ваш код подтверждения для смены пароля: {code}\n" +
                "Никому не передавайте этот код.");
            return null;
        }

        public static string ChangePasswordByUserId(int userId, string newPassword)
        {
            string passErr = Validator.Password(newPassword);
            if (passErr != null)
                return passErr;

            UserService.ChangePassword(userId, newPassword);
            return null;
        }
    }
}
