using System.Data;
using Microsoft.Data.SqlClient;
using EstateFlow.Data;
using EstateFlow.Models;

namespace EstateFlow.Services
{
    public static class DealService
    {
        public static DataTable GetList(string search, string status, int? agentId, int? clientId,
            DateTime? from, DateTime? to)
        {
            return Database.GetTable(
                @"SELECT d.Id, d.DealDate AS [Дата], p.Address AS [Объект], c.FullName AS [Клиент],
                         a.FullName AS [Агент], d.Amount AS [Сумма, ₽], d.Status AS [Статус]
                  FROM Deals d
                  JOIN Properties p ON p.Id = d.PropertyId
                  JOIN Users c ON c.Id = d.ClientId
                  JOIN Users a ON a.Id = d.AgentId
                  WHERE (@s = '' OR p.Address LIKE '%' + @s + '%' OR c.FullName LIKE '%' + @s + '%'
                         OR a.FullName LIKE '%' + @s + '%')
                    AND (@status = '' OR d.Status = @status)
                    AND (@agent IS NULL OR d.AgentId = @agent)
                    AND (@client IS NULL OR d.ClientId = @client)
                    AND (@from IS NULL OR d.DealDate >= @from)
                    AND (@to IS NULL OR d.DealDate < DATEADD(DAY, 1, @to))
                  ORDER BY d.DealDate DESC",
                Database.P("@s", search?.Trim() ?? ""),
                Database.P("@status", status ?? ""),
                Database.P("@agent", agentId),
                Database.P("@client", clientId),
                Database.P("@from", from?.Date),
                Database.P("@to", to?.Date));
        }

        public static Deal GetById(int id)
        {
            var t = Database.GetTable("SELECT * FROM Deals WHERE Id = @id", Database.P("@id", id));
            if (t.Rows.Count == 0) return null;
            var r = t.Rows[0];
            return new Deal
            {
                Id = id,
                PropertyId = (int)r["PropertyId"],
                ClientId = (int)r["ClientId"],
                AgentId = (int)r["AgentId"],
                DealDate = (DateTime)r["DealDate"],
                Amount = (decimal)r["Amount"],
                Status = r["Status"].ToString()
            };
        }

        public static bool HasActiveDeal(int propertyId, int excludeDealId) =>
            Convert.ToInt32(Database.Scalar(
                @"SELECT COUNT(*) FROM Deals WHERE PropertyId = @p AND Id <> @id AND Status <> @cancel",
                Database.P("@p", propertyId), Database.P("@id", excludeDealId),
                Database.P("@cancel", DealStatus.Cancelled))) > 0;

        public static void Save(Deal d)
        {
            int? oldPropertyId = d.Id > 0 ? GetById(d.Id)?.PropertyId : null;

            using var connection = Database.GetConnection();
            using var tx = connection.BeginTransaction();
            try
            {
                string sql = d.Id == 0
                    ? @"INSERT INTO Deals (PropertyId, ClientId, AgentId, DealDate, Amount, Status)
                        VALUES (@prop, @client, @agent, @date, @amount, @status)"
                    : @"UPDATE Deals SET PropertyId = @prop, ClientId = @client, AgentId = @agent,
                               DealDate = @date, Amount = @amount, Status = @status
                        WHERE Id = @id";

                using (var cmd = Database.CreateCommand(connection, sql,
                           Database.P("@prop", d.PropertyId), Database.P("@client", d.ClientId),
                           Database.P("@agent", d.AgentId), Database.P("@date", d.DealDate),
                           Database.P("@amount", d.Amount), Database.P("@status", d.Status),
                           Database.P("@id", d.Id)))
                {
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                }

                SyncPropertyStatus(connection, tx, d.PropertyId);
                if (oldPropertyId.HasValue && oldPropertyId.Value != d.PropertyId)
                    SyncPropertyStatus(connection, tx, oldPropertyId.Value);

                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        public static void Delete(int id)
        {
            var deal = GetById(id);
            if (deal == null) return;

            using var connection = Database.GetConnection();
            using var tx = connection.BeginTransaction();
            try
            {
                using (var cmd = Database.CreateCommand(connection, "DELETE FROM Deals WHERE Id = @id", Database.P("@id", id)))
                {
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                }

                SyncPropertyStatus(connection, tx, deal.PropertyId);
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        // пересчет статуса объекта по фактическим сделкам
        private static void SyncPropertyStatus(SqlConnection conn, SqlTransaction tx, int propertyId)
        {
            const string sql = @"
                UPDATE Properties
                SET Status = CASE
                    WHEN EXISTS (SELECT 1 FROM Deals WHERE PropertyId = @id AND Status = N'Завершена') THEN N'Продан'
                    WHEN EXISTS (SELECT 1 FROM Deals WHERE PropertyId = @id AND Status = N'В процессе') THEN N'Забронирован'
                    ELSE N'Свободен'
                END
                WHERE Id = @id";

            using var cmd = Database.CreateCommand(conn, sql, Database.P("@id", propertyId));
            cmd.Transaction = tx;
            cmd.ExecuteNonQuery();
        }
    }
}
