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
            lblStats = new Label();
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
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.BackColor = Color.White;
            picLogo.Location = new Point(377, 8);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(220, 65);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 14;
            picLogo.TabStop = false;
            // 
            // lblUserGreeting
            // 
            lblUserGreeting.Anchor = AnchorStyles.None;
            lblUserGreeting.BackColor = Color.White;
            lblUserGreeting.Font = new Font("Segoe UI", 10.5F);
            lblUserGreeting.ForeColor = Color.Black;
            lblUserGreeting.Location = new Point(240, 76);
            lblUserGreeting.Name = "lblUserGreeting";
            lblUserGreeting.Size = new Size(504, 22);
            lblUserGreeting.TabIndex = 1;
            lblUserGreeting.Text = "Пользователь (Администратор)";
            lblUserGreeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStats
            // 
            lblStats.Anchor = AnchorStyles.None;
            lblStats.BackColor = Color.White;
            lblStats.BorderStyle = BorderStyle.FixedSingle;
            lblStats.Font = new Font("Segoe UI", 9.5F);
            lblStats.ForeColor = Color.Black;
            lblStats.Location = new Point(232, 92);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(520, 36);
            lblStats.TabIndex = 2;
            lblStats.Text = "Свободно объектов: 0   |   Сделки в работе: 0   |   Просмотры: 0   |   Продажи: 0 ₽";
            lblStats.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProperties
            // 
            btnProperties.Anchor = AnchorStyles.None;
            btnProperties.BackColor = Color.White;
            btnProperties.CheckButton = false;
            btnProperties.Checked = false;
            btnProperties.Content = "Объекты недвижимости";
            btnProperties.Cursor = Cursors.Hand;
            btnProperties.Font = new Font("Segoe UI", 10.5F);
            btnProperties.ForeColor = Color.Black;
            btnProperties.HoverBackground = Color.White;
            btnProperties.HoverForeColor = Color.DimGray;
            btnProperties.HoverOutline = Color.Black;
            btnProperties.Location = new Point(232, 144);
            btnProperties.Name = "btnProperties";
            btnProperties.NormalBackground = Color.White;
            btnProperties.NormalForeColor = Color.Black;
            btnProperties.NormalOutline = Color.Black;
            btnProperties.OutlineThickness = 1F;
            btnProperties.Padding = new Padding(12);
            btnProperties.PressedBackground = Color.WhiteSmoke;
            btnProperties.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnProperties.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnProperties.Rounding = new Padding(20);
            btnProperties.Size = new Size(250, 45);
            btnProperties.TabIndex = 3;
            btnProperties.TextAlignment = StringAlignment.Center;
            btnProperties.Click += btnProperties_Click;
            // 
            // btnDeals
            // 
            btnDeals.Anchor = AnchorStyles.None;
            btnDeals.BackColor = Color.White;
            btnDeals.CheckButton = false;
            btnDeals.Checked = false;
            btnDeals.Content = "Сделки";
            btnDeals.Cursor = Cursors.Hand;
            btnDeals.Font = new Font("Segoe UI", 10.5F);
            btnDeals.ForeColor = Color.White;
            btnDeals.HoverBackground = Color.FromArgb(40, 40, 40);
            btnDeals.HoverForeColor = Color.White;
            btnDeals.HoverOutline = Color.Black;
            btnDeals.Location = new Point(502, 144);
            btnDeals.Name = "btnDeals";
            btnDeals.NormalBackground = Color.Black;
            btnDeals.NormalForeColor = Color.White;
            btnDeals.NormalOutline = Color.Black;
            btnDeals.OutlineThickness = 1F;
            btnDeals.Padding = new Padding(12);
            btnDeals.PressedBackground = Color.WhiteSmoke;
            btnDeals.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDeals.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDeals.Rounding = new Padding(20);
            btnDeals.Size = new Size(250, 45);
            btnDeals.TabIndex = 4;
            btnDeals.TextAlignment = StringAlignment.Center;
            btnDeals.Click += btnDeals_Click;
            // 
            // btnShowings
            // 
            btnShowings.Anchor = AnchorStyles.None;
            btnShowings.BackColor = Color.White;
            btnShowings.CheckButton = false;
            btnShowings.Checked = false;
            btnShowings.Content = "Заявки на просмотр";
            btnShowings.Cursor = Cursors.Hand;
            btnShowings.Font = new Font("Segoe UI", 10.5F);
            btnShowings.ForeColor = Color.Black;
            btnShowings.HoverBackground = Color.White;
            btnShowings.HoverForeColor = Color.DimGray;
            btnShowings.HoverOutline = Color.Black;
            btnShowings.Location = new Point(232, 198);
            btnShowings.Name = "btnShowings";
            btnShowings.NormalBackground = Color.White;
            btnShowings.NormalForeColor = Color.Black;
            btnShowings.NormalOutline = Color.Black;
            btnShowings.OutlineThickness = 1F;
            btnShowings.Padding = new Padding(12);
            btnShowings.PressedBackground = Color.WhiteSmoke;
            btnShowings.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnShowings.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowings.Rounding = new Padding(20);
            btnShowings.Size = new Size(250, 45);
            btnShowings.TabIndex = 5;
            btnShowings.TextAlignment = StringAlignment.Center;
            btnShowings.Click += btnShowings_Click;
            // 
            // btnProfile
            // 
            btnProfile.Anchor = AnchorStyles.None;
            btnProfile.BackColor = Color.White;
            btnProfile.CheckButton = false;
            btnProfile.Checked = false;
            btnProfile.Content = "Личный кабинет";
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Font = new Font("Segoe UI", 10.5F);
            btnProfile.ForeColor = Color.White;
            btnProfile.HoverBackground = Color.FromArgb(40, 40, 40);
            btnProfile.HoverForeColor = Color.White;
            btnProfile.HoverOutline = Color.Black;
            btnProfile.Location = new Point(502, 198);
            btnProfile.Name = "btnProfile";
            btnProfile.NormalBackground = Color.Black;
            btnProfile.NormalForeColor = Color.White;
            btnProfile.NormalOutline = Color.Black;
            btnProfile.OutlineThickness = 1F;
            btnProfile.Padding = new Padding(12);
            btnProfile.PressedBackground = Color.WhiteSmoke;
            btnProfile.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnProfile.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnProfile.Rounding = new Padding(20);
            btnProfile.Size = new Size(250, 45);
            btnProfile.TabIndex = 6;
            btnProfile.TextAlignment = StringAlignment.Center;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnUsers
            // 
            btnUsers.Anchor = AnchorStyles.None;
            btnUsers.BackColor = Color.White;
            btnUsers.CheckButton = false;
            btnUsers.Checked = false;
            btnUsers.Content = "Пользователи";
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.Font = new Font("Segoe UI", 10.5F);
            btnUsers.ForeColor = Color.Black;
            btnUsers.HoverBackground = Color.White;
            btnUsers.HoverForeColor = Color.DimGray;
            btnUsers.HoverOutline = Color.Black;
            btnUsers.Location = new Point(232, 252);
            btnUsers.Name = "btnUsers";
            btnUsers.NormalBackground = Color.White;
            btnUsers.NormalForeColor = Color.Black;
            btnUsers.NormalOutline = Color.Black;
            btnUsers.OutlineThickness = 1F;
            btnUsers.Padding = new Padding(12);
            btnUsers.PressedBackground = Color.WhiteSmoke;
            btnUsers.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnUsers.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnUsers.Rounding = new Padding(20);
            btnUsers.Size = new Size(250, 45);
            btnUsers.TabIndex = 7;
            btnUsers.TextAlignment = StringAlignment.Center;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnTypes
            // 
            btnTypes.Anchor = AnchorStyles.None;
            btnTypes.BackColor = Color.White;
            btnTypes.CheckButton = false;
            btnTypes.Checked = false;
            btnTypes.Content = "Типы недвижимости";
            btnTypes.Cursor = Cursors.Hand;
            btnTypes.Font = new Font("Segoe UI", 10.5F);
            btnTypes.ForeColor = Color.White;
            btnTypes.HoverBackground = Color.FromArgb(40, 40, 40);
            btnTypes.HoverForeColor = Color.White;
            btnTypes.HoverOutline = Color.Black;
            btnTypes.Location = new Point(502, 252);
            btnTypes.Name = "btnTypes";
            btnTypes.NormalBackground = Color.Black;
            btnTypes.NormalForeColor = Color.White;
            btnTypes.NormalOutline = Color.Black;
            btnTypes.OutlineThickness = 1F;
            btnTypes.Padding = new Padding(12);
            btnTypes.PressedBackground = Color.WhiteSmoke;
            btnTypes.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnTypes.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnTypes.Rounding = new Padding(20);
            btnTypes.Size = new Size(250, 45);
            btnTypes.TabIndex = 8;
            btnTypes.TextAlignment = StringAlignment.Center;
            btnTypes.Click += btnTypes_Click;
            // 
            // btnReports
            // 
            btnReports.Anchor = AnchorStyles.None;
            btnReports.BackColor = Color.White;
            btnReports.CheckButton = false;
            btnReports.Checked = false;
            btnReports.Content = "Отчёты";
            btnReports.Cursor = Cursors.Hand;
            btnReports.Font = new Font("Segoe UI", 10.5F);
            btnReports.ForeColor = Color.Black;
            btnReports.HoverBackground = Color.White;
            btnReports.HoverForeColor = Color.DimGray;
            btnReports.HoverOutline = Color.Black;
            btnReports.Location = new Point(232, 306);
            btnReports.Name = "btnReports";
            btnReports.NormalBackground = Color.White;
            btnReports.NormalForeColor = Color.Black;
            btnReports.NormalOutline = Color.Black;
            btnReports.OutlineThickness = 1F;
            btnReports.Padding = new Padding(12);
            btnReports.PressedBackground = Color.WhiteSmoke;
            btnReports.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnReports.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnReports.Rounding = new Padding(20);
            btnReports.Size = new Size(250, 45);
            btnReports.TabIndex = 9;
            btnReports.TextAlignment = StringAlignment.Center;
            btnReports.Click += btnReports_Click;
            // 
            // btnGuide
            // 
            btnGuide.Anchor = AnchorStyles.None;
            btnGuide.BackColor = Color.White;
            btnGuide.CheckButton = false;
            btnGuide.Checked = false;
            btnGuide.Content = "Руководство";
            btnGuide.Cursor = Cursors.Hand;
            btnGuide.Font = new Font("Segoe UI", 10.5F);
            btnGuide.ForeColor = Color.Black;
            btnGuide.HoverBackground = Color.White;
            btnGuide.HoverForeColor = Color.DimGray;
            btnGuide.HoverOutline = Color.Black;
            btnGuide.Location = new Point(502, 306);
            btnGuide.Name = "btnGuide";
            btnGuide.NormalBackground = Color.White;
            btnGuide.NormalForeColor = Color.Black;
            btnGuide.NormalOutline = Color.Black;
            btnGuide.OutlineThickness = 1F;
            btnGuide.Padding = new Padding(12);
            btnGuide.PressedBackground = Color.WhiteSmoke;
            btnGuide.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnGuide.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuide.Rounding = new Padding(20);
            btnGuide.Size = new Size(250, 45);
            btnGuide.TabIndex = 10;
            btnGuide.TextAlignment = StringAlignment.Center;
            btnGuide.Click += btnGuide_Click;
            // 
            // btnAbout
            // 
            btnAbout.Anchor = AnchorStyles.None;
            btnAbout.BackColor = Color.White;
            btnAbout.CheckButton = false;
            btnAbout.Checked = false;
            btnAbout.Content = "О программе";
            btnAbout.Cursor = Cursors.Hand;
            btnAbout.Font = new Font("Segoe UI", 10.5F);
            btnAbout.ForeColor = Color.Black;
            btnAbout.HoverBackground = Color.White;
            btnAbout.HoverForeColor = Color.DimGray;
            btnAbout.HoverOutline = Color.Black;
            btnAbout.Location = new Point(232, 360);
            btnAbout.Name = "btnAbout";
            btnAbout.NormalBackground = Color.White;
            btnAbout.NormalForeColor = Color.Black;
            btnAbout.NormalOutline = Color.Black;
            btnAbout.OutlineThickness = 1F;
            btnAbout.Padding = new Padding(12);
            btnAbout.PressedBackground = Color.WhiteSmoke;
            btnAbout.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnAbout.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnAbout.Rounding = new Padding(20);
            btnAbout.Size = new Size(165, 42);
            btnAbout.TabIndex = 11;
            btnAbout.TextAlignment = StringAlignment.Center;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.None;
            btnLogout.BackColor = Color.White;
            btnLogout.CheckButton = false;
            btnLogout.Checked = false;
            btnLogout.Content = "Сменить аккаунт";
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Segoe UI", 10.5F);
            btnLogout.ForeColor = Color.Black;
            btnLogout.HoverBackground = Color.White;
            btnLogout.HoverForeColor = Color.DimGray;
            btnLogout.HoverOutline = Color.Black;
            btnLogout.Location = new Point(409, 360);
            btnLogout.Name = "btnLogout";
            btnLogout.NormalBackground = Color.White;
            btnLogout.NormalForeColor = Color.Black;
            btnLogout.NormalOutline = Color.Black;
            btnLogout.OutlineThickness = 1F;
            btnLogout.Padding = new Padding(12);
            btnLogout.PressedBackground = Color.WhiteSmoke;
            btnLogout.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnLogout.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnLogout.Rounding = new Padding(20);
            btnLogout.Size = new Size(165, 42);
            btnLogout.TabIndex = 12;
            btnLogout.TextAlignment = StringAlignment.Center;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.White;
            btnExit.CheckButton = false;
            btnExit.Checked = false;
            btnExit.Content = "Выход";
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Segoe UI", 10.5F);
            btnExit.ForeColor = Color.White;
            btnExit.HoverBackground = Color.FromArgb(40, 40, 40);
            btnExit.HoverForeColor = Color.White;
            btnExit.HoverOutline = Color.Black;
            btnExit.Location = new Point(587, 360);
            btnExit.Name = "btnExit";
            btnExit.NormalBackground = Color.Black;
            btnExit.NormalForeColor = Color.White;
            btnExit.NormalOutline = Color.Black;
            btnExit.OutlineThickness = 1F;
            btnExit.Padding = new Padding(12);
            btnExit.PressedBackground = Color.WhiteSmoke;
            btnExit.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnExit.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnExit.Rounding = new Padding(20);
            btnExit.Size = new Size(165, 42);
            btnExit.TabIndex = 13;
            btnExit.TextAlignment = StringAlignment.Center;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnAbout);
            Controls.Add(btnGuide);
            Controls.Add(btnReports);
            Controls.Add(btnTypes);
            Controls.Add(btnUsers);
            Controls.Add(btnProfile);
            Controls.Add(btnShowings);
            Controls.Add(btnDeals);
            Controls.Add(btnProperties);
            Controls.Add(lblStats);
            Controls.Add(lblUserGreeting);
            Controls.Add(picLogo);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная — EstateFlow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblUserGreeting;
        private Label lblStats;
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
