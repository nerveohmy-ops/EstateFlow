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
            txtLastName = new HartUI.Controls.cuiTextBox();
            txtFirstName = new HartUI.Controls.cuiTextBox();
            txtMiddleName = new HartUI.Controls.cuiTextBox();
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
            lblTitle.Location = new Point(216, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(198, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Личный кабинет";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.None;
            txtLastName.BackColor = Color.White;
            txtLastName.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtLastName.Content = "";
            txtLastName.FocusBackgroundColor = Color.White;
            txtLastName.FocusImageTint = Color.White;
            txtLastName.FocusOutlineColor = Color.Black;
            txtLastName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(216, 56);
            txtLastName.Name = "txtLastName";
            txtLastName.NormalImageTint = Color.White;
            txtLastName.OutlineColor = Color.FromArgb(95, 95, 95);
            txtLastName.Padding = new Padding(14, 12, 14, 0);
            txtLastName.PasswordChar = false;
            txtLastName.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtLastName.PlaceholderText = "Фамилия";
            txtLastName.Rounding = new Padding(12);
            txtLastName.Size = new Size(176, 44);
            txtLastName.TabIndex = 1;
            txtLastName.UnderlinedStyle = false;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.None;
            txtFirstName.BackColor = Color.White;
            txtFirstName.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtFirstName.Content = "";
            txtFirstName.FocusBackgroundColor = Color.White;
            txtFirstName.FocusImageTint = Color.White;
            txtFirstName.FocusOutlineColor = Color.Black;
            txtFirstName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(404, 56);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.NormalImageTint = Color.White;
            txtFirstName.OutlineColor = Color.FromArgb(95, 95, 95);
            txtFirstName.Padding = new Padding(14, 12, 14, 0);
            txtFirstName.PasswordChar = false;
            txtFirstName.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtFirstName.PlaceholderText = "Имя";
            txtFirstName.Rounding = new Padding(12);
            txtFirstName.Size = new Size(176, 44);
            txtFirstName.TabIndex = 2;
            txtFirstName.UnderlinedStyle = false;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Anchor = AnchorStyles.None;
            txtMiddleName.BackColor = Color.White;
            txtMiddleName.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtMiddleName.Content = "";
            txtMiddleName.FocusBackgroundColor = Color.White;
            txtMiddleName.FocusImageTint = Color.White;
            txtMiddleName.FocusOutlineColor = Color.Black;
            txtMiddleName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.ForeColor = Color.Black;
            txtMiddleName.Location = new Point(592, 56);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.NormalImageTint = Color.White;
            txtMiddleName.OutlineColor = Color.FromArgb(95, 95, 95);
            txtMiddleName.Padding = new Padding(14, 12, 14, 0);
            txtMiddleName.PasswordChar = false;
            txtMiddleName.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtMiddleName.PlaceholderText = "Отчество";
            txtMiddleName.Rounding = new Padding(12);
            txtMiddleName.Size = new Size(176, 44);
            txtMiddleName.TabIndex = 3;
            txtMiddleName.UnderlinedStyle = false;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.BackColor = Color.White;
            txtLogin.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtLogin.Content = "";
            txtLogin.Enabled = false;
            txtLogin.FocusBackgroundColor = Color.White;
            txtLogin.FocusImageTint = Color.White;
            txtLogin.FocusOutlineColor = Color.Black;
            txtLogin.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.Black;
            txtLogin.Location = new Point(216, 110);
            txtLogin.Name = "txtLogin";
            txtLogin.NormalImageTint = Color.White;
            txtLogin.OutlineColor = Color.FromArgb(95, 95, 95);
            txtLogin.Padding = new Padding(14, 12, 14, 0);
            txtLogin.PasswordChar = false;
            txtLogin.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Rounding = new Padding(12);
            txtLogin.Size = new Size(176, 44);
            txtLogin.TabIndex = 4;
            txtLogin.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.White;
            txtEmail.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtEmail.Content = "";
            txtEmail.FocusBackgroundColor = Color.White;
            txtEmail.FocusImageTint = Color.White;
            txtEmail.FocusOutlineColor = Color.Black;
            txtEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(404, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.NormalImageTint = Color.White;
            txtEmail.OutlineColor = Color.FromArgb(95, 95, 95);
            txtEmail.Padding = new Padding(14, 12, 14, 0);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtEmail.PlaceholderText = "Email";
            txtEmail.Rounding = new Padding(12);
            txtEmail.Size = new Size(176, 44);
            txtEmail.TabIndex = 5;
            txtEmail.UnderlinedStyle = false;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.BackColor = Color.White;
            txtPhone.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtPhone.Content = "";
            txtPhone.FocusBackgroundColor = Color.White;
            txtPhone.FocusImageTint = Color.White;
            txtPhone.FocusOutlineColor = Color.Black;
            txtPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.Black;
            txtPhone.Location = new Point(592, 110);
            txtPhone.Name = "txtPhone";
            txtPhone.NormalImageTint = Color.White;
            txtPhone.OutlineColor = Color.FromArgb(95, 95, 95);
            txtPhone.Padding = new Padding(14, 12, 14, 0);
            txtPhone.PasswordChar = false;
            txtPhone.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtPhone.PlaceholderText = "+7(XXX)XXX-XX-XX";
            txtPhone.Rounding = new Padding(12);
            txtPhone.Size = new Size(176, 44);
            txtPhone.TabIndex = 6;
            txtPhone.UnderlinedStyle = false;
            // 
            // txtSecret
            // 
            txtSecret.Anchor = AnchorStyles.None;
            txtSecret.BackColor = Color.White;
            txtSecret.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtSecret.Content = "";
            txtSecret.FocusBackgroundColor = Color.White;
            txtSecret.FocusImageTint = Color.White;
            txtSecret.FocusOutlineColor = Color.Black;
            txtSecret.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecret.ForeColor = Color.Black;
            txtSecret.Location = new Point(216, 166);
            txtSecret.Name = "txtSecret";
            txtSecret.NormalImageTint = Color.White;
            txtSecret.OutlineColor = Color.FromArgb(95, 95, 95);
            txtSecret.Padding = new Padding(14, 12, 14, 0);
            txtSecret.PasswordChar = false;
            txtSecret.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtSecret.PlaceholderText = "Секретное слово";
            txtSecret.Rounding = new Padding(12);
            txtSecret.Size = new Size(266, 44);
            txtSecret.TabIndex = 7;
            txtSecret.UnderlinedStyle = false;
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
            btnSaveProfile.Location = new Point(502, 166);
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
            btnSaveProfile.Size = new Size(266, 44);
            btnSaveProfile.TabIndex = 8;
            btnSaveProfile.TextAlignment = StringAlignment.Center;
            btnSaveProfile.Click += BtnSaveProfile_Click;
            // 
            // lblPassHeader
            // 
            lblPassHeader.Anchor = AnchorStyles.None;
            lblPassHeader.AutoSize = true;
            lblPassHeader.BackColor = Color.White;
            lblPassHeader.Font = new Font("Segoe UI", 10.5F);
            lblPassHeader.Location = new Point(216, 228);
            lblPassHeader.Name = "lblPassHeader";
            lblPassHeader.Size = new Size(109, 19);
            lblPassHeader.TabIndex = 9;
            lblPassHeader.Text = "Смена пароля:";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Anchor = AnchorStyles.None;
            txtOldPassword.BackColor = Color.White;
            txtOldPassword.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtOldPassword.Content = "";
            txtOldPassword.FocusBackgroundColor = Color.White;
            txtOldPassword.FocusImageTint = Color.White;
            txtOldPassword.FocusOutlineColor = Color.Black;
            txtOldPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOldPassword.ForeColor = Color.Black;
            txtOldPassword.Location = new Point(216, 256);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.NormalImageTint = Color.White;
            txtOldPassword.OutlineColor = Color.FromArgb(95, 95, 95);
            txtOldPassword.Padding = new Padding(14, 12, 14, 0);
            txtOldPassword.PasswordChar = true;
            txtOldPassword.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtOldPassword.PlaceholderText = "Текущий пароль";
            txtOldPassword.Rounding = new Padding(12);
            txtOldPassword.Size = new Size(176, 44);
            txtOldPassword.TabIndex = 10;
            txtOldPassword.UnderlinedStyle = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.None;
            txtNewPassword.BackColor = Color.White;
            txtNewPassword.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtNewPassword.Content = "";
            txtNewPassword.FocusBackgroundColor = Color.White;
            txtNewPassword.FocusImageTint = Color.White;
            txtNewPassword.FocusOutlineColor = Color.Black;
            txtNewPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.Black;
            txtNewPassword.Location = new Point(404, 256);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.NormalImageTint = Color.White;
            txtNewPassword.OutlineColor = Color.FromArgb(95, 95, 95);
            txtNewPassword.Padding = new Padding(14, 12, 14, 0);
            txtNewPassword.PasswordChar = true;
            txtNewPassword.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtNewPassword.PlaceholderText = "Новый пароль";
            txtNewPassword.Rounding = new Padding(12);
            txtNewPassword.Size = new Size(176, 44);
            txtNewPassword.TabIndex = 11;
            txtNewPassword.UnderlinedStyle = false;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Anchor = AnchorStyles.None;
            txtRepeatPassword.BackColor = Color.White;
            txtRepeatPassword.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtRepeatPassword.Content = "";
            txtRepeatPassword.FocusBackgroundColor = Color.White;
            txtRepeatPassword.FocusImageTint = Color.White;
            txtRepeatPassword.FocusOutlineColor = Color.Black;
            txtRepeatPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRepeatPassword.ForeColor = Color.Black;
            txtRepeatPassword.Location = new Point(592, 256);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.NormalImageTint = Color.White;
            txtRepeatPassword.OutlineColor = Color.FromArgb(95, 95, 95);
            txtRepeatPassword.Padding = new Padding(14, 12, 14, 0);
            txtRepeatPassword.PasswordChar = true;
            txtRepeatPassword.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtRepeatPassword.PlaceholderText = "Повтор пароля";
            txtRepeatPassword.Rounding = new Padding(12);
            txtRepeatPassword.Size = new Size(176, 44);
            txtRepeatPassword.TabIndex = 12;
            txtRepeatPassword.UnderlinedStyle = false;
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
            btnChangePassword.TabIndex = 13;
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
            btnClose.TabIndex = 14;
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
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
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
        private HartUI.Controls.cuiTextBox txtLastName;
        private HartUI.Controls.cuiTextBox txtFirstName;
        private HartUI.Controls.cuiTextBox txtMiddleName;
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
