using System.Net;
using System.Net.Mail;
using EstateFlow.Data;

namespace EstateFlow.Services
{
    public static class EmailService
    {
        public static bool TrySend(string to, string subject, string body)
        {
            var s = AppConfig.Current.Smtp;
            if (s == null || !s.Enabled)
                return false;

            try
            {
                using var message = new MailMessage(s.From, to, subject, body);
                using var client = new SmtpClient(s.Host, s.Port)
                {
                    EnableSsl = s.EnableSsl,
                    Credentials = new NetworkCredential(s.User, s.Password)
                };
                client.Send(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
