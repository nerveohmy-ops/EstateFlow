using EstateFlow.Data;
using EstateFlow.Forms;
using EstateFlow.Helpers;

namespace EstateFlow
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
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

            Application.Run(new LoginForm());
        }
    }
}
