namespace EstateFlow.Forms
{
    partial class RegisterForm
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
            components = new System.ComponentModel.Container();
            txtLastName = new HartUI.Controls.cuiTextBox();
            txtFirstName = new HartUI.Controls.cuiTextBox();
            txtMiddleName = new HartUI.Controls.cuiTextBox();
            txtLogin = new HartUI.Controls.cuiTextBox();
            txtEmail = new HartUI.Controls.cuiTextBox();
            txtPhone = new HartUI.Controls.cuiTextBox();
            txtPassword = new HartUI.Controls.cuiTextBox();
            txtConfirmPassword = new HartUI.Controls.cuiTextBox();
            txtSecret = new HartUI.Controls.cuiTextBox();
            txtInvite = new HartUI.Controls.cuiTextBox();
            cmbRole = new ComboBox();
            lblRole = new Label();
            btnRegister = new HartUI.Controls.cuiButton();
            btnBack = new HartUI.Controls.cuiButton();
            chkShowPassword = new HartUI.Controls.cuiCheckbox();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            picLogo = new PictureBox();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.BackColor = Color.Transparent;
            picLogo.Location = new Point(392, 8);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(200, 48);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
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
            txtLastName.Location = new Point(225, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.NormalImageTint = Color.White;
            txtLastName.OutlineColor = Color.FromArgb(95, 95, 95);
            txtLastName.Padding = new Padding(14, 12, 14, 0);
            txtLastName.PasswordChar = false;
            txtLastName.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtLastName.PlaceholderText = "Фамилия";
            txtLastName.Rounding = new Padding(12);
            txtLastName.Size = new Size(255, 42);
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
            txtFirstName.Location = new Point(225, 112);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.NormalImageTint = Color.White;
            txtFirstName.OutlineColor = Color.FromArgb(95, 95, 95);
            txtFirstName.Padding = new Padding(14, 12, 14, 0);
            txtFirstName.PasswordChar = false;
            txtFirstName.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtFirstName.PlaceholderText = "Имя";
            txtFirstName.Rounding = new Padding(12);
            txtFirstName.Size = new Size(255, 42);
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
            txtMiddleName.Location = new Point(225, 162);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.NormalImageTint = Color.White;
            txtMiddleName.OutlineColor = Color.FromArgb(95, 95, 95);
            txtMiddleName.Padding = new Padding(14, 12, 14, 0);
            txtMiddleName.PasswordChar = false;
            txtMiddleName.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtMiddleName.PlaceholderText = "Отчество (при наличии)";
            txtMiddleName.Rounding = new Padding(12);
            txtMiddleName.Size = new Size(255, 42);
            txtMiddleName.TabIndex = 3;
            txtMiddleName.UnderlinedStyle = false;
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
            txtPhone.Location = new Point(225, 212);
            txtPhone.Name = "txtPhone";
            txtPhone.NormalImageTint = Color.White;
            txtPhone.OutlineColor = Color.FromArgb(95, 95, 95);
            txtPhone.Padding = new Padding(14, 12, 14, 0);
            txtPhone.PasswordChar = false;
            txtPhone.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtPhone.PlaceholderText = "+7(XXX)XXX-XX-XX";
            txtPhone.Rounding = new Padding(12);
            txtPhone.Size = new Size(255, 42);
            txtPhone.TabIndex = 4;
            txtPhone.UnderlinedStyle = false;
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
            txtEmail.Location = new Point(225, 262);
            txtEmail.Name = "txtEmail";
            txtEmail.NormalImageTint = Color.White;
            txtEmail.OutlineColor = Color.FromArgb(95, 95, 95);
            txtEmail.Padding = new Padding(14, 12, 14, 0);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtEmail.PlaceholderText = "Email";
            txtEmail.Rounding = new Padding(12);
            txtEmail.Size = new Size(255, 42);
            txtEmail.TabIndex = 5;
            txtEmail.UnderlinedStyle = false;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.None;
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.White;
            lblRole.Font = new Font("Segoe UI", 9F);
            lblRole.ForeColor = Color.FromArgb(70, 70, 70);
            lblRole.Location = new Point(225, 314);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(38, 15);
            lblRole.TabIndex = 6;
            lblRole.Text = "Роль:";
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.None;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.Font = new Font("Segoe UI", 9.5F);
            cmbRole.Items.AddRange(new object[] { "Клиент", "Агент" });
            cmbRole.Location = new Point(270, 310);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(210, 25);
            cmbRole.TabIndex = 7;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // txtInvite
            // 
            txtInvite.Anchor = AnchorStyles.None;
            txtInvite.BackColor = Color.White;
            txtInvite.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtInvite.Content = "";
            txtInvite.FocusBackgroundColor = Color.White;
            txtInvite.FocusImageTint = Color.White;
            txtInvite.FocusOutlineColor = Color.Black;
            txtInvite.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInvite.ForeColor = Color.Black;
            txtInvite.Location = new Point(225, 342);
            txtInvite.Name = "txtInvite";
            txtInvite.NormalImageTint = Color.White;
            txtInvite.OutlineColor = Color.FromArgb(95, 95, 95);
            txtInvite.Padding = new Padding(14, 12, 14, 0);
            txtInvite.PasswordChar = false;
            txtInvite.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtInvite.PlaceholderText = "Код сотрудника";
            txtInvite.Rounding = new Padding(12);
            txtInvite.Size = new Size(255, 42);
            txtInvite.TabIndex = 8;
            txtInvite.UnderlinedStyle = false;
            txtInvite.Visible = false;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.BackColor = Color.White;
            txtLogin.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtLogin.Content = "";
            txtLogin.FocusBackgroundColor = Color.White;
            txtLogin.FocusImageTint = Color.White;
            txtLogin.FocusOutlineColor = Color.Black;
            txtLogin.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.Black;
            txtLogin.Location = new Point(495, 62);
            txtLogin.Name = "txtLogin";
            txtLogin.NormalImageTint = Color.White;
            txtLogin.OutlineColor = Color.FromArgb(95, 95, 95);
            txtLogin.Padding = new Padding(14, 12, 14, 0);
            txtLogin.PasswordChar = false;
            txtLogin.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Rounding = new Padding(12);
            txtLogin.Size = new Size(255, 42);
            txtLogin.TabIndex = 9;
            txtLogin.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.White;
            txtPassword.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtPassword.Content = "";
            txtPassword.FocusBackgroundColor = Color.White;
            txtPassword.FocusImageTint = Color.White;
            txtPassword.FocusOutlineColor = Color.Black;
            txtPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(495, 112);
            txtPassword.Name = "txtPassword";
            txtPassword.NormalImageTint = Color.White;
            txtPassword.OutlineColor = Color.FromArgb(95, 95, 95);
            txtPassword.Padding = new Padding(14, 12, 14, 0);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtPassword.PlaceholderText = "Пароль (от 12 симв.)";
            txtPassword.Rounding = new Padding(12);
            txtPassword.Size = new Size(255, 42);
            txtPassword.TabIndex = 10;
            txtPassword.UnderlinedStyle = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.None;
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtConfirmPassword.Content = "";
            txtConfirmPassword.FocusBackgroundColor = Color.White;
            txtConfirmPassword.FocusImageTint = Color.White;
            txtConfirmPassword.FocusOutlineColor = Color.Black;
            txtConfirmPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.Black;
            txtConfirmPassword.Location = new Point(495, 162);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.NormalImageTint = Color.White;
            txtConfirmPassword.OutlineColor = Color.FromArgb(95, 95, 95);
            txtConfirmPassword.Padding = new Padding(14, 12, 14, 0);
            txtConfirmPassword.PasswordChar = true;
            txtConfirmPassword.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtConfirmPassword.PlaceholderText = "Подтвердите пароль";
            txtConfirmPassword.Rounding = new Padding(12);
            txtConfirmPassword.Size = new Size(255, 42);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.UnderlinedStyle = false;
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
            txtSecret.Location = new Point(495, 212);
            txtSecret.Name = "txtSecret";
            txtSecret.NormalImageTint = Color.White;
            txtSecret.OutlineColor = Color.FromArgb(95, 95, 95);
            txtSecret.Padding = new Padding(14, 12, 14, 0);
            txtSecret.PasswordChar = false;
            txtSecret.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtSecret.PlaceholderText = "Секретное слово";
            txtSecret.Rounding = new Padding(12);
            txtSecret.Size = new Size(255, 42);
            txtSecret.TabIndex = 12;
            txtSecret.UnderlinedStyle = false;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Anchor = AnchorStyles.None;
            chkShowPassword.BackColor = Color.White;
            chkShowPassword.Checked = false;
            chkShowPassword.CheckedForeground = Color.Black;
            chkShowPassword.CheckedOutlineColor = Color.Black;
            chkShowPassword.CheckedSymbolColor = Color.White;
            chkShowPassword.Content = "Показать пароль";
            chkShowPassword.Cursor = Cursors.Hand;
            chkShowPassword.Font = new Font("Segoe UI", 10F);
            chkShowPassword.Location = new Point(495, 268);
            chkShowPassword.MinimumSize = new Size(16, 16);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.OutlineThickness = 1F;
            chkShowPassword.Rounding = 4;
            chkShowPassword.ShowSymbols = true;
            chkShowPassword.Size = new Size(145, 18);
            chkShowPassword.TabIndex = 13;
            chkShowPassword.UncheckedForeground = Color.Empty;
            chkShowPassword.UncheckedOutlineColor = Color.Gray;
            chkShowPassword.UncheckedSymbolColor = Color.Empty;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.BackColor = Color.White;
            lblError.Font = new Font("Segoe UI", 8.5F);
            lblError.ForeColor = Color.DarkRed;
            lblError.Location = new Point(495, 300);
            lblError.Name = "lblError";
            lblError.Size = new Size(255, 65);
            lblError.TabIndex = 14;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.BackColor = Color.White;
            btnRegister.CheckButton = false;
            btnRegister.Checked = false;
            btnRegister.CheckedBackground = Color.Black;
            btnRegister.CheckedForeColor = Color.White;
            btnRegister.CheckedImageTint = Color.White;
            btnRegister.CheckedOutline = Color.Black;
            btnRegister.Content = "Регистрация";
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.DialogResult = DialogResult.None;
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.ForeColor = Color.Black;
            btnRegister.HoverBackground = Color.FromArgb(242, 242, 242);
            btnRegister.HoverForeColor = Color.Black;
            btnRegister.HoverImageTint = Color.DimGray;
            btnRegister.HoverOutline = Color.Black;
            btnRegister.Location = new Point(350, 392);
            btnRegister.Name = "btnRegister";
            btnRegister.NormalBackground = Color.White;
            btnRegister.NormalForeColor = Color.Black;
            btnRegister.NormalImageTint = Color.Black;
            btnRegister.NormalOutline = Color.Black;
            btnRegister.OutlineThickness = 1F;
            btnRegister.Padding = new Padding(12);
            btnRegister.PressedBackground = Color.WhiteSmoke;
            btnRegister.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRegister.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRegister.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegister.Rounding = new Padding(20);
            btnRegister.Size = new Size(130, 45);
            btnRegister.TabIndex = 15;
            btnRegister.TextAlignment = StringAlignment.Center;
            btnRegister.TextPadding = 12;
            btnRegister.TextSpacing = 2;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.White;
            btnBack.CheckButton = false;
            btnBack.Checked = false;
            btnBack.CheckedBackground = Color.Black;
            btnBack.CheckedForeColor = Color.White;
            btnBack.CheckedImageTint = Color.White;
            btnBack.CheckedOutline = Color.Black;
            btnBack.Content = "Назад";
            btnBack.Cursor = Cursors.Hand;
            btnBack.DialogResult = DialogResult.None;
            btnBack.Font = new Font("Segoe UI", 12F);
            btnBack.ForeColor = Color.White;
            btnBack.HoverBackground = Color.FromArgb(40, 40, 40);
            btnBack.HoverForeColor = Color.White;
            btnBack.HoverImageTint = Color.DimGray;
            btnBack.HoverOutline = Color.Black;
            btnBack.Location = new Point(495, 392);
            btnBack.Name = "btnBack";
            btnBack.NormalBackground = Color.Black;
            btnBack.NormalForeColor = Color.White;
            btnBack.NormalImageTint = Color.Black;
            btnBack.NormalOutline = Color.Black;
            btnBack.OutlineThickness = 1F;
            btnBack.Padding = new Padding(12);
            btnBack.PressedBackground = Color.WhiteSmoke;
            btnBack.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnBack.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnBack.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnBack.Rounding = new Padding(20);
            btnBack.Size = new Size(130, 45);
            btnBack.TabIndex = 16;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.TextPadding = 12;
            btnBack.TextSpacing = 2;
            btnBack.Click += btnBack_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.ToolTipTitle = "Ошибка ввода";
            // 
            // RegisterForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(lblError);
            Controls.Add(txtSecret);
            Controls.Add(txtInvite);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(picLogo);
            Controls.Add(chkShowPassword);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLogin);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            DoubleBuffered = true;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HartUI.Controls.cuiTextBox txtLastName;
        private HartUI.Controls.cuiTextBox txtFirstName;
        private HartUI.Controls.cuiTextBox txtMiddleName;
        private HartUI.Controls.cuiTextBox txtLogin;
        private HartUI.Controls.cuiTextBox txtEmail;
        private HartUI.Controls.cuiTextBox txtPhone;
        private HartUI.Controls.cuiTextBox txtPassword;
        private HartUI.Controls.cuiTextBox txtConfirmPassword;
        private HartUI.Controls.cuiTextBox txtSecret;
        private HartUI.Controls.cuiTextBox txtInvite;
        private ComboBox cmbRole;
        private Label lblRole;
        private HartUI.Controls.cuiButton btnRegister;
        private HartUI.Controls.cuiButton btnBack;
        private HartUI.Controls.cuiCheckbox chkShowPassword;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private PictureBox picLogo;
        private Label lblError;
    }
}
