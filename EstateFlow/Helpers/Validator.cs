using System.Text.RegularExpressions;

namespace EstateFlow.Helpers
{
    public static class Validator
    {
        public const int MinPasswordLength = 12;

        public static string Required(string value, string fieldName) =>
            string.IsNullOrWhiteSpace(value) ? $"Поле «{fieldName}» обязательно для заполнения" : null;

        public static string FullName(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "Введите ФИО";
            var parts = value.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2) return "Введите как минимум фамилию и имя";
            if (!Regex.IsMatch(value, @"^[А-Яа-яЁёA-Za-z\- ]+$")) return "ФИО может содержать только буквы, пробел и дефис";
            if (value.Length > 150) return "ФИО слишком длинное";
            return null;
        }

        public static string Login(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "Введите логин";
            if (value.Length < 4 || value.Length > 50) return "Логин должен быть от 4 до 50 символов";
            if (!Regex.IsMatch(value, @"^[A-Za-z0-9_.]+$")) return "Логин: только латинские буквы, цифры, _ и .";
            return null;
        }

        public static string Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "Введите email";
            if (!value.Contains('@')) return "Email должен содержать @";
            if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[A-Za-zА-Яа-я]{2,}$")) return "Неверный формат email";
            if (value.Length > 100) return "Email слишком длинный";
            return null;
        }

        public static string Phone(string value)
        {
            string digits = new string((value ?? "").Where(char.IsDigit).ToArray());
            if (digits.Length != 11) return "Введите телефон полностью: +7(XXX)XXX-XX-XX";
            return null;
        }

        public static string Password(string value)
        {
            if (string.IsNullOrEmpty(value)) return "Введите пароль";
            var errors = new List<string>();
            if (value.Length < MinPasswordLength) errors.Add($"от {MinPasswordLength} символов");
            if (!value.Any(char.IsLower)) errors.Add("строчную букву");
            if (!value.Any(char.IsUpper)) errors.Add("заглавную букву");
            if (!value.Any(char.IsDigit)) errors.Add("цифру");
            if (value.All(char.IsLetterOrDigit)) errors.Add("спецсимвол");
            if (value.Contains(' ')) return "Пароль не должен содержать пробелы";
            return errors.Count == 0 ? null : "Пароль должен содержать: " + string.Join(", ", errors);
        }

        public static string PasswordRepeat(string password, string repeat) =>
            password != repeat ? "Пароли не совпадают" : null;

        public static string SecretWord(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "Введите секретное слово";
            if (value.Trim().Length < 3) return "Секретное слово — минимум 3 символа";
            return null;
        }

        public static string FullNameParts(string lastName, string firstName, string middleName, out string fullName)
        {
            fullName = "";
            if (string.IsNullOrWhiteSpace(lastName)) return "Введите фамилию";
            if (string.IsNullOrWhiteSpace(firstName)) return "Введите имя";

            fullName = string.Join(" ", new[] { lastName.Trim(), firstName.Trim(), (middleName ?? "").Trim() }
                .Where(s => !string.IsNullOrWhiteSpace(s)));

            if (!Regex.IsMatch(fullName, @"^[А-Яа-яЁёA-Za-z\- ]+$"))
                return "ФИО может содержать только буквы, пробел и дефис";
            if (fullName.Length > 150)
                return "ФИО слишком длинное";
            return null;
        }

        public static void SplitFullName(string fullName, out string lastName, out string firstName, out string middleName)
        {
            var parts = (fullName ?? "").Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            lastName = parts.Length > 0 ? parts[0] : "";
            firstName = parts.Length > 1 ? parts[1] : "";
            middleName = parts.Length > 2 ? string.Join(" ", parts.Skip(2)) : "";
        }

        public static string AddressParts(string city, string street, string house, string apartment, out string fullAddress)
        {
            fullAddress = "";
            city = (city ?? "").Trim();
            street = (street ?? "").Trim();
            house = (house ?? "").Trim();
            apartment = (apartment ?? "").Trim();

            if (string.IsNullOrWhiteSpace(city)) return "Укажите город (населённый пункт)";
            if (string.IsNullOrWhiteSpace(street)) return "Укажите улицу";
            if (string.IsNullOrWhiteSpace(house)) return "Укажите номер дома или участка";

            string cityPart = (city.StartsWith("г.", StringComparison.OrdinalIgnoreCase) ||
                               city.StartsWith("с.", StringComparison.OrdinalIgnoreCase) ||
                               city.StartsWith("п.", StringComparison.OrdinalIgnoreCase) ||
                               city.Contains("р-н", StringComparison.OrdinalIgnoreCase))
                ? city : "г. " + city;

            string streetPart = (street.StartsWith("ул.", StringComparison.OrdinalIgnoreCase) ||
                                 street.StartsWith("пр", StringComparison.OrdinalIgnoreCase) ||
                                 street.StartsWith("пер", StringComparison.OrdinalIgnoreCase) ||
                                 street.StartsWith("б-р", StringComparison.OrdinalIgnoreCase) ||
                                 street.StartsWith("ш.", StringComparison.OrdinalIgnoreCase))
                ? street : "ул. " + street;

            string housePart = (house.StartsWith("д.", StringComparison.OrdinalIgnoreCase) ||
                                house.StartsWith("уч.", StringComparison.OrdinalIgnoreCase))
                ? house : "д. " + house;

            string aptPart = "";
            if (!string.IsNullOrWhiteSpace(apartment))
            {
                aptPart = (apartment.StartsWith("кв.", StringComparison.OrdinalIgnoreCase) ||
                           apartment.StartsWith("оф.", StringComparison.OrdinalIgnoreCase) ||
                           apartment.StartsWith("пом.", StringComparison.OrdinalIgnoreCase))
                    ? ", " + apartment
                    : ", кв. " + apartment;
            }

            fullAddress = $"{cityPart}, {streetPart}, {housePart}{aptPart}";
            return null;
        }

        public static void SplitAddress(string fullAddress, out string city, out string street, out string house, out string apartment)
        {
            city = "";
            street = "";
            house = "";
            apartment = "";
            if (string.IsNullOrWhiteSpace(fullAddress)) return;

            var parts = fullAddress.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                   .Select(p => p.Trim())
                                   .ToList();

            foreach (var part in parts)
            {
                if (part.StartsWith("кв.", StringComparison.OrdinalIgnoreCase) ||
                    part.StartsWith("оф.", StringComparison.OrdinalIgnoreCase) ||
                    part.StartsWith("пом.", StringComparison.OrdinalIgnoreCase))
                {
                    apartment = Regex.Replace(part, @"^(кв\.|оф\.|пом\.)\s*", "", RegexOptions.IgnoreCase).Trim();
                }
                else if (part.StartsWith("д.", StringComparison.OrdinalIgnoreCase) ||
                         part.StartsWith("дом ", StringComparison.OrdinalIgnoreCase) ||
                         part.StartsWith("уч.", StringComparison.OrdinalIgnoreCase))
                {
                    house = Regex.Replace(part, @"^(д\.|дом)\s*", "", RegexOptions.IgnoreCase).Trim();
                }
                else if (part.StartsWith("ул.", StringComparison.OrdinalIgnoreCase) ||
                         part.StartsWith("пр.", StringComparison.OrdinalIgnoreCase) ||
                         part.StartsWith("пр-т", StringComparison.OrdinalIgnoreCase) ||
                         part.StartsWith("пер.", StringComparison.OrdinalIgnoreCase))
                {
                    street = Regex.Replace(part, @"^ул\.\s*", "", RegexOptions.IgnoreCase).Trim();
                }
                else if (string.IsNullOrEmpty(city))
                {
                    city = Regex.Replace(part, @"^г\.\s*", "", RegexOptions.IgnoreCase).Trim();
                }
                else if (string.IsNullOrEmpty(street))
                {
                    street = Regex.Replace(part, @"^ул\.\s*", "", RegexOptions.IgnoreCase).Trim();
                }
                else if (string.IsNullOrEmpty(house))
                {
                    house = Regex.Replace(part, @"^д\.\s*", "", RegexOptions.IgnoreCase).Trim();
                }
                else if (string.IsNullOrEmpty(apartment))
                {
                    apartment = part;
                }
            }
        }

        public static string PositiveDecimal(string value, string fieldName, out decimal result)
        {
            result = 0;
            string normalized = (value ?? "").Replace(" ", "").Replace("\u00A0", "").Replace('.', ',');
            if (!decimal.TryParse(normalized, System.Globalization.NumberStyles.Number,
                    System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), out result))
                return $"Поле «{fieldName}» должно быть числом";
            if (result <= 0) return $"Поле «{fieldName}» должно быть больше нуля";
            return null;
        }
    }
}
