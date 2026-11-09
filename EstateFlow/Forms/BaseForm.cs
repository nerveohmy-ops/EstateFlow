using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using HartUI.Controls;

namespace EstateFlow.Forms
{
    public class BaseForm : Form
    {
        private static FormWindowState sharedWindowState = FormWindowState.Normal;
        private static Point? sharedLocation;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private cuiButton btnThemeToggle;

        protected virtual bool ShowThemeToggle => true;

        public BaseForm()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1000, 500);
            MinimumSize = new Size(1000, 500);
            MaximizeBox = true;
            MinimizeBox = true;
            BackColor = Helpers.UiTheme.Background;
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void InitializeThemeToggle()
        {
            if (!ShowThemeToggle) return;

            btnThemeToggle = new cuiButton
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                CheckButton = false,
                Checked = false,
                Content = Helpers.UiTheme.IsDark ? "Светлая тема" : "Тёмная тема",
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Helpers.UiTheme.TextMain,
                HoverBackground = Helpers.UiTheme.IsDark ? Color.FromArgb(45, 47, 54) : Color.FromArgb(240, 240, 240),
                HoverForeColor = Helpers.UiTheme.TextMain,
                HoverOutline = Helpers.UiTheme.TextMain,
                Location = new Point(14, 12),
                Name = "btnThemeToggle",
                NormalBackground = Helpers.UiTheme.IsDark ? Color.FromArgb(32, 33, 37) : Color.White,
                NormalForeColor = Helpers.UiTheme.TextMain,
                NormalOutline = Helpers.UiTheme.Border,
                OutlineThickness = 1F,
                Padding = new Padding(6),
                PressedBackground = Helpers.UiTheme.IsDark ? Color.FromArgb(55, 57, 65) : Color.WhiteSmoke,
                PressedForeColor = Helpers.UiTheme.TextMain,
                PressedOutline = Helpers.UiTheme.Border,
                Rounding = new Padding(14),
                Size = new Size(114, 30),
                TabIndex = 999,
                TextAlignment = StringAlignment.Center
            };

            btnThemeToggle.Click += (s, e) =>
            {
                Helpers.UiTheme.ToggleTheme();
            };

            Controls.Add(btnThemeToggle);
            btnThemeToggle.BringToFront();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            try
            {
                // отключаем стандартную анимацию окон Windows для бесшовного перехода
                int disableTransitions = 1;
                DwmSetWindowAttribute(Handle, 3, ref disableTransitions, sizeof(int));
            }
            catch { }
        }

        protected override void OnLoad(EventArgs e)
        {
            InitializeThemeToggle();
            Helpers.UiTheme.ThemeChanged += OnThemeChanged;
            Helpers.UiTheme.ApplyTheme(this);
            UpdateThemeButtonState();

            if (sharedLocation.HasValue && sharedWindowState == FormWindowState.Normal)
            {
                StartPosition = FormStartPosition.Manual;
                Location = sharedLocation.Value;
            }
            if (WindowState != sharedWindowState)
            {
                WindowState = sharedWindowState;
            }
            base.OnLoad(e);
        }

        private void OnThemeChanged()
        {
            if (IsDisposed) return;
            Helpers.UiTheme.ApplyTheme(this);
            UpdateThemeButtonState();
            Invalidate(true);
        }

        private void UpdateThemeButtonState()
        {
            if (btnThemeToggle == null || btnThemeToggle.IsDisposed) return;
            btnThemeToggle.Content = Helpers.UiTheme.IsDark ? "Светлая тема" : "Тёмная тема";
            btnThemeToggle.NormalBackground = Helpers.UiTheme.IsDark ? Color.FromArgb(35, 37, 42) : Color.White;
            btnThemeToggle.NormalForeColor = Helpers.UiTheme.TextMain;
            btnThemeToggle.NormalOutline = Helpers.UiTheme.Border;
            btnThemeToggle.HoverBackground = Helpers.UiTheme.IsDark ? Color.FromArgb(50, 52, 60) : Color.FromArgb(240, 240, 240);
            btnThemeToggle.HoverForeColor = Helpers.UiTheme.TextMain;
            btnThemeToggle.HoverOutline = Helpers.UiTheme.TextMain;
            btnThemeToggle.BringToFront();
            btnThemeToggle.Invalidate();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (WindowState == FormWindowState.Normal)
                sharedLocation = Location;
            btnThemeToggle?.BringToFront();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            btnThemeToggle?.BringToFront();
            Invalidate();

            if (IsHandleCreated && Visible && WindowState != FormWindowState.Minimized)
            {
                sharedWindowState = WindowState;
                if (WindowState == FormWindowState.Normal)
                    sharedLocation = Location;
                SyncOwners();
            }
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            if (IsHandleCreated && Visible && WindowState == FormWindowState.Normal)
            {
                sharedLocation = Location;
                SyncOwners();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Helpers.UiTheme.ThemeChanged -= OnThemeChanged;
            SyncOwners();
            if (Owner is BaseForm ownerForm)
                ownerForm.Refresh();
            base.OnFormClosing(e);
        }

        private void SyncOwners()
        {
            Form current = Owner;
            while (current is BaseForm ownerBase)
            {
                if (ownerBase.WindowState != sharedWindowState)
                    ownerBase.WindowState = sharedWindowState;
                if (sharedWindowState == FormWindowState.Normal && sharedLocation.HasValue)
                    ownerBase.Location = sharedLocation.Value;
                current = ownerBase.Owner;
            }
        }

        // рисовка заднего фона с поддержкой светлой и тёмной темы
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color bgColor = Helpers.UiTheme.Background;
            g.Clear(bgColor);

            Color cornerFill = Helpers.UiTheme.IsDark ? Color.FromArgb(16, 17, 20) : Color.Black;
            Color thinLineColor = Helpers.UiTheme.IsDark ? Color.FromArgb(55, 58, 65) : Color.FromArgb(190, 190, 190);
            Color thickLineColor = Helpers.UiTheme.IsDark ? Color.FromArgb(75, 78, 88) : Color.Black;

            Point[] corner =
            {
                new Point(0, ClientSize.Height),
                new Point(0, ClientSize.Height - 140),
                new Point(140, ClientSize.Height)
            };
            using (var brush = new SolidBrush(cornerFill))
            {
                g.FillPolygon(brush, corner);
            }

            using (var thinPen = new Pen(thinLineColor, 1))
            {
                g.DrawLine(thinPen, 0, ClientSize.Height - 152, 152, ClientSize.Height);
                g.DrawLine(thinPen, ClientSize.Width - 142, 0, ClientSize.Width, 142);
            }

            using (var pen = new Pen(thickLineColor, 2))
            {
                g.DrawLine(pen,
                    ClientSize.Width - 130, 0,
                    ClientSize.Width, 130);
            }
        }
    }
}
