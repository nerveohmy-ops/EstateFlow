using System.Data;
using EstateFlow.Data;
using EstateFlow.Models;

namespace EstateFlow.Services
{
    public static class PropertyService
    {
        public static DataTable GetList(string search, int? typeId, string status,
            decimal? minPrice, decimal? maxPrice, int? agentId)
        {
            return Database.GetTable(
                @"SELECT p.Id, p.Address AS [Адрес], t.Name AS [Тип], p.Area AS [Площадь, м²],
                         p.Price AS [Цена, ₽], p.Status AS [Статус], u.FullName AS [Агент],
                         p.Description AS [Описание], p.CreatedAt AS [Добавлен]
                  FROM Properties p
                  JOIN PropertyTypes t ON t.Id = p.TypeId
                  LEFT JOIN Users u ON u.Id = p.AgentId
                  WHERE (@s = '' OR p.Address LIKE '%' + @s + '%' OR p.Description LIKE '%' + @s + '%')
                    AND (@type IS NULL OR p.TypeId = @type)
                    AND (@status = '' OR p.Status = @status)
                    AND (@min IS NULL OR p.Price >= @min)
                    AND (@max IS NULL OR p.Price <= @max)
                    AND (@agent IS NULL OR p.AgentId = @agent)
                  ORDER BY p.Id",
                Database.P("@s", search?.Trim() ?? ""),
                Database.P("@type", typeId),
                Database.P("@status", status ?? ""),
                Database.P("@min", minPrice),
                Database.P("@max", maxPrice),
                Database.P("@agent", agentId));
        }

        public static Property GetById(int id)
        {
            var t = Database.GetTable("SELECT * FROM Properties WHERE Id = @id", Database.P("@id", id));
            if (t.Rows.Count == 0) return null;
            var r = t.Rows[0];
            return new Property
            {
                Id = id,
                Address = r["Address"].ToString(),
                TypeId = (int)r["TypeId"],
                Area = (decimal)r["Area"],
                Price = (decimal)r["Price"],
                Status = r["Status"].ToString(),
                AgentId = r["AgentId"] as int?,
                Description = r["Description"] as string
            };
        }

        public static void Save(Property p)
        {
            var parameters = new[]
            {
                Database.P("@addr", p.Address.Trim()),
                Database.P("@type", p.TypeId),
                Database.P("@area", p.Area),
                Database.P("@price", p.Price),
                Database.P("@status", p.Status),
                Database.P("@agent", p.AgentId),
                Database.P("@descr", string.IsNullOrWhiteSpace(p.Description) ? null : p.Description.Trim()),
                Database.P("@id", p.Id)
            };

            if (p.Id == 0)
                Database.Execute(
                    @"INSERT INTO Properties (Address, TypeId, Area, Price, Status, AgentId, CreatedAt, Description)
                      VALUES (@addr, @type, @area, @price, @status, @agent, GETDATE(), @descr)", parameters);
            else
                Database.Execute(
                    @"UPDATE Properties SET Address = @addr, TypeId = @type, Area = @area, Price = @price,
                             Status = @status, AgentId = @agent, Description = @descr
                      WHERE Id = @id", parameters);
        }

        public static void Delete(int id)
        {
            int links = Convert.ToInt32(Database.Scalar(
                @"SELECT (SELECT COUNT(*) FROM Deals WHERE PropertyId = @id)
                       + (SELECT COUNT(*) FROM Showings WHERE PropertyId = @id)", Database.P("@id", id)));
            if (links > 0)
                throw new InvalidOperationException("Нельзя удалить объект: по нему есть сделки или заявки на просмотр.");
            Database.Execute("DELETE FROM Properties WHERE Id = @id", Database.P("@id", id));
        }

        public static List<LookupItem> GetLookup(bool excludeSold = false, int? includePropertyId = null)
        {
            var t = Database.GetTable(
                @"SELECT Id, Address, Price, Status FROM Properties
                  WHERE (@excl = 0 OR Status <> @sold OR Id = @inc)
                  ORDER BY Address",
                Database.P("@excl", excludeSold ? 1 : 0),
                Database.P("@sold", PropertyStatus.Sold),
                Database.P("@inc", includePropertyId));

            return t.AsEnumerable()
                .Select(r => new LookupItem((int)r["Id"],
                    $"{r["Address"]} — {(decimal)r["Price"]:N0} ₽ ({r["Status"]})"))
                .ToList();
        }

        public static List<LookupItem> GetTypes()
        {
            var t = Database.GetTable("SELECT Id, Name FROM PropertyTypes ORDER BY Name");
            return t.AsEnumerable().Select(r => new LookupItem((int)r["Id"], r["Name"].ToString())).ToList();
        }

        public static DataTable GetTypesTable() => Database.GetTable(
            @"SELECT t.Id, t.Name AS [Тип недвижимости],
                     (SELECT COUNT(*) FROM Properties p WHERE p.TypeId = t.Id) AS [Кол-во объектов]
              FROM PropertyTypes t ORDER BY t.Name");

        public static bool TypeExists(string name, int excludeId = 0) =>
            Convert.ToInt32(Database.Scalar("SELECT COUNT(*) FROM PropertyTypes WHERE Name = @n AND Id <> @id",
                Database.P("@n", name.Trim()), Database.P("@id", excludeId))) > 0;

        public static void AddType(string name) =>
            Database.Execute("INSERT INTO PropertyTypes (Name) VALUES (@n)", Database.P("@n", name.Trim()));

        public static void RenameType(int id, string name) =>
            Database.Execute("UPDATE PropertyTypes SET Name = @n WHERE Id = @id",
                Database.P("@n", name.Trim()), Database.P("@id", id));

        public static void DeleteType(int id)
        {
            int used = Convert.ToInt32(Database.Scalar("SELECT COUNT(*) FROM Properties WHERE TypeId = @id",
                Database.P("@id", id)));
            if (used > 0)
                throw new InvalidOperationException("Нельзя удалить тип: к нему относятся объекты недвижимости.");
            Database.Execute("DELETE FROM PropertyTypes WHERE Id = @id", Database.P("@id", id));
        }
    }
}
