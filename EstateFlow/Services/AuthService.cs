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
            string secretWord = (user.SecretWord ?? "").Trim();

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

            string secretErr = Validator.SecretWord(secretWord);
            if (secretErr != null) throw new InvalidOperationException(secretErr);

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
                RoleId = (int)UserRole.Client,
                SecretWord = secretWord
            };

            return UserService.Create(clientUser, password);
        }

        public static string ResetPassword(string identity, string secretWord, out string newPassword,
            out bool emailSent, out string email)
        {
            newPassword = null;
            emailSent = false;
            email = null;

            if (string.IsNullOrWhiteSpace(identity))
                return "Введите логин, email или телефон.";
            if (string.IsNullOrWhiteSpace(secretWord))
                return "Введите секретное слово.";

            var user = UserService.FindByIdentity(identity);
            if (user == null)
                return "Пользователь не найден.";

            if (!string.Equals(user.SecretWord?.Trim(), secretWord?.Trim(), StringComparison.OrdinalIgnoreCase))
                return "Секретное слово указано неверно.";

            newPassword = PasswordHasher.Generate();
            UserService.ChangePassword(user.Id, newPassword);
            email = user.Email;

            emailSent = EmailService.TrySend(user.Email, "EstateFlow — восстановление пароля",
                $"Здравствуйте, {user.FullName}!\n\n" +
                $"Ваш новый пароль: {newPassword}\n" +
                "После входа рекомендуем сменить его в личном кабинете.");
            return null;
        }
    }
}
