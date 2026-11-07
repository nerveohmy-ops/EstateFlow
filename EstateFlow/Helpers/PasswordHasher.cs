using System.Security.Cryptography;
using System.Text;

namespace EstateFlow.Helpers
{
    public static class PasswordHasher
    {
        private const string Prefix = "SHA256$";

        public static string Hash(string password)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password ?? ""));
            return Prefix + Convert.ToHexString(bytes);
        }

        public static bool Verify(string password, string storedHash)
        {
            if (string.IsNullOrEmpty(storedHash) || password == null)
                return false;

            if (storedHash.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase))
            {
                return string.Equals(Hash(password), storedHash, StringComparison.OrdinalIgnoreCase);
            }

            return string.Equals(password, storedHash, StringComparison.Ordinal);
        }

        public static bool IsHashed(string value) =>
            value != null && value.StartsWith(Prefix) && value.Length == Prefix.Length + 64;

        public static string Generate()
        {
            const string upper = "ABCDEFGHJKLMNPQRSTUVWXYZ";
            const string lower = "abcdefghijkmnpqrstuvwxyz";
            const string digits = "23456789";
            const string symbols = "!@#$%&*?";
            string all = upper + lower + digits + symbols;

            var chars = new List<char>
            {
                upper[RandomNumberGenerator.GetInt32(upper.Length)],
                lower[RandomNumberGenerator.GetInt32(lower.Length)],
                digits[RandomNumberGenerator.GetInt32(digits.Length)],
                symbols[RandomNumberGenerator.GetInt32(symbols.Length)]
            };
            while (chars.Count < 14)
                chars.Add(all[RandomNumberGenerator.GetInt32(all.Length)]);

            return new string(chars.OrderBy(_ => RandomNumberGenerator.GetInt32(1000)).ToArray());
        }
    }
}
