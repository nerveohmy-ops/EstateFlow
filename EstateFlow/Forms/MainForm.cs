using System.Drawing.Drawing2D;
using EstateFlow.Helpers;
using EstateFlow.Services;
using HartUI.Controls;

namespace EstateFlow.Forms
{
    public partial class MainForm : BaseForm
    {
        public bool LogoutRequested { get; private set; }

        private readonly Rectangle[] kpiRects = new Rectangle[4];
        private int dividerY = -1;
        private int dividerLeft = 0;
        private int dividerRight = 0;

        public MainForm()
        {
            InitializeComponent();
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F1) btnGuide_Click(s, e);
            };

            if (Session.CurrentUser != null)
            {
                ConfigureByRole();
                LoadDashboard();
            }

            LayoutControls();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyLocalTheme();
            LayoutControls();
        }

        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();
            ApplyLocalTheme();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            LayoutControls();
        }

        private void ConfigureByRole()
        {
            lblUserGreeting.Text = Session.CurrentUser.FullName;
            lblUserRole.Text = Session.CurrentUser.RoleName;

            if (Session.CurrentUser.IsClient)
            {
                btnDeals.Content = "Мои сделки";
                btnShowings.Content = "Мои просмотры";
                btnUsers.Visible = false;
                btnTypes.Visible = false;
                btnReports.Visible = false;
                lblKpiTitle2.Text = "Мои сделки";
                lblKpiTitle4.Text = "Мои покупки";
            }
            else if (Session.CurrentUser.IsAgent)
            {
                btnUsers.Visible = false;
                btnTypes.Visible = false;
                lblKpiTitle2.Text = "Сделки в работе";
                lblKpiTitle4.Text = "Продажи";
            }
            else
            {
                lblKpiTitle2.Text = "Сделки в работе";
                lblKpiTitle4.Text = "Продажи";
            }

            LayoutControls();
        }

        private void LayoutControls()
        {
            if (picLogo == null || ClientSize.Width <= 0 || ClientSize.Height <= 0)
                return;

            SuspendLayout();

            bool isExpanded = ClientSize.Width >= 1200 && ClientSize.Height >= 650;
            int horizontalMargin = isExpanded ? 220 : 128;
            int contentW = Math.Clamp(ClientSize.Width - horizontalMargin * 2, 720, 1200);
            if (contentW > ClientSize.Width - 48)
                contentW = Math.Max(640, ClientSize.Width - 48);

            int left = (ClientSize.Width - contentW) / 2;

            int headerH = isExpanded ? 74 : 58;
            int kpiH = isExpanded ? 96 : 66;
            int coreBtnH = isExpanded ? 74 : 54;
            int secBtnH = isExpanded ? 62 : 48;
            int footerBtnH = isExpanded ? 48 : 38;
            int gap = isExpanded ? 18 : 12;
            int sectionHeaderH = 20;

            int totalH = headerH + (isExpanded ? 22 : 12)
                       + kpiH + (isExpanded ? 28 : 16)
                       + sectionHeaderH + 8 + coreBtnH + (isExpanded ? 24 : 14)
                       + sectionHeaderH + 8 + secBtnH + (isExpanded ? 26 : 16)
                       + 14 + footerBtnH;

            int top = Math.Max(12, (ClientSize.Height - totalH) / 2);

            // 1. Header: Logo flush-left + User name & role right
            int logoW = isExpanded ? 96 : 74;
            picLogo.SetBounds(left, top, logoW, headerH);

            int greetW = Math.Max(220, contentW - logoW - 20);
            int greetX = left + contentW - greetW;
            lblUserGreeting.Font = new Font("Segoe UI Semibold", isExpanded ? 13.5F : 11F, FontStyle.Bold);
            lblUserRole.Font = new Font("Segoe UI", isExpanded ? 10.5F : 9F);
            lblUserGreeting.SetBounds(greetX, top + (headerH - 46) / 2, greetW, 24);
            lblUserRole.SetBounds(greetX, lblUserGreeting.Bottom + 2, greetW, 20);

            int y = top + headerH + (isExpanded ? 22 : 12);

            // 2. KPI Strip (4 equal cards)
            int kpiW = (contentW - gap * 3) / 4;
            Label[] valLabels = { lblKpiVal1, lblKpiVal2, lblKpiVal3, lblKpiVal4 };
            Label[] titleLabels = { lblKpiTitle1, lblKpiTitle2, lblKpiTitle3, lblKpiTitle4 };

            for (int i = 0; i < 4; i++)
            {
                int cx = left + i * (kpiW + gap);
                kpiRects[i] = new Rectangle(cx, y, kpiW, kpiH);

                valLabels[i].Font = new Font("Segoe UI", isExpanded ? 17F : 14F, FontStyle.Bold);
                titleLabels[i].Font = new Font("Segoe UI", isExpanded ? 9.5F : 8.5F);

                int padX = isExpanded ? 16 : 12;
                int valTop = y + (isExpanded ? 14 : 9);
                valLabels[i].SetBounds(cx + padX, valTop, kpiW - padX * 2, isExpanded ? 34 : 28);
                titleLabels[i].SetBounds(cx + padX, valLabels[i].Bottom + 2, kpiW - padX * 2, 20);
            }

            y += kpiH + (isExpanded ? 28 : 16);

            // 3. Section 1: Core Actions (3 equal tiles)
            lblSectionCore.Location = new Point(left, y);
            y += sectionHeaderH + 8;

            int coreColW = (contentW - gap * 2) / 3;
            cuiButton[] coreBtns = { btnProperties, btnDeals, btnShowings };
            for (int i = 0; i < coreBtns.Length; i++)
            {
                int bx = left + i * (coreColW + gap);
                int bw = (i == coreBtns.Length - 1) ? (left + contentW - bx) : coreColW;
                coreBtns[i].SetBounds(bx, y, bw, coreBtnH);
                coreBtns[i].Font = new Font("Segoe UI Semibold", isExpanded ? 11.5F : 10F, i == 0 ? FontStyle.Bold : FontStyle.Regular);
            }

            y += coreBtnH + (isExpanded ? 24 : 14);

            // 4. Section 2: Role-specific management / profile tiles
            lblSectionManage.Location = new Point(left, y);
            y += sectionHeaderH + 8;

            var row2Btns = new List<cuiButton>();
            if (Session.CurrentUser != null && Session.CurrentUser.IsClient)
            {
                lblSectionManage.Text = "ПРОФИЛЬ И СПРАВКА";
                row2Btns.Add(btnProfile);
                row2Btns.Add(btnGuide);
            }
            else if (Session.CurrentUser != null && Session.CurrentUser.IsAgent)
            {
                lblSectionManage.Text = "АНАЛИТИКА И ПРОФИЛЬ";
                row2Btns.Add(btnReports);
                row2Btns.Add(btnProfile);
            }
            else
            {
                lblSectionManage.Text = "УПРАВЛЕНИЕ И ПРОФИЛЬ";
                row2Btns.Add(btnUsers);
                row2Btns.Add(btnTypes);
                row2Btns.Add(btnReports);
                row2Btns.Add(btnProfile);
            }

            int r2Cols = row2Btns.Count;
            int r2W = (contentW - gap * (r2Cols - 1)) / r2Cols;
            for (int i = 0; i < r2Cols; i++)
            {
                int bx = left + i * (r2W + gap);
                int bw = (i == r2Cols - 1) ? (left + contentW - bx) : r2W;
                row2Btns[i].SetBounds(bx, y, bw, secBtnH);
                row2Btns[i].Font = new Font("Segoe UI", isExpanded ? 10.5F : 9.8F);
            }

            y += secBtnH + (isExpanded ? 26 : 16);

            // 5. Footer divider + System / Service Bar
            dividerY = y;
            dividerLeft = left;
            dividerRight = left + contentW;
            y += 14;

            var footerBtns = new List<cuiButton>();
            if (Session.CurrentUser == null || !Session.CurrentUser.IsClient)
                footerBtns.Add(btnGuide);
            footerBtns.Add(btnAbout);
            footerBtns.Add(btnLogout);
            footerBtns.Add(btnExit);

            int fCols = footerBtns.Count;
            int fW = (contentW - gap * (fCols - 1)) / fCols;
            for (int i = 0; i < fCols; i++)
            {
                int bx = left + i * (fW + gap);
                int bw = (i == fCols - 1) ? (left + contentW - bx) : fW;
                footerBtns[i].SetBounds(bx, y, bw, footerBtnH);
                footerBtns[i].Font = new Font("Segoe UI", isExpanded ? 10F : 9.2F);
            }

            ResumeLayout(true);
            Invalidate();
        }

        private void ApplyLocalTheme()
        {
            Color cardBg = UiTheme.CardBg;
            foreach (var lbl in new[] { lblKpiVal1, lblKpiVal2, lblKpiVal3, lblKpiVal4 })
            {
                lbl.BackColor = cardBg;
                lbl.ForeColor = UiTheme.TextMain;
            }
            foreach (var lbl in new[] { lblKpiTitle1, lblKpiTitle2, lblKpiTitle3, lblKpiTitle4 })
            {
                lbl.BackColor = cardBg;
                lbl.ForeColor = UiTheme.TextMuted;
            }

            lblUserGreeting.ForeColor = UiTheme.TextMain;
            lblUserRole.ForeColor = UiTheme.TextMuted;
            lblSectionCore.ForeColor = UiTheme.TextMuted;
            lblSectionManage.ForeColor = UiTheme.TextMuted;

            // Деликатный акцент на кнопке выхода, чтобы она отличалась от навигационных плиток
            if (UiTheme.IsDark)
            {
                btnExit.NormalOutline = Color.FromArgb(145, 72, 78);
                btnExit.NormalForeColor = Color.FromArgb(255, 165, 165);
                btnExit.HoverBackground = Color.FromArgb(72, 32, 38);
                btnExit.HoverForeColor = Color.White;
                btnExit.HoverOutline = Color.FromArgb(220, 95, 100);
            }
            else
            {
                btnExit.NormalOutline = Color.FromArgb(215, 165, 170);
                btnExit.NormalForeColor = Color.FromArgb(175, 35, 45);
                btnExit.HoverBackground = Color.FromArgb(254, 242, 242);
                btnExit.HoverForeColor = Color.FromArgb(155, 25, 35);
                btnExit.HoverOutline = Color.FromArgb(200, 60, 70);
            }
            btnExit.ForeColor = btnExit.NormalForeColor;
            btnExit.Invalidate();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color cardBg = UiTheme.CardBg;
            Color cardBorder = UiTheme.Border;

            using (var bgBrush = new SolidBrush(cardBg))
            using (var borderPen = new Pen(cardBorder, 1F))
            {
                foreach (var rect in kpiRects)
                {
                    if (rect.Width <= 0 || rect.Height <= 0) continue;
                    using var path = CreateRoundedRect(rect, 12);
                    g.FillPath(bgBrush, path);
                    g.DrawPath(borderPen, path);
                }
            }

            if (dividerY > 0 && dividerRight > dividerLeft)
            {
                using var divPen = new Pen(cardBorder, 1F);
                g.DrawLine(divPen, dividerLeft, dividerY, dividerRight, dividerY);
            }
        }

        private static GraphicsPath CreateRoundedRect(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        public void LoadDashboard()
        {
            if (Session.CurrentUser == null) return;
            UiTheme.Try(() =>
            {
                var (free, inWork, showings, sum) = ReportService.GetDashboard(Session.CurrentUser);
                string dealLabel = Session.CurrentUser.IsClient ? "Мои сделки" : "Сделки в работе";
                string sumLabel = Session.CurrentUser.IsClient ? "Мои покупки" : "Продажи";

                lblKpiVal1.Text = free.ToString();
                lblKpiVal2.Text = inWork.ToString();
                lblKpiTitle2.Text = dealLabel;
                lblKpiVal3.Text = showings.ToString();
                lblKpiVal4.Text = $"{sum:N0} ₽".Replace('\u00A0', ' ');
                lblKpiTitle4.Text = sumLabel;

                lblStats.Text = $"Свободно объектов: {free}  |  {dealLabel}: {inWork}  |  Просмотры: {showings}  |  {sumLabel}: {sum:N0} ₽".Replace('\u00A0', ' ');
            });
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            using var f = new PropertiesForm();
            f.ShowDialog(this);
            LoadDashboard();
        }

        private void btnDeals_Click(object sender, EventArgs e)
        {
            using var f = new DealsForm();
            f.ShowDialog(this);
            LoadDashboard();
        }

        private void btnShowings_Click(object sender, EventArgs e)
        {
            using var f = new ShowingsForm();
            f.ShowDialog(this);
            LoadDashboard();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            using var f = new UsersForm();
            f.ShowDialog(this);
            LoadDashboard();
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            using var f = new PropertyTypesForm();
            f.ShowDialog(this);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            using var f = new ReportsForm();
            f.ShowDialog(this);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            using var f = new ProfileForm();
            f.ShowDialog(this);
            lblUserGreeting.Text = Session.CurrentUser.FullName;
            lblUserRole.Text = Session.CurrentUser.RoleName;
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            using var f = new HelpForm();
            f.ShowDialog(this);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using var f = new AboutForm();
            f.ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (UiTheme.Confirm("Выйти из учётной записи?"))
            {
                LogoutRequested = true;
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (UiTheme.Confirm("Завершить работу с программой?"))
            {
                LogoutRequested = false;
                Close();
            }
        }
    }
}
