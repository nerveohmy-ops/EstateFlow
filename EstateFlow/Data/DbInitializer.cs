using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using EstateFlow.Helpers;

namespace EstateFlow.Data
{
    public static class DbInitializer
    {
        public static void Initialize()
        {
            RunScript();
            HashPlainPasswords();
        }

        public static void ResetDatabase()
        {
            Database.Execute(@"
                DELETE FROM dbo.Showings;
                DELETE FROM dbo.Deals;
                DELETE FROM dbo.Properties;
                DELETE FROM dbo.PropertyTypes;
                DELETE FROM dbo.Users;
                DELETE FROM dbo.Roles;
                DBCC CHECKIDENT ('dbo.Showings', RESEED, 0);
                DBCC CHECKIDENT ('dbo.Deals', RESEED, 0);");
            Initialize();
        }

        private static void RunScript()
        {
            string scriptPath = Path.Combine(AppContext.BaseDirectory, "Database", "RealEstateDB.sql");
            if (!File.Exists(scriptPath))
                return;

            var builder = new SqlConnectionStringBuilder(Database.ConnectionString) { InitialCatalog = "master" };

            string script = File.ReadAllText(scriptPath, Encoding.UTF8);
            string[] batches = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

            using var connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
            foreach (string batch in batches)
            {
                if (string.IsNullOrWhiteSpace(batch))
                    continue;
                using var command = new SqlCommand(batch, connection) { CommandTimeout = 120 };
                command.ExecuteNonQuery();
            }
        }

        private static void HashPlainPasswords()
        {
            var table = Database.GetTable("SELECT Id, Password FROM Users");
            foreach (System.Data.DataRow row in table.Rows)
            {
                string password = row["Password"].ToString();
                if (PasswordHasher.IsHashed(password))
                    continue;

                Database.Execute("UPDATE Users SET Password = @p WHERE Id = @id",
                    Database.P("@p", PasswordHasher.Hash(password)),
                    Database.P("@id", row["Id"]));
            }
        }
    }
}
