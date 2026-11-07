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
            var user = UserService.FindByIdentity(identity);
            if (user == null || !PasswordHasher.Verify(password, user.PasswordHash))
                return null;
            return user;
        }

        public static string ResetPassword(string identity, string secretWord, out string newPassword,
            out bool emailSent, out string email)
        {
            newPassword = null;
            emailSent = false;
            email = null;

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
