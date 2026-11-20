using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace EstateFlow.Helpers
{
    internal static class FormIconHelper
    {
        private static Icon? _cachedIcon;
        private static bool _loaded;
        public static void ApplyToAllOpenForms()
        {
            Icon? icon = GetIcon();
            if (icon == null) return;

            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (!form.IsDisposed && form.Icon != icon)
                {
                    form.Icon = icon;
                }
            }
        }

        private static Icon? GetIcon()
        {
            if (_loaded) return _cachedIcon;
            _loaded = true;

            string[] candidates =
            {
                Path.Combine(AppContext.BaseDirectory, "logo.ico"),
                Path.Combine(AppContext.BaseDirectory, "logo.png")
            };
            
            string? foundPath = candidates.FirstOrDefault(File.Exists);
            if (foundPath == null) return null;

            try
            {
                _cachedIcon = new Icon(foundPath);
            }
            catch (ArgumentException)
            {
                using var bmp = new Bitmap(foundPath);
                using var resized = new Bitmap(bmp, new Size(64, 64));
                using var ms = new MemoryStream();
                resized.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                var converter = new ImageConverter();
                byte[]? pngBytes = converter.ConvertTo(resized, typeof(byte[])) as byte[];
                if (pngBytes != null)
                {
                    using var img = Image.FromStream(new MemoryStream(pngBytes));
                    _cachedIcon = Icon.FromHandle(((Bitmap)img).GetHicon());
                }
            }
            return _cachedIcon;
        }
    }
}
