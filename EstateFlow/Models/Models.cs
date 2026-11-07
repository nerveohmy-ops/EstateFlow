namespace EstateFlow.Models
{
    public enum UserRole
    {
        Admin = 1,
        Agent = 2,
        Client = 3
    }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string SecretWord { get; set; }

        public UserRole Role => (UserRole)RoleId;
        public bool IsAdmin => Role == UserRole.Admin;
        public bool IsAgent => Role == UserRole.Agent;
        public bool IsClient => Role == UserRole.Client;
    }

    public class Property
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int TypeId { get; set; }
        public decimal Area { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; } = PropertyStatus.Free;
        public int? AgentId { get; set; }
        public string Description { get; set; }
    }

    public class Deal
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int ClientId { get; set; }
        public int AgentId { get; set; }
        public DateTime DealDate { get; set; } = DateTime.Today;
        public decimal Amount { get; set; }
        public string Status { get; set; } = DealStatus.InProgress;
    }

    public class Showing
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int ClientId { get; set; }
        public int? AgentId { get; set; }
        public DateTime ShowDate { get; set; } = DateTime.Today.AddDays(1).AddHours(12);
        public string Status { get; set; } = ShowingStatus.New;
        public string Comment { get; set; }
    }

    public class LookupItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LookupItem(int id, string name) { Id = id; Name = name; }
        public override string ToString() => Name;
    }

    public static class PropertyStatus
    {
        public const string Free = "Свободен";
        public const string Reserved = "Забронирован";
        public const string Sold = "Продан";
        public static readonly string[] All = { Free, Reserved, Sold };
    }

    public static class DealStatus
    {
        public const string InProgress = "В процессе";
        public const string Completed = "Завершена";
        public const string Cancelled = "Отменена";
        public static readonly string[] All = { InProgress, Completed, Cancelled };
    }

    public static class ShowingStatus
    {
        public const string New = "Новая";
        public const string Confirmed = "Подтверждена";
        public const string Done = "Проведена";
        public const string Cancelled = "Отменена";
        public static readonly string[] All = { New, Confirmed, Done, Cancelled };
    }
}
