using System.Data;
using EstateFlow.Data;
using EstateFlow.Models;

namespace EstateFlow.Services
{
    public static class PropertyService
    {
        public static DataTable GetList(string search, int? typeId, string status,
            decimal? minPrice, decimal? maxPrice, int? agentId,
            int? rooms = null, string district = null, string sortBy = null)
        {
            string orderBy = "p.Id DESC";
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy.ToLowerInvariant())
                {
                    case "price_asc":
                        orderBy = "p.Price ASC";
                        break;
                    case "price_desc":
                        orderBy = "p.Price DESC";
                        break;
                    case "area_desc":
                        orderBy = "p.Area DESC";
                        break;
                    case "rooms_asc":
                        orderBy = "p.Rooms ASC, p.Price ASC";
                        break;
                    case "id_asc":
                        orderBy = "p.Id ASC";
                        break;
                    case "newest":
                    default:
                        orderBy = "p.Id DESC";
                        break;
                }
            }

            string sql = $@"SELECT p.Id,
                                   p.Address AS [Адрес],
                                   ISNULL(p.District, N'Центр') AS [Район],
                                   t.Name AS [Тип],
                                   CASE WHEN p.Rooms = 0 THEN N'Студия' ELSE CAST(p.Rooms AS NVARCHAR) END AS [Комнат],
                                   CASE WHEN p.Floor IS NOT NULL AND p.TotalFloors IS NOT NULL
                                        THEN CAST(p.Floor AS NVARCHAR) + '/' + CAST(p.TotalFloors AS NVARCHAR)
                                        WHEN p.Floor IS NOT NULL THEN CAST(p.Floor AS NVARCHAR)
                                        ELSE N'' END AS [Этаж],
                                   p.Area AS [Площадь, м²],
                                   p.Price AS [Цена, ₽],
                                   p.Status AS [Статус],
                                   u.FullName AS [Агент],
                                   p.Description AS [Описание],
                                   p.Photo AS [Фото]
                            FROM Properties p
                            JOIN PropertyTypes t ON t.Id = p.TypeId
                            LEFT JOIN Users u ON u.Id = p.AgentId
                            WHERE (@s = '' OR p.Address LIKE '%' + @s + '%' OR p.Description LIKE '%' + @s + '%' OR ISNULL(p.District, '') LIKE '%' + @s + '%')
                              AND (@type IS NULL OR p.TypeId = @type)
                              AND (@status = '' OR p.Status = @status)
                              AND (@min IS NULL OR p.Price >= @min)
                              AND (@max IS NULL OR p.Price <= @max)
                              AND (@agent IS NULL OR p.AgentId = @agent)
                              AND (@rooms IS NULL OR (@rooms = 4 AND p.Rooms >= 4) OR (@rooms <> 4 AND p.Rooms = @rooms))
                              AND (@district = '' OR p.District = @district)
                            ORDER BY {orderBy}";

            return Database.GetTable(
                sql,
                Database.P("@s", search?.Trim() ?? ""),
                Database.P("@type", typeId),
                Database.P("@status", status ?? ""),
                Database.P("@min", minPrice),
                Database.P("@max", maxPrice),
                Database.P("@agent", agentId),
                Database.P("@rooms", rooms),
                Database.P("@district", string.IsNullOrWhiteSpace(district) || district == "Все районы" ? "" : district.Trim()));
        }

        public static List<Property> GetProperties(string search, int? typeId, string status,
            decimal? minPrice, decimal? maxPrice, int? agentId,
            int? rooms = null, string district = null, string sortBy = null)
        {
            string orderBy = "p.Id DESC";
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy.ToLowerInvariant())
                {
                    case "price_asc":
                        orderBy = "p.Price ASC";
                        break;
                    case "price_desc":
                        orderBy = "p.Price DESC";
                        break;
                    case "area_desc":
                        orderBy = "p.Area DESC";
                        break;
                    case "rooms_asc":
                        orderBy = "p.Rooms ASC, p.Price ASC";
                        break;
                    case "id_asc":
                        orderBy = "p.Id ASC";
                        break;
                    case "newest":
                    default:
                        orderBy = "p.Id DESC";
                        break;
                }
            }

            string sql = $@"SELECT p.Id, p.Address, ISNULL(p.District, N'Центр') AS District,
                                   p.TypeId, t.Name AS TypeName,
                                   ISNULL(p.Rooms, 1) AS Rooms,
                                   p.Floor, p.TotalFloors,
                                   p.Area, p.KitchenArea, p.LivingArea, p.YearBuilt,
                                   p.Price, p.Status,
                                   p.AgentId, u.FullName AS AgentName,
                                   p.Description, p.Photo
                            FROM Properties p
                            JOIN PropertyTypes t ON t.Id = p.TypeId
                            LEFT JOIN Users u ON u.Id = p.AgentId
                            WHERE (@s = '' OR p.Address LIKE '%' + @s + '%' OR p.Description LIKE '%' + @s + '%' OR ISNULL(p.District, '') LIKE '%' + @s + '%')
                              AND (@type IS NULL OR p.TypeId = @type)
                              AND (@status = '' OR p.Status = @status)
                              AND (@min IS NULL OR p.Price >= @min)
                              AND (@max IS NULL OR p.Price <= @max)
                              AND (@agent IS NULL OR p.AgentId = @agent)
                              AND (@rooms IS NULL OR (@rooms = 4 AND p.Rooms >= 4) OR (@rooms <> 4 AND p.Rooms = @rooms))
                              AND (@district = '' OR p.District = @district)
                            ORDER BY {orderBy}";

            var table = Database.GetTable(
                sql,
                Database.P("@s", search?.Trim() ?? ""),
                Database.P("@type", typeId),
                Database.P("@status", status ?? ""),
                Database.P("@min", minPrice),
                Database.P("@max", maxPrice),
                Database.P("@agent", agentId),
                Database.P("@rooms", rooms),
                Database.P("@district", string.IsNullOrWhiteSpace(district) || district == "Все районы" ? "" : district.Trim()));

            var list = new List<Property>();
            foreach (DataRow r in table.Rows)
            {
                list.Add(new Property
                {
                    Id = (int)r["Id"],
                    Address = r["Address"]?.ToString() ?? "",
                    District = r["District"]?.ToString() ?? "Центр",
                    TypeId = (int)r["TypeId"],
                    TypeName = r["TypeName"]?.ToString() ?? "",
                    Rooms = Convert.ToInt32(r["Rooms"]),
                    Floor = r["Floor"] == DBNull.Value ? null : Convert.ToInt32(r["Floor"]),
                    TotalFloors = r["TotalFloors"] == DBNull.Value ? null : Convert.ToInt32(r["TotalFloors"]),
                    Area = Convert.ToDecimal(r["Area"]),
                    KitchenArea = r["KitchenArea"] == DBNull.Value ? null : Convert.ToDecimal(r["KitchenArea"]),
                    LivingArea = r["LivingArea"] == DBNull.Value ? null : Convert.ToDecimal(r["LivingArea"]),
                    YearBuilt = r["YearBuilt"] == DBNull.Value ? null : Convert.ToInt32(r["YearBuilt"]),
                    Price = Convert.ToDecimal(r["Price"]),
                    Status = r["Status"]?.ToString() ?? PropertyStatus.Free,
                    AgentId = r["AgentId"] == DBNull.Value ? null : Convert.ToInt32(r["AgentId"]),
                    AgentName = r["AgentName"]?.ToString() ?? "",
                    Description = r["Description"]?.ToString() ?? "",
                    Photo = r["Photo"]?.ToString() ?? ""
                });
            }
            return list;
        }

        public static List<string> GetDistricts()
        {
            var defaultDistricts = new List<string>
            {
                "Центр", "Микрорайон", "КПП", "Тепличный", "Европейский", "Чигири", "Золотая миля", "Северный"
            };

            try
            {
                var table = Database.GetTable("SELECT DISTINCT District FROM Properties WHERE District IS NOT NULL AND District <> '' ORDER BY District");
                var list = table.AsEnumerable().Select(r => r["District"].ToString()).ToList();
                foreach (var d in defaultDistricts)
                {
                    if (!list.Contains(d)) list.Add(d);
                }
                return list;
            }
            catch
            {
                return defaultDistricts;
            }
        }

        public static Property GetById(int id)
        {
            var t = Database.GetTable(
                @"SELECT p.*, t.Name AS TypeName, u.FullName AS AgentName
                  FROM Properties p
                  JOIN PropertyTypes t ON t.Id = p.TypeId
                  LEFT JOIN Users u ON u.Id = p.AgentId
                  WHERE p.Id = @id", Database.P("@id", id));
            if (t.Rows.Count == 0) return null;
            var r = t.Rows[0];
            return new Property
            {
                Id = id,
                Address = r["Address"]?.ToString() ?? "",
                District = r.Table.Columns.Contains("District") && r["District"] != DBNull.Value ? r["District"].ToString() : "Центр",
                TypeId = (int)r["TypeId"],
                TypeName = r.Table.Columns.Contains("TypeName") && r["TypeName"] != DBNull.Value ? r["TypeName"].ToString() : "",
                Rooms = r.Table.Columns.Contains("Rooms") && r["Rooms"] != DBNull.Value ? Convert.ToInt32(r["Rooms"]) : 1,
                Floor = r.Table.Columns.Contains("Floor") && r["Floor"] != DBNull.Value ? Convert.ToInt32(r["Floor"]) : null,
                TotalFloors = r.Table.Columns.Contains("TotalFloors") && r["TotalFloors"] != DBNull.Value ? Convert.ToInt32(r["TotalFloors"]) : null,
                Area = (decimal)r["Area"],
                KitchenArea = r.Table.Columns.Contains("KitchenArea") && r["KitchenArea"] != DBNull.Value ? Convert.ToDecimal(r["KitchenArea"]) : null,
                LivingArea = r.Table.Columns.Contains("LivingArea") && r["LivingArea"] != DBNull.Value ? Convert.ToDecimal(r["LivingArea"]) : null,
                YearBuilt = r.Table.Columns.Contains("YearBuilt") && r["YearBuilt"] != DBNull.Value ? Convert.ToInt32(r["YearBuilt"]) : null,
                Price = (decimal)r["Price"],
                Status = r["Status"].ToString(),
                AgentId = r["AgentId"] as int?,
                AgentName = r.Table.Columns.Contains("AgentName") && r["AgentName"] != DBNull.Value ? r["AgentName"].ToString() : "",
                Description = r["Description"] as string,
                Photo = r.Table.Columns.Contains("Photo") && r["Photo"] != DBNull.Value ? r["Photo"].ToString() : null
            };
        }

        public static void Save(Property p)
        {
            var parameters = new[]
            {
                Database.P("@addr", p.Address.Trim()),
                Database.P("@district", string.IsNullOrWhiteSpace(p.District) ? "Центр" : p.District.Trim()),
                Database.P("@type", p.TypeId),
                Database.P("@rooms", p.Rooms),
                Database.P("@floor", p.Floor),
                Database.P("@totalFloors", p.TotalFloors),
                Database.P("@area", p.Area),
                Database.P("@kitchenArea", p.KitchenArea),
                Database.P("@livingArea", p.LivingArea),
                Database.P("@yearBuilt", p.YearBuilt),
                Database.P("@price", p.Price),
                Database.P("@status", p.Status),
                Database.P("@agent", p.AgentId),
                Database.P("@descr", string.IsNullOrWhiteSpace(p.Description) ? null : p.Description.Trim()),
                Database.P("@photo", string.IsNullOrWhiteSpace(p.Photo) ? null : p.Photo.Trim()),
                Database.P("@id", p.Id)
            };

            if (p.Id == 0)
                Database.Execute(
                    @"INSERT INTO Properties (Address, District, TypeId, Rooms, Floor, TotalFloors,
                                             Area, KitchenArea, LivingArea, YearBuilt, Price, Status,
                                             AgentId, CreatedAt, Description, Photo)
                      VALUES (@addr, @district, @type, @rooms, @floor, @totalFloors,
                              @area, @kitchenArea, @livingArea, @yearBuilt, @price, @status,
                              @agent, GETDATE(), @descr, @photo)", parameters);
            else
                Database.Execute(
                    @"UPDATE Properties SET Address = @addr, District = @district, TypeId = @type,
                             Rooms = @rooms, Floor = @floor, TotalFloors = @totalFloors,
                             Area = @area, KitchenArea = @kitchenArea, LivingArea = @livingArea,
                             YearBuilt = @yearBuilt, Price = @price, Status = @status,
                             AgentId = @agent, Description = @descr, Photo = @photo
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
