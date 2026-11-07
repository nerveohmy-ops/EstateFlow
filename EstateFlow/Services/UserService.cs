using System.Data;
using EstateFlow.Data;
using EstateFlow.Helpers;
using EstateFlow.Models;

namespace EstateFlow.Services
{
    public static class UserService
    {
        private const string SelectUser =
            @"SELECT u.Id, u.Login, u.Password, u.Email, u.Phone, u.FullName, u.RoleId, r.Name AS RoleName,
                     u.CreatedAt, u.SecretWord
              FROM Users u JOIN Roles r ON r.Id = u.RoleId ";

        private static User Map(DataRow r) => new User
        {
            Id = (int)r["Id"],
            Login = r["Login"].ToString(),
            PasswordHash = r["Password"].ToString(),
            Email = r["Email"].ToString(),
            Phone = r["Phone"].ToString(),
            FullName = r["FullName"].ToString(),
            RoleId = (int)r["RoleId"],
            RoleName = r["RoleName"].ToString(),
            CreatedAt = r["CreatedAt"] as DateTime?,
            SecretWord = r["SecretWord"] as string
        };

        public static User GetById(int id)
        {
            var t = Database.GetTable(SelectUser + "WHERE u.Id = @id", Database.P("@id", id));
            return t.Rows.Count == 0 ? null : Map(t.Rows[0]);
        }

        public static User FindByIdentity(string identity)
        {
            var t = Database.GetTable(SelectUser + "WHERE u.Login = @v OR u.Email = @v OR u.Phone = @v",
                Database.P("@v", identity.Trim()));
            return t.Rows.Count == 0 ? null : Map(t.Rows[0]);
        }

        public static bool LoginExists(string login, int excludeId = 0) => Exists("Login", login, excludeId);
        public static bool EmailExists(string email, int excludeId = 0) => Exists("Email", email, excludeId);
        public static bool PhoneExists(string phone, int excludeId = 0) => Exists("Phone", phone, excludeId);

        private static bool Exists(string column, string value, int excludeId) =>
            Convert.ToInt32(Database.Scalar($"SELECT COUNT(*) FROM Users WHERE {column} = @v AND Id <> @id",
                Database.P("@v", value.Trim()), Database.P("@id", excludeId))) > 0;

        public static int Create(User user, string password)
        {
            return Convert.ToInt32(Database.Scalar(
                @"INSERT INTO Users (Login, Password, Email, Phone, FullName, RoleId, CreatedAt, SecretWord)
                  VALUES (@login, @pass, @email, @phone, @name, @role, GETDATE(), @secret);
                  SELECT CAST(SCOPE_IDENTITY() AS INT);",
                Database.P("@login", user.Login.Trim()),
                Database.P("@pass", PasswordHasher.Hash(password)),
                Database.P("@email", user.Email.Trim()),
                Database.P("@phone", user.Phone),
                Database.P("@name", user.FullName.Trim()),
                Database.P("@role", user.RoleId),
                Database.P("@secret", user.SecretWord?.Trim().ToLower())));
        }

        public static void Update(User user)
        {
            Database.Execute(
                @"UPDATE Users SET Login = @login, Email = @email, Phone = @phone, FullName = @name,
                         RoleId = @role, SecretWord = @secret
                  WHERE Id = @id",
                Database.P("@login", user.Login.Trim()),
                Database.P("@email", user.Email.Trim()),
                Database.P("@phone", user.Phone),
                Database.P("@name", user.FullName.Trim()),
                Database.P("@role", user.RoleId),
                Database.P("@secret", user.SecretWord?.Trim().ToLower()),
                Database.P("@id", user.Id));
        }

        public static void ChangePassword(int userId, string newPassword)
        {
            Database.Execute("UPDATE Users SET Password = @p WHERE Id = @id",
                Database.P("@p", PasswordHasher.Hash(newPassword)), Database.P("@id", userId));
        }

        public static void Delete(int id)
        {
            int links = Convert.ToInt32(Database.Scalar(
                @"SELECT (SELECT COUNT(*) FROM Deals WHERE ClientId = @id OR AgentId = @id)
                       + (SELECT COUNT(*) FROM Showings WHERE ClientId = @id OR AgentId = @id)",
                Database.P("@id", id)));
            if (links > 0)
                throw new InvalidOperationException("Нельзя удалить пользователя: с ним связаны сделки или заявки.");

            Database.Execute("UPDATE Properties SET AgentId = NULL WHERE AgentId = @id", Database.P("@id", id));
            Database.Execute("DELETE FROM Users WHERE Id = @id", Database.P("@id", id));
        }

        public static DataTable GetList(string search, int? roleId)
        {
            return Database.GetTable(
                @"SELECT u.Id, u.FullName AS [ФИО], u.Login AS [Логин], u.Email AS [Email],
                         u.Phone AS [Телефон], r.Name AS [Роль], u.CreatedAt AS [Дата регистрации]
                  FROM Users u JOIN Roles r ON r.Id = u.RoleId
                  WHERE (@role IS NULL OR u.RoleId = @role)
                    AND (@s = '' OR u.FullName LIKE '%' + @s + '%' OR u.Login LIKE '%' + @s + '%'
                         OR u.Email LIKE '%' + @s + '%' OR u.Phone LIKE '%' + @s + '%')
                  ORDER BY r.Id, u.FullName",
                Database.P("@role", roleId), Database.P("@s", search?.Trim() ?? ""));
        }

        public static List<LookupItem> GetLookup(UserRole role)
        {
            var t = Database.GetTable("SELECT Id, FullName FROM Users WHERE RoleId = @r ORDER BY FullName",
                Database.P("@r", (int)role));
            return t.AsEnumerable().Select(r => new LookupItem((int)r["Id"], r["FullName"].ToString())).ToList();
        }

        public static List<LookupItem> GetRoles()
        {
            var t = Database.GetTable("SELECT Id, Name FROM Roles ORDER BY Id");
            return t.AsEnumerable().Select(r => new LookupItem((int)r["Id"], r["Name"].ToString())).ToList();
        }
    }
}
