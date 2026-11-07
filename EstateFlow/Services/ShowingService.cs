using System.Data;
using EstateFlow.Data;
using EstateFlow.Models;

namespace EstateFlow.Services
{
    public static class ShowingService
    {
        public static DataTable GetList(string status, int? agentId, int? clientId)
        {
            return Database.GetTable(
                @"SELECT s.Id, s.ShowDate AS [Дата и время], p.Address AS [Объект], c.FullName AS [Клиент],
                         c.Phone AS [Телефон клиента], a.FullName AS [Агент], s.Status AS [Статус],
                         s.Comment AS [Комментарий]
                  FROM Showings s
                  JOIN Properties p ON p.Id = s.PropertyId
                  JOIN Users c ON c.Id = s.ClientId
                  LEFT JOIN Users a ON a.Id = s.AgentId
                  WHERE (@status = '' OR s.Status = @status)
                    AND (@agent IS NULL OR s.AgentId = @agent OR s.AgentId IS NULL)
                    AND (@client IS NULL OR s.ClientId = @client)
                  ORDER BY s.ShowDate DESC",
                Database.P("@status", status ?? ""),
                Database.P("@agent", agentId),
                Database.P("@client", clientId));
        }

        public static Showing GetById(int id)
        {
            var t = Database.GetTable("SELECT * FROM Showings WHERE Id = @id", Database.P("@id", id));
            if (t.Rows.Count == 0) return null;
            var r = t.Rows[0];
            return new Showing
            {
                Id = id,
                PropertyId = (int)r["PropertyId"],
                ClientId = (int)r["ClientId"],
                AgentId = r["AgentId"] as int?,
                ShowDate = (DateTime)r["ShowDate"],
                Status = r["Status"].ToString(),
                Comment = r["Comment"] as string
            };
        }

        public static void Save(Showing s)
        {
            var parameters = new[]
            {
                Database.P("@prop", s.PropertyId), Database.P("@client", s.ClientId),
                Database.P("@agent", s.AgentId), Database.P("@date", s.ShowDate),
                Database.P("@status", s.Status),
                Database.P("@comment", string.IsNullOrWhiteSpace(s.Comment) ? null : s.Comment.Trim()),
                Database.P("@id", s.Id)
            };
            if (s.Id == 0)
                Database.Execute(
                    @"INSERT INTO Showings (PropertyId, ClientId, AgentId, ShowDate, Status, Comment, CreatedAt)
                      VALUES (@prop, @client, @agent, @date, @status, @comment, GETDATE())", parameters);
            else
                Database.Execute(
                    @"UPDATE Showings SET PropertyId = @prop, ClientId = @client, AgentId = @agent,
                             ShowDate = @date, Status = @status, Comment = @comment
                      WHERE Id = @id", parameters);
        }

        public static void SetStatus(int id, string status) =>
            Database.Execute("UPDATE Showings SET Status = @s WHERE Id = @id",
                Database.P("@s", status), Database.P("@id", id));

        public static void Delete(int id) =>
            Database.Execute("DELETE FROM Showings WHERE Id = @id", Database.P("@id", id));
    }
}
