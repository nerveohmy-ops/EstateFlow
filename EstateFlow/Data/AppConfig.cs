using System.Text;
using System.Text.Json;

namespace EstateFlow.Data
{
    public class SmtpSettings
    {
        public bool Enabled { get; set; }
        public string Host { get; set; } = "";
        public int Port { get; set; } = 587;
        public bool EnableSsl { get; set; } = true;
        public string User { get; set; } = "";
        public string Password { get; set; } = "";
        public string From { get; set; } = "";
    }

    public class AppConfig
    {
        public string ConnectionString { get; set; } =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True";

        public bool AutoCreateDatabase { get; set; } = true;
        public string AgentInviteCode { get; set; } = "AGENT-2026";
        public SmtpSettings Smtp { get; set; } = new SmtpSettings();

        private static AppConfig _current;
        public static AppConfig Current => _current ??= Load();

        private static string RememberFilePath
        {
            get
            {
                string dir = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "EstateFlow");
                Directory.CreateDirectory(dir);
                return Path.Combine(dir, "remember.txt");
            }
        }

        public static (string Login, string Password) GetRememberedCredentials()
        {
            try
            {
                if (File.Exists(RememberFilePath))
                {
                    var lines = File.ReadAllLines(RememberFilePath, Encoding.UTF8);
                    string login = lines.Length > 0 ? lines[0].Trim() : "";
                    string password = lines.Length > 1 ? lines[1] : "";
                    return (login, password);
                }
            }
            catch { }
            return ("", "");
        }

        public static void SaveRememberedCredentials(string login, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(login))
                {
                    if (File.Exists(RememberFilePath))
                        File.Delete(RememberFilePath);
                }
                else
                {
                    File.WriteAllLines(RememberFilePath, new[] { login.Trim(), password ?? "" }, Encoding.UTF8);
                }
            }
            catch { }
        }

        private static AppConfig Load()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
            if (!File.Exists(path))
                return new AppConfig();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return JsonSerializer.Deserialize<AppConfig>(File.ReadAllText(path), options) ?? new AppConfig();
        }
    }
}
