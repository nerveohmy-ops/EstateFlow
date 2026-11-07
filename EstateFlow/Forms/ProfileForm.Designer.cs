namespace EstateFlow.Forms
{
    partial class ProfileForm
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
            lblTitle = new Label();
            txtFullName = new HartUI.Controls.cuiTextBox();
            txtLogin = new HartUI.Controls.cuiTextBox();
            txtEmail = new HartUI.Controls.cuiTextBox();
            txtPhone = new HartUI.Controls.cuiTextBox();
            txtSecret = new HartUI.Controls.cuiTextBox();
            btnSaveProfile = new HartUI.Controls.cuiButton();
            lblPassHeader = new Label();
            txtOldPassword = new HartUI.Controls.cuiTextBox();
            txtNewPassword = new HartUI.Controls.cuiTextBox();
            txtRepeatPassword = new HartUI.Controls.cuiTextBox();
            btnChangePassword = new HartUI.Controls.cuiButton();
            btnClose = new HartUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F);
            lblTitle.Location = new Point(216, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(198, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Личный кабинет";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.None;
            txtFullName.BackColor = Color.White;
            txtFullName.BackgroundColor = Color.White;
            txtFullName.Content = "";
            txtFullName.FocusBackgroundColor = Color.White;
            txtFullName.FocusImageTint = Color.White;
            txtFullName.FocusOutlineColor = Color.Black;
            txtFullName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.Black;
            txtFullName.Location = new Point(216, 62);
            txtFullName.Name = "txtFullName";
            txtFullName.NormalImageTint = Color.White;
            txtFullName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtFullName.Padding = new Padding(16, 14, 16, 0);
            txtFullName.PasswordChar = false;
            txtFullName.PlaceholderColor = Color.LightGray;
            txtFullName.PlaceholderText = "ФИО";
            txtFullName.Rounding = new Padding(20);
            txtFullName.Size = new Size(266, 45);
            txtFullName.TabIndex = 1;
            txtFullName.UnderlinedStyle = true;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.BackColor = Color.White;
            txtLogin.BackgroundColor = Color.White;
            txtLogin.Content = "";
            txtLogin.Enabled = false;
            txtLogin.FocusBackgroundColor = Color.White;
            txtLogin.FocusImageTint = Color.White;
            txtLogin.FocusOutlineColor = Color.Black;
            txtLogin.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.Black;
            txtLogin.Location = new Point(502, 62);
            txtLogin.Name = "txtLogin";
            txtLogin.NormalImageTint = Color.White;
            txtLogin.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtLogin.Padding = new Padding(16, 14, 16, 0);
            txtLogin.PasswordChar = false;
            txtLogin.PlaceholderColor = Color.LightGray;
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Rounding = new Padding(20);
            txtLogin.Size = new Size(266, 45);
            txtLogin.TabIndex = 2;
            txtLogin.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.White;
            txtEmail.BackgroundColor = Color.White;
            txtEmail.Content = "";
            txtEmail.FocusBackgroundColor = Color.White;
            txtEmail.FocusImageTint = Color.White;
            txtEmail.FocusOutlineColor = Color.Black;
            txtEmail.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(216, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.NormalImageTint = Color.White;
            txtEmail.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtEmail.Padding = new Padding(16, 14, 16, 0);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.LightGray;
            txtEmail.PlaceholderText = "Email";
            txtEmail.Rounding = new Padding(20);
            txtEmail.Size = new Size(266, 45);
            txtEmail.TabIndex = 3;
            txtEmail.UnderlinedStyle = true;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.BackColor = Color.White;
            txtPhone.BackgroundColor = Color.White;
            txtPhone.Content = "";
            txtPhone.FocusBackgroundColor = Color.White;
            txtPhone.FocusImageTint = Color.White;
            txtPhone.FocusOutlineColor = Color.Black;
            txtPhone.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.Black;
            txtPhone.Location = new Point(502, 117);
            txtPhone.Name = "txtPhone";
            txtPhone.NormalImageTint = Color.White;
            txtPhone.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtPhone.Padding = new Padding(16, 14, 16, 0);
            txtPhone.PasswordChar = false;
            txtPhone.PlaceholderColor = Color.LightGray;
            txtPhone.PlaceholderText = "Телефон +7(XXX)XXX-XX-XX";
            txtPhone.Rounding = new Padding(20);
            txtPhone.Size = new Size(266, 45);
            txtPhone.TabIndex = 4;
            txtPhone.UnderlinedStyle = true;
            // 
            // txtSecret
            // 
            txtSecret.Anchor = AnchorStyles.None;
            txtSecret.BackColor = Color.White;
            txtSecret.BackgroundColor = Color.White;
            txtSecret.Content = "";
            txtSecret.FocusBackgroundColor = Color.White;
            txtSecret.FocusImageTint = Color.White;
            txtSecret.FocusOutlineColor = Color.Black;
            txtSecret.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecret.ForeColor = Color.Black;
            txtSecret.Location = new Point(216, 172);
            txtSecret.Name = "txtSecret";
            txtSecret.NormalImageTint = Color.White;
            txtSecret.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtSecret.Padding = new Padding(16, 14, 16, 0);
            txtSecret.PasswordChar = false;
            txtSecret.PlaceholderColor = Color.LightGray;
            txtSecret.PlaceholderText = "Секретное слово";
            txtSecret.Rounding = new Padding(20);
            txtSecret.Size = new Size(266, 45);
            txtSecret.TabIndex = 5;
            txtSecret.UnderlinedStyle = true;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.Anchor = AnchorStyles.None;
            btnSaveProfile.BackColor = Color.White;
            btnSaveProfile.CheckButton = false;
            btnSaveProfile.Checked = false;
            btnSaveProfile.Content = "Сохранить профиль";
            btnSaveProfile.Cursor = Cursors.Hand;
            btnSaveProfile.Font = new Font("Segoe UI", 10.5F);
            btnSaveProfile.ForeColor = Color.White;
            btnSaveProfile.HoverBackground = Color.FromArgb(40, 40, 40);
            btnSaveProfile.HoverForeColor = Color.White;
            btnSaveProfile.HoverOutline = Color.Black;
            btnSaveProfile.Location = new Point(502, 172);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.NormalBackground = Color.Black;
            btnSaveProfile.NormalForeColor = Color.White;
            btnSaveProfile.NormalOutline = Color.Black;
            btnSaveProfile.OutlineThickness = 1F;
            btnSaveProfile.Padding = new Padding(12);
            btnSaveProfile.PressedBackground = Color.WhiteSmoke;
            btnSaveProfile.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSaveProfile.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSaveProfile.Rounding = new Padding(20);
            btnSaveProfile.Size = new Size(266, 45);
            btnSaveProfile.TabIndex = 6;
            btnSaveProfile.TextAlignment = StringAlignment.Center;
            btnSaveProfile.Click += BtnSaveProfile_Click;
            // 
            // lblPassHeader
            // 
            lblPassHeader.Anchor = AnchorStyles.None;
            lblPassHeader.AutoSize = true;
            lblPassHeader.BackColor = Color.White;
            lblPassHeader.Font = new Font("Segoe UI", 10.5F);
            lblPassHeader.Location = new Point(216, 232);
            lblPassHeader.Name = "lblPassHeader";
            lblPassHeader.Size = new Size(109, 19);
            lblPassHeader.TabIndex = 7;
            lblPassHeader.Text = "Смена пароля:";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Anchor = AnchorStyles.None;
            txtOldPassword.BackColor = Color.White;
            txtOldPassword.BackgroundColor = Color.White;
            txtOldPassword.Content = "";
            txtOldPassword.FocusBackgroundColor = Color.White;
            txtOldPassword.FocusImageTint = Color.White;
            txtOldPassword.FocusOutlineColor = Color.Black;
            txtOldPassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOldPassword.ForeColor = Color.Black;
            txtOldPassword.Location = new Point(216, 260);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.NormalImageTint = Color.White;
            txtOldPassword.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtOldPassword.Padding = new Padding(16, 14, 16, 0);
            txtOldPassword.PasswordChar = true;
            txtOldPassword.PlaceholderColor = Color.LightGray;
            txtOldPassword.PlaceholderText = "Текущий пароль";
            txtOldPassword.Rounding = new Padding(20);
            txtOldPassword.Size = new Size(175, 45);
            txtOldPassword.TabIndex = 8;
            txtOldPassword.UnderlinedStyle = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.None;
            txtNewPassword.BackColor = Color.White;
            txtNewPassword.BackgroundColor = Color.White;
            txtNewPassword.Content = "";
            txtNewPassword.FocusBackgroundColor = Color.White;
            txtNewPassword.FocusImageTint = Color.White;
            txtNewPassword.FocusOutlineColor = Color.Black;
            txtNewPassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.Black;
            txtNewPassword.Location = new Point(404, 260);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.NormalImageTint = Color.White;
            txtNewPassword.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtNewPassword.Padding = new Padding(16, 14, 16, 0);
            txtNewPassword.PasswordChar = true;
            txtNewPassword.PlaceholderColor = Color.LightGray;
            txtNewPassword.PlaceholderText = "Новый пароль";
            txtNewPassword.Rounding = new Padding(20);
            txtNewPassword.Size = new Size(175, 45);
            txtNewPassword.TabIndex = 9;
            txtNewPassword.UnderlinedStyle = true;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Anchor = AnchorStyles.None;
            txtRepeatPassword.BackColor = Color.White;
            txtRepeatPassword.BackgroundColor = Color.White;
            txtRepeatPassword.Content = "";
            txtRepeatPassword.FocusBackgroundColor = Color.White;
            txtRepeatPassword.FocusImageTint = Color.White;
            txtRepeatPassword.FocusOutlineColor = Color.Black;
            txtRepeatPassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRepeatPassword.ForeColor = Color.Black;
            txtRepeatPassword.Location = new Point(593, 260);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.NormalImageTint = Color.White;
            txtRepeatPassword.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtRepeatPassword.Padding = new Padding(16, 14, 16, 0);
            txtRepeatPassword.PasswordChar = true;
            txtRepeatPassword.PlaceholderColor = Color.LightGray;
            txtRepeatPassword.PlaceholderText = "Повтор пароля";
            txtRepeatPassword.Rounding = new Padding(20);
            txtRepeatPassword.Size = new Size(175, 45);
            txtRepeatPassword.TabIndex = 10;
            txtRepeatPassword.UnderlinedStyle = true;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.None;
            btnChangePassword.BackColor = Color.White;
            btnChangePassword.CheckButton = false;
            btnChangePassword.Checked = false;
            btnChangePassword.Content = "Обновить пароль";
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.Font = new Font("Segoe UI", 10.5F);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.HoverBackground = Color.FromArgb(40, 40, 40);
            btnChangePassword.HoverForeColor = Color.White;
            btnChangePassword.HoverOutline = Color.Black;
            btnChangePassword.Location = new Point(216, 325);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.NormalBackground = Color.Black;
            btnChangePassword.NormalForeColor = Color.White;
            btnChangePassword.NormalOutline = Color.Black;
            btnChangePassword.OutlineThickness = 1F;
            btnChangePassword.Padding = new Padding(12);
            btnChangePassword.PressedBackground = Color.WhiteSmoke;
            btnChangePassword.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnChangePassword.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnChangePassword.Rounding = new Padding(20);
            btnChangePassword.Size = new Size(266, 45);
            btnChangePassword.TabIndex = 11;
            btnChangePassword.TextAlignment = StringAlignment.Center;
            btnChangePassword.Click += BtnChangePassword_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = Color.White;
            btnClose.CheckButton = false;
            btnClose.Checked = false;
            btnClose.Content = "Назад";
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 10.5F);
            btnClose.ForeColor = Color.Black;
            btnClose.HoverBackground = Color.White;
            btnClose.HoverForeColor = Color.DimGray;
            btnClose.HoverOutline = Color.Black;
            btnClose.Location = new Point(502, 325);
            btnClose.Name = "btnClose";
            btnClose.NormalBackground = Color.White;
            btnClose.NormalForeColor = Color.Black;
            btnClose.NormalOutline = Color.Black;
            btnClose.OutlineThickness = 1F;
            btnClose.Padding = new Padding(12);
            btnClose.PressedBackground = Color.WhiteSmoke;
            btnClose.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnClose.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnClose.Rounding = new Padding(20);
            btnClose.Size = new Size(266, 45);
            btnClose.TabIndex = 12;
            btnClose.TextAlignment = StringAlignment.Center;
            btnClose.Click += btnClose_Click;
            // 
            // ProfileForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnClose);
            Controls.Add(btnChangePassword);
            Controls.Add(txtRepeatPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(lblPassHeader);
            Controls.Add(btnSaveProfile);
            Controls.Add(txtSecret);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLogin);
            Controls.Add(txtFullName);
            Controls.Add(lblTitle);
            DoubleBuffered = true;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Личный кабинет — EstateFlow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private HartUI.Controls.cuiTextBox txtFullName;
        private HartUI.Controls.cuiTextBox txtLogin;
        private HartUI.Controls.cuiTextBox txtEmail;
        private HartUI.Controls.cuiTextBox txtPhone;
        private HartUI.Controls.cuiTextBox txtSecret;
        private HartUI.Controls.cuiButton btnSaveProfile;
        private Label lblPassHeader;
        private HartUI.Controls.cuiTextBox txtOldPassword;
        private HartUI.Controls.cuiTextBox txtNewPassword;
        private HartUI.Controls.cuiTextBox txtRepeatPassword;
        private HartUI.Controls.cuiButton btnChangePassword;
        private HartUI.Controls.cuiButton btnClose;
    }
}
