using System.Drawing.Drawing2D;

namespace EstateFlow.Forms
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1000, 500);
            MinimumSize = new Size(1000, 500);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = true;
            MinimizeBox = true;
            BackColor = Color.White;
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            Resize += (s, e) => Invalidate(); // при полноэкранном режиме что бы не поплыл рисунок бг
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
                new Point(0, ClientSize.Height - 165),
                new Point(165, ClientSize.Height)
            };
            using (var blackbrush = new SolidBrush(Color.Black))
            {
                g.FillPolygon(blackbrush, corner);
            }

            using (var pen = new Pen(Color.Black, 2))
            {
                g.DrawLine(pen,
                    ClientSize.Width - 165, 0,
                    ClientSize.Width, 165);
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_SIZE = 0xF000;

            if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xFFF0) == SC_SIZE)
                return;

            base.WndProc(ref m);
        }
    }
}
