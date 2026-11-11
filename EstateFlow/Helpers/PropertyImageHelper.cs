using System.Collections.Concurrent;
using System.Drawing.Drawing2D;

namespace EstateFlow.Helpers
{
    public static class PropertyImageHelper
    {
        private static readonly ConcurrentDictionary<string, Image> _cache = new(StringComparer.OrdinalIgnoreCase);
        private static Image _fallbackImage;

        public static string PropertiesDirectory
        {
            get
            {
                string baseDir = Path.Combine(AppContext.BaseDirectory, "Resources", "Properties");
                if (Directory.Exists(baseDir)) return baseDir;

                // Поиск относительно папки проекта (если запускается из IDE)
                string projectDir = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Resources", "Properties"));
                if (Directory.Exists(projectDir)) return projectDir;

                Directory.CreateDirectory(baseDir);
                return baseDir;
            }
        }

        public static Image GetImage(string photoName)
        {
            if (string.IsNullOrWhiteSpace(photoName))
                return GetFallbackImage();

            if (_cache.TryGetValue(photoName, out var cached))
                return cached;

            try
            {
                string resolvedPath = ResolvePhotoPath(photoName);
                if (File.Exists(resolvedPath))
                {
                    // Читаем в память, чтобы файл на диске не блокировался
                    byte[] bytes = File.ReadAllBytes(resolvedPath);
                    using var ms = new MemoryStream(bytes);
                    using var src = Image.FromStream(ms);
                    var bmp = new Bitmap(src);
                    _cache[photoName] = bmp;
                    return bmp;
                }
            }
            catch
            {
                // Игнорируем ошибки чтения и возвращаем заглушку
            }

            return GetFallbackImage();
        }

        public static string ResolvePhotoPath(string photoName)
        {
            if (string.IsNullOrWhiteSpace(photoName)) return null;

            // Если это уже полный путь на диске
            if (File.Exists(photoName)) return photoName;

            // В папке Resources/Properties в выходной директории
            string p1 = Path.Combine(AppContext.BaseDirectory, "Resources", "Properties", photoName);
            if (File.Exists(p1)) return p1;

            // В папке проекта
            string p2 = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Resources", "Properties", photoName));
            if (File.Exists(p2)) return p2;

            // В рабочей директории
            string p3 = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "Properties", photoName);
            if (File.Exists(p3)) return p3;

            return p1;
        }

        public static Image GetFallbackImage()
        {
            if (_fallbackImage != null) return _fallbackImage;

            string fallbackPath = ResolvePhotoPath("no_photo.png");
            if (File.Exists(fallbackPath))
            {
                try
                {
                    byte[] bytes = File.ReadAllBytes(fallbackPath);
                    using var ms = new MemoryStream(bytes);
                    using var src = Image.FromStream(ms);
                    _fallbackImage = new Bitmap(src);
                    return _fallbackImage;
                }
                catch { }
            }

            // Динамическая заглушка, если файла нет
            var bmp = new Bitmap(400, 260);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(240, 242, 246));
                using var p = new Pen(Color.FromArgb(200, 205, 215), 2);
                g.DrawRectangle(p, 10, 10, 380, 240);
                using var font = new Font("Segoe UI", 14F, FontStyle.Regular);
                using var brush = new SolidBrush(Color.FromArgb(140, 145, 155));
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString("Фото отсутствует", font, brush, new RectangleF(0, 0, 400, 260), sf);
            }
            _fallbackImage = bmp;
            return _fallbackImage;
        }

        public static List<string> GetAvailablePhotoPresets()
        {
            var list = new List<string>();
            try
            {
                string dir = PropertiesDirectory;
                if (Directory.Exists(dir))
                {
                    var files = Directory.GetFiles(dir, "prop_*.jpg")
                        .Select(Path.GetFileName)
                        .OrderBy(f =>
                        {
                            var m = System.Text.RegularExpressions.Regex.Match(f, @"\d+");
                            return m.Success ? int.Parse(m.Value) : 999;
                        });
                    list.AddRange(files);
                }
            }
            catch { }

            if (list.Count == 0)
            {
                for (int i = 1; i <= 20; i++)
                    list.Add($"prop_{i}.jpg");
            }

            return list;
        }
    }
}
