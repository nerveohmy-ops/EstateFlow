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

        public static string PositiveDecimal(string value, string fieldName, out decimal result)
        {
            result = 0;
            string normalized = (value ?? "").Replace(" ", "").Replace('.', ',');
            if (!decimal.TryParse(normalized, System.Globalization.NumberStyles.Number,
                    System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), out result))
                return $"Поле «{fieldName}» должно быть числом";
            if (result <= 0) return $"Поле «{fieldName}» должно быть больше нуля";
            return null;
        }
    }
}
