using System.Data;
using System.Text;
using EstateFlow.Data;
using EstateFlow.Models;

namespace EstateFlow.Services
{
    public static class ReportService
    {
        public const string ByAgent = "Эффективность агентов";
        public const string ByMonth = "Сделки по месяцам";
        public const string ByType = "Объекты по типам и статусам";
        public const string ByClient = "Сделки по клиентам";
        public static readonly string[] All = { ByAgent, ByMonth, ByType, ByClient };

        public static DataTable Build(string report, DateTime from, DateTime to, int? agentId)
        {
            var p = new[]
            {
                Database.P("@from", from.Date), Database.P("@to", to.Date.AddDays(1)), Database.P("@agent", agentId),
                Database.P("@done", DealStatus.Completed), Database.P("@work", DealStatus.InProgress),
                Database.P("@cancel", DealStatus.Cancelled)
            };
            const string dealFilter = "d.DealDate >= @from AND d.DealDate < @to AND (@agent IS NULL OR d.AgentId = @agent)";

            return report switch
            {
                ByAgent => Database.GetTable(
                    $@"SELECT a.FullName AS [Агент], COUNT(d.Id) AS [Всего сделок],
                              SUM(CASE WHEN d.Status = @done THEN 1 ELSE 0 END) AS [Завершено],
                              SUM(CASE WHEN d.Status = @work THEN 1 ELSE 0 END) AS [В процессе],
                              SUM(CASE WHEN d.Status = @cancel THEN 1 ELSE 0 END) AS [Отменено],
                              ISNULL(SUM(CASE WHEN d.Status = @done THEN d.Amount END), 0) AS [Сумма продаж, ₽],
                              ISNULL(SUM(CASE WHEN d.Status = @done THEN d.Amount END), 0) * 0.03 AS [Комиссия 3%, ₽]
                       FROM Users a JOIN Deals d ON d.AgentId = a.Id AND {dealFilter}
                       GROUP BY a.FullName ORDER BY [Сумма продаж, ₽] DESC", p),

                ByMonth => Database.GetTable(
                    $@"SELECT FORMAT(d.DealDate, 'yyyy-MM') AS [Месяц], COUNT(*) AS [Сделок],
                              SUM(CASE WHEN d.Status = @done THEN 1 ELSE 0 END) AS [Завершено],
                              ISNULL(SUM(CASE WHEN d.Status = @done THEN d.Amount END), 0) AS [Сумма продаж, ₽]
                       FROM Deals d WHERE {dealFilter}
                       GROUP BY FORMAT(d.DealDate, 'yyyy-MM') ORDER BY [Месяц]", p),

                ByType => Database.GetTable(
                    @"SELECT t.Name AS [Тип], COUNT(pr.Id) AS [Всего объектов],
                             SUM(CASE WHEN pr.Status = N'Свободен' THEN 1 ELSE 0 END) AS [Свободно],
                             SUM(CASE WHEN pr.Status = N'Забронирован' THEN 1 ELSE 0 END) AS [Забронировано],
                             SUM(CASE WHEN pr.Status = N'Продан' THEN 1 ELSE 0 END) AS [Продано],
                             ISNULL(AVG(pr.Price), 0) AS [Средняя цена, ₽],
                             ISNULL(AVG(pr.Price / NULLIF(pr.Area, 0)), 0) AS [Средняя цена м², ₽]
                      FROM PropertyTypes t LEFT JOIN Properties pr ON pr.TypeId = t.Id
                                                AND (@agent IS NULL OR pr.AgentId = @agent)
                      GROUP BY t.Name ORDER BY [Всего объектов] DESC", p),

                _ => Database.GetTable(
                    $@"SELECT c.FullName AS [Клиент], c.Phone AS [Телефон], COUNT(d.Id) AS [Сделок],
                              ISNULL(SUM(CASE WHEN d.Status = @done THEN d.Amount END), 0) AS [Сумма покупок, ₽],
                              MAX(d.DealDate) AS [Последняя сделка]
                       FROM Users c JOIN Deals d ON d.ClientId = c.Id AND {dealFilter}
                       GROUP BY c.FullName, c.Phone ORDER BY [Сумма покупок, ₽] DESC", p)
            };
        }

        public static (int free, int dealsInWork, int newShowings, decimal soldSum) GetDashboard(User user)
        {
            int? agent = user.IsAgent ? user.Id : null;
            int? client = user.IsClient ? user.Id : null;
            var p = new[]
            {
                Database.P("@agent", agent), Database.P("@client", client),
                Database.P("@free", PropertyStatus.Free), Database.P("@work", DealStatus.InProgress),
                Database.P("@new", ShowingStatus.New), Database.P("@conf", ShowingStatus.Confirmed),
                Database.P("@done", DealStatus.Completed)
            };
            var t = Database.GetTable(
                @"SELECT
                    (SELECT COUNT(*) FROM Properties WHERE Status = @free) AS FreeCount,
                    (SELECT COUNT(*) FROM Deals WHERE Status = @work
                        AND (@agent IS NULL OR AgentId = @agent) AND (@client IS NULL OR ClientId = @client)) AS InWork,
                    (SELECT COUNT(*) FROM Showings WHERE Status IN (@new, @conf)
                        AND (@agent IS NULL OR AgentId = @agent OR AgentId IS NULL)
                        AND (@client IS NULL OR ClientId = @client)) AS NewShowings,
                    (SELECT ISNULL(SUM(Amount), 0) FROM Deals WHERE Status = @done
                        AND (@agent IS NULL OR AgentId = @agent) AND (@client IS NULL OR ClientId = @client)) AS SoldSum", p);
            var r = t.Rows[0];
            return ((int)r["FreeCount"], (int)r["InWork"], (int)r["NewShowings"], (decimal)r["SoldSum"]);
        }

        public static void ExportCsv(DataTable table, string path)
        {
            var sb = new StringBuilder();
            var columns = table.Columns.Cast<DataColumn>().Where(c => c.ColumnName != "Id").ToList();
            sb.AppendLine(string.Join(";", columns.Select(c => Escape(c.ColumnName))));
            foreach (DataRow row in table.Rows)
                sb.AppendLine(string.Join(";", columns.Select(c => Escape(Format(row[c])))));
            File.WriteAllText(path, sb.ToString(), new UTF8Encoding(true));
        }

        private static string Format(object v) => v switch
        {
            DateTime d => d.ToString("dd.MM.yyyy HH:mm"),
            decimal m => m.ToString("0.00"),
            null => "",
            _ => v.ToString()
        };

        private static string Escape(string s) =>
            s.Contains(';') || s.Contains('"') || s.Contains('\n') ? "\"" + s.Replace("\"", "\"\"") + "\"" : s;
    }
}
