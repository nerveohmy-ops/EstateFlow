using EstateFlow.Data;
using EstateFlow.Forms;
using EstateFlow.Helpers;
using EstateFlow.Services;

namespace EstateFlow
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                if (AppConfig.Current.AutoCreateDatabase)
                    DbInitializer.Initialize();
                else if (!Database.TestConnection(out string error))
                    throw new Exception(error);
            }
            catch (Exception ex)
            {
                UiTheme.Error("Не удалось подключиться к БД:\n" + ex.Message);
                return;
            }

            while (true)
            {
                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                        break;
                }

                using (var main = new MainForm())
                {
                    main.ShowDialog();
                    if (!main.LogoutRequested)
                        break;
                }
                Session.Logout();
            }
        }
    }
}
