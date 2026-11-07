using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace EstateFlow.Forms
{
    public class BaseForm : Form
    {
        private static FormWindowState sharedWindowState = FormWindowState.Normal;
        private static Point? sharedLocation;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        public BaseForm()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1000, 500);
            MinimumSize = new Size(1000, 500);
            MaximizeBox = true;
            MinimizeBox = true;
            BackColor = Color.White;
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            try
            {
                // отключаем стандартную анимацию появления/закрытия окна Windows для плавного перехода
                int disableTransitions = 1;
                DwmSetWindowAttribute(Handle, 3, ref disableTransitions, sizeof(int));
            }
            catch { }
        }

        protected override void OnLoad(EventArgs e)
        {
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

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (WindowState == FormWindowState.Normal)
                sharedLocation = Location;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // при полноэкранном режиме что бы не поплыл рисунок бг

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

        // рисовка заднего фона
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(Color.White);

            Point[] corner =
            {
                new Point(0, ClientSize.Height),
                new Point(0, ClientSize.Height - 140),
                new Point(140, ClientSize.Height)
            };
            using (var blackbrush = new SolidBrush(Color.Black))
            {
                g.FillPolygon(blackbrush, corner);
            }

            using (var thinPen = new Pen(Color.FromArgb(190, 190, 190), 1))
            {
                g.DrawLine(thinPen, 0, ClientSize.Height - 152, 152, ClientSize.Height);
                g.DrawLine(thinPen, ClientSize.Width - 142, 0, ClientSize.Width, 142);
            }

            using (var pen = new Pen(Color.Black, 2))
            {
                g.DrawLine(pen,
                    ClientSize.Width - 130, 0,
                    ClientSize.Width, 130);
            }
        }
    }
}
