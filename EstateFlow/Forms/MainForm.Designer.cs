namespace EstateFlow.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            picLogo = new PictureBox();
            lblUserGreeting = new Label();
            lblUserRole = new Label();
            lblStats = new Label();
            lblSectionCore = new Label();
            lblSectionManage = new Label();
            lblKpiVal1 = new Label();
            lblKpiTitle1 = new Label();
            lblKpiVal2 = new Label();
            lblKpiTitle2 = new Label();
            lblKpiVal3 = new Label();
            lblKpiTitle3 = new Label();
            lblKpiVal4 = new Label();
            lblKpiTitle4 = new Label();
            btnProperties = new HartUI.Controls.cuiButton();
            btnDeals = new HartUI.Controls.cuiButton();
            btnShowings = new HartUI.Controls.cuiButton();
            btnProfile = new HartUI.Controls.cuiButton();
            btnUsers = new HartUI.Controls.cuiButton();
            btnTypes = new HartUI.Controls.cuiButton();
            btnReports = new HartUI.Controls.cuiButton();
            btnGuide = new HartUI.Controls.cuiButton();
            btnAbout = new HartUI.Controls.cuiButton();
            btnLogout = new HartUI.Controls.cuiButton();
            btnExit = new HartUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            //
            // picLogo
            //
            picLogo.BackColor = Color.Transparent;
            picLogo.Location = new Point(132, 22);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(185, 48);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 14;
            picLogo.TabStop = false;
            //
            // lblUserGreeting
            //
            lblUserGreeting.BackColor = Color.White;
            lblUserGreeting.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblUserGreeting.ForeColor = Color.Black;
            lblUserGreeting.Location = new Point(450, 22);
            lblUserGreeting.Name = "lblUserGreeting";
            lblUserGreeting.Size = new Size(402, 24);
            lblUserGreeting.TabIndex = 1;
            lblUserGreeting.Text = "Иванов Иван Иванович";
            lblUserGreeting.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblUserRole
            //
            lblUserRole.BackColor = Color.White;
            lblUserRole.Font = new Font("Segoe UI", 9F);
            lblUserRole.ForeColor = Color.DimGray;
            lblUserRole.Location = new Point(450, 46);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(402, 18);
            lblUserRole.TabIndex = 15;
            lblUserRole.Text = "Администратор";
            lblUserRole.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblStats (скрытый fallback для совместимости)
            //
            lblStats.Visible = false;
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(10, 10);
            lblStats.Location = new Point(0, 0);
            //
            // KPI labels
            //
            InitKpiLabels(lblKpiVal1, lblKpiTitle1, "0", "Свободно объектов");
            InitKpiLabels(lblKpiVal2, lblKpiTitle2, "0", "Сделки в работе");
            InitKpiLabels(lblKpiVal3, lblKpiTitle3, "0", "Активные просмотры");
            InitKpiLabels(lblKpiVal4, lblKpiTitle4, "0 ₽", "Продажи");
            //
            // Section headers
            //
            lblSectionCore.AutoSize = true;
            lblSectionCore.BackColor = Color.White;
            lblSectionCore.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSectionCore.ForeColor = Color.DimGray;
            lblSectionCore.Location = new Point(132, 152);
            lblSectionCore.Name = "lblSectionCore";
            lblSectionCore.Text = "ОСНОВНЫЕ РАЗДЕЛЫ";
            //
            lblSectionManage.AutoSize = true;
            lblSectionManage.BackColor = Color.White;
            lblSectionManage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSectionManage.ForeColor = Color.DimGray;
            lblSectionManage.Location = new Point(132, 238);
            lblSectionManage.Name = "lblSectionManage";
            lblSectionManage.Text = "УПРАВЛЕНИЕ И ПРОФИЛЬ";
            //
            // Buttons
            //
            ConfigureTileButton(btnProperties, "Объекты недвижимости", isPrimary: true, tabIndex: 3);
            btnProperties.Click += btnProperties_Click;

            ConfigureTileButton(btnDeals, "Сделки", isPrimary: false, tabIndex: 4);
            btnDeals.Click += btnDeals_Click;

            ConfigureTileButton(btnShowings, "Заявки на просмотр", isPrimary: false, tabIndex: 5);
            btnShowings.Click += btnShowings_Click;

            ConfigureTileButton(btnUsers, "Пользователи", isPrimary: false, tabIndex: 6);
            btnUsers.Click += btnUsers_Click;

            ConfigureTileButton(btnTypes, "Типы недвижимости", isPrimary: false, tabIndex: 7);
            btnTypes.Click += btnTypes_Click;

            ConfigureTileButton(btnReports, "Отчёты", isPrimary: false, tabIndex: 8);
            btnReports.Click += btnReports_Click;

            ConfigureTileButton(btnProfile, "Личный кабинет", isPrimary: false, tabIndex: 9);
            btnProfile.Click += btnProfile_Click;

            ConfigureFooterButton(btnGuide, "Руководство (F1)", tabIndex: 10);
            btnGuide.Click += btnGuide_Click;

            ConfigureFooterButton(btnAbout, "О программе", tabIndex: 11);
            btnAbout.Click += btnAbout_Click;

            ConfigureFooterButton(btnLogout, "Сменить аккаунт", tabIndex: 12);
            btnLogout.Click += btnLogout_Click;

            ConfigureFooterButton(btnExit, "Выход", tabIndex: 13);
            btnExit.Click += btnExit_Click;
            //
            // MainForm
            //
            ClientSize = new Size(984, 461);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnAbout);
            Controls.Add(btnGuide);
            Controls.Add(btnProfile);
            Controls.Add(btnReports);
            Controls.Add(btnTypes);
            Controls.Add(btnUsers);
            Controls.Add(btnShowings);
            Controls.Add(btnDeals);
            Controls.Add(btnProperties);
            Controls.Add(lblSectionManage);
            Controls.Add(lblSectionCore);
            Controls.Add(lblKpiTitle4);
            Controls.Add(lblKpiVal4);
            Controls.Add(lblKpiTitle3);
            Controls.Add(lblKpiVal3);
            Controls.Add(lblKpiTitle2);
            Controls.Add(lblKpiVal2);
            Controls.Add(lblKpiTitle1);
            Controls.Add(lblKpiVal1);
            Controls.Add(lblStats);
            Controls.Add(lblUserRole);
            Controls.Add(lblUserGreeting);
            Controls.Add(picLogo);
            KeyPreview = true;
            Name = "MainForm";
            Text = "Главная — EstateFlow";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private static void InitKpiLabels(Label valLbl, Label titleLbl, string valText, string titleText)
        {
            valLbl.BackColor = Color.White;
            valLbl.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            valLbl.ForeColor = Color.Black;
            valLbl.Text = valText;
            valLbl.TextAlign = ContentAlignment.MiddleLeft;
            valLbl.AutoEllipsis = true;

            titleLbl.BackColor = Color.White;
            titleLbl.Font = new Font("Segoe UI", 8.5F);
            titleLbl.ForeColor = Color.DimGray;
            titleLbl.Text = titleText;
            titleLbl.TextAlign = ContentAlignment.MiddleLeft;
            titleLbl.AutoEllipsis = true;
        }

        private static void ConfigureTileButton(HartUI.Controls.cuiButton btn, string text, bool isPrimary, int tabIndex)
        {
            btn.BackColor = Color.White;
            btn.CheckButton = false;
            btn.Checked = false;
            btn.Content = text;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI Semibold", 10F, isPrimary ? FontStyle.Bold : FontStyle.Regular);
            btn.ForeColor = isPrimary ? Color.White : Color.Black;
            btn.NormalBackground = isPrimary ? Color.Black : Color.White;
            btn.NormalForeColor = isPrimary ? Color.White : Color.Black;
            btn.NormalOutline = Color.Black;
            btn.HoverBackground = isPrimary ? Color.FromArgb(40, 40, 40) : Color.FromArgb(245, 245, 248);
            btn.HoverForeColor = isPrimary ? Color.White : Color.Black;
            btn.HoverOutline = Color.Black;
            btn.PressedBackground = isPrimary ? Color.FromArgb(65, 65, 65) : Color.FromArgb(232, 234, 238);
            btn.PressedForeColor = isPrimary ? Color.White : Color.Black;
            btn.PressedOutline = Color.Black;
            btn.OutlineThickness = 1F;
            btn.Padding = new Padding(8);
            btn.Rounding = new Padding(14);
            btn.Size = new Size(230, 52);
            btn.TabIndex = tabIndex;
            btn.TextAlignment = StringAlignment.Center;
            btn.TextPadding = 6;
            btn.TextSpacing = 2;
        }

        private static void ConfigureFooterButton(HartUI.Controls.cuiButton btn, string text, int tabIndex)
        {
            btn.BackColor = Color.White;
            btn.CheckButton = false;
            btn.Checked = false;
            btn.Content = text;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9.5F);
            btn.ForeColor = Color.Black;
            btn.NormalBackground = Color.White;
            btn.NormalForeColor = Color.Black;
            btn.NormalOutline = Color.FromArgb(180, 180, 180);
            btn.HoverBackground = Color.FromArgb(245, 245, 248);
            btn.HoverForeColor = Color.Black;
            btn.HoverOutline = Color.Black;
            btn.PressedBackground = Color.FromArgb(232, 234, 238);
            btn.PressedForeColor = Color.Black;
            btn.PressedOutline = Color.Black;
            btn.OutlineThickness = 1F;
            btn.Padding = new Padding(6);
            btn.Rounding = new Padding(12);
            btn.Size = new Size(165, 38);
            btn.TabIndex = tabIndex;
            btn.TextAlignment = StringAlignment.Center;
            btn.TextPadding = 4;
            btn.TextSpacing = 2;
        }

        #endregion

        private PictureBox picLogo;
        private Label lblUserGreeting;
        private Label lblUserRole;
        private Label lblStats;
        private Label lblSectionCore;
        private Label lblSectionManage;
        private Label lblKpiVal1;
        private Label lblKpiTitle1;
        private Label lblKpiVal2;
        private Label lblKpiTitle2;
        private Label lblKpiVal3;
        private Label lblKpiTitle3;
        private Label lblKpiVal4;
        private Label lblKpiTitle4;
        private HartUI.Controls.cuiButton btnProperties;
        private HartUI.Controls.cuiButton btnDeals;
        private HartUI.Controls.cuiButton btnShowings;
        private HartUI.Controls.cuiButton btnProfile;
        private HartUI.Controls.cuiButton btnUsers;
        private HartUI.Controls.cuiButton btnTypes;
        private HartUI.Controls.cuiButton btnReports;
        private HartUI.Controls.cuiButton btnGuide;
        private HartUI.Controls.cuiButton btnAbout;
        private HartUI.Controls.cuiButton btnLogout;
        private HartUI.Controls.cuiButton btnExit;
    }
}
