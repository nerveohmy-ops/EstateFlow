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
            txtPhone = new HartUI.Controls.cuiTextBox();
            txtEmail = new HartUI.Controls.cuiTextBox();
            txtLogin = new HartUI.Controls.cuiTextBox();
            txtPassword = new HartUI.Controls.cuiTextBox();
            txtConfirmPassword = new HartUI.Controls.cuiTextBox();
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
            picLogo.Location = new Point(392, 20);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(200, 52);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.None;
            txtLastName.BackColor = Color.White;
            txtLastName.FocusBackgroundColor = Color.White;
            txtLastName.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtLastName.Content = "";
            txtLastName.FocusImageTint = Color.White;
            txtLastName.FocusOutlineColor = Color.Black;
            txtLastName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(214, 86);
            txtLastName.Name = "txtLastName";
            txtLastName.NormalImageTint = Color.White;
            txtLastName.OutlineColor = Color.FromArgb(95, 95, 95);
            txtLastName.Padding = new Padding(14, 12, 14, 0);
            txtLastName.PasswordChar = false;
            txtLastName.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtLastName.PlaceholderText = "Фамилия";
            txtLastName.Rounding = new Padding(12);
            txtLastName.Size = new Size(260, 42);
            txtLastName.TabIndex = 1;
            txtLastName.UnderlinedStyle = false;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.None;
            txtFirstName.BackColor = Color.White;
            txtFirstName.FocusBackgroundColor = Color.White;
            txtFirstName.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtFirstName.Content = "";
            txtFirstName.FocusImageTint = Color.White;
            txtFirstName.FocusOutlineColor = Color.Black;
            txtFirstName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(214, 138);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.NormalImageTint = Color.White;
            txtFirstName.OutlineColor = Color.FromArgb(95, 95, 95);
            txtFirstName.Padding = new Padding(14, 12, 14, 0);
            txtFirstName.PasswordChar = false;
            txtFirstName.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtFirstName.PlaceholderText = "Имя";
            txtFirstName.Rounding = new Padding(12);
            txtFirstName.Size = new Size(260, 42);
            txtFirstName.TabIndex = 2;
            txtFirstName.UnderlinedStyle = false;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Anchor = AnchorStyles.None;
            txtMiddleName.BackColor = Color.White;
            txtMiddleName.FocusBackgroundColor = Color.White;
            txtMiddleName.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtMiddleName.Content = "";
            txtMiddleName.FocusImageTint = Color.White;
            txtMiddleName.FocusOutlineColor = Color.Black;
            txtMiddleName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.ForeColor = Color.Black;
            txtMiddleName.Location = new Point(214, 190);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.NormalImageTint = Color.White;
            txtMiddleName.OutlineColor = Color.FromArgb(95, 95, 95);
            txtMiddleName.Padding = new Padding(14, 12, 14, 0);
            txtMiddleName.PasswordChar = false;
            txtMiddleName.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtMiddleName.PlaceholderText = "Отчество (при наличии)";
            txtMiddleName.Rounding = new Padding(12);
            txtMiddleName.Size = new Size(260, 42);
            txtMiddleName.TabIndex = 3;
            txtMiddleName.UnderlinedStyle = false;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.BackColor = Color.White;
            txtPhone.FocusBackgroundColor = Color.White;
            txtPhone.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtPhone.Content = "";
            txtPhone.FocusImageTint = Color.White;
            txtPhone.FocusOutlineColor = Color.Black;
            txtPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.Black;
            txtPhone.Location = new Point(214, 242);
            txtPhone.Name = "txtPhone";
            txtPhone.NormalImageTint = Color.White;
            txtPhone.OutlineColor = Color.FromArgb(95, 95, 95);
            txtPhone.Padding = new Padding(14, 12, 14, 0);
            txtPhone.PasswordChar = false;
            txtPhone.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtPhone.PlaceholderText = "+7(XXX)XXX-XX-XX";
            txtPhone.Rounding = new Padding(12);
            txtPhone.Size = new Size(260, 42);
            txtPhone.TabIndex = 4;
            txtPhone.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.White;
            txtEmail.FocusBackgroundColor = Color.White;
            txtEmail.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtEmail.Content = "";
            txtEmail.FocusImageTint = Color.White;
            txtEmail.FocusOutlineColor = Color.Black;
            txtEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(214, 294);
            txtEmail.Name = "txtEmail";
            txtEmail.NormalImageTint = Color.White;
            txtEmail.OutlineColor = Color.FromArgb(95, 95, 95);
            txtEmail.Padding = new Padding(14, 12, 14, 0);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtEmail.PlaceholderText = "Email";
            txtEmail.Rounding = new Padding(12);
            txtEmail.Size = new Size(260, 42);
            txtEmail.TabIndex = 5;
            txtEmail.UnderlinedStyle = false;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.BackColor = Color.White;
            txtLogin.FocusBackgroundColor = Color.White;
            txtLogin.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtLogin.Content = "";
            txtLogin.FocusImageTint = Color.White;
            txtLogin.FocusOutlineColor = Color.Black;
            txtLogin.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.Black;
            txtLogin.Location = new Point(510, 86);
            txtLogin.Name = "txtLogin";
            txtLogin.NormalImageTint = Color.White;
            txtLogin.OutlineColor = Color.FromArgb(95, 95, 95);
            txtLogin.Padding = new Padding(14, 12, 14, 0);
            txtLogin.PasswordChar = false;
            txtLogin.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Rounding = new Padding(12);
            txtLogin.Size = new Size(260, 42);
            txtLogin.TabIndex = 6;
            txtLogin.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.White;
            txtPassword.FocusBackgroundColor = Color.White;
            txtPassword.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtPassword.Content = "";
            txtPassword.FocusImageTint = Color.White;
            txtPassword.FocusOutlineColor = Color.Black;
            txtPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(510, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.NormalImageTint = Color.White;
            txtPassword.OutlineColor = Color.FromArgb(95, 95, 95);
            txtPassword.Padding = new Padding(14, 12, 14, 0);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtPassword.PlaceholderText = "Пароль (от 12 симв.)";
            txtPassword.Rounding = new Padding(12);
            txtPassword.Size = new Size(260, 42);
            txtPassword.TabIndex = 7;
            txtPassword.UnderlinedStyle = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.None;
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.FocusBackgroundColor = Color.White;
            txtConfirmPassword.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtConfirmPassword.Content = "";
            txtConfirmPassword.FocusImageTint = Color.White;
            txtConfirmPassword.FocusOutlineColor = Color.Black;
            txtConfirmPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.Black;
            txtConfirmPassword.Location = new Point(510, 190);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.NormalImageTint = Color.White;
            txtConfirmPassword.OutlineColor = Color.FromArgb(95, 95, 95);
            txtConfirmPassword.Padding = new Padding(14, 12, 14, 0);
            txtConfirmPassword.PasswordChar = true;
            txtConfirmPassword.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtConfirmPassword.PlaceholderText = "Подтвердите пароль";
            txtConfirmPassword.Rounding = new Padding(12);
            txtConfirmPassword.Size = new Size(260, 42);
            txtConfirmPassword.TabIndex = 8;
            txtConfirmPassword.UnderlinedStyle = false;
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
            chkShowPassword.Font = new Font("Segoe UI", 9.5F);
            chkShowPassword.Location = new Point(512, 248);
            chkShowPassword.MinimumSize = new Size(16, 16);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.OutlineThickness = 1F;
            chkShowPassword.Rounding = 4;
            chkShowPassword.ShowSymbols = true;
            chkShowPassword.Size = new Size(170, 22);
            chkShowPassword.TabIndex = 10;
            chkShowPassword.UncheckedForeground = Color.Empty;
            chkShowPassword.UncheckedOutlineColor = Color.Gray;
            chkShowPassword.UncheckedSymbolColor = Color.Empty;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(185, 28, 28);
            lblError.Location = new Point(214, 344);
            lblError.Name = "lblError";
            lblError.Size = new Size(556, 38);
            lblError.TabIndex = 13;
            lblError.Text = "";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
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
            btnRegister.Font = new Font("Segoe UI", 11.5F);
            btnRegister.ForeColor = Color.White;
            btnRegister.HoverBackground = Color.FromArgb(40, 40, 40);
            btnRegister.HoverForeColor = Color.White;
            btnRegister.HoverImageTint = Color.DimGray;
            btnRegister.HoverOutline = Color.Black;
            btnRegister.Location = new Point(324, 390);
            btnRegister.Name = "btnRegister";
            btnRegister.NormalBackground = Color.Black;
            btnRegister.NormalForeColor = Color.White;
            btnRegister.NormalImageTint = Color.Black;
            btnRegister.NormalOutline = Color.Black;
            btnRegister.OutlineThickness = 1F;
            btnRegister.Padding = new Padding(12);
            btnRegister.PressedBackground = Color.FromArgb(65, 65, 65);
            btnRegister.PressedForeColor = Color.White;
            btnRegister.PressedImageTint = Color.White;
            btnRegister.PressedOutline = Color.Black;
            btnRegister.Rounding = new Padding(20);
            btnRegister.Size = new Size(160, 45);
            btnRegister.TabIndex = 11;
            btnRegister.TextAlignment = StringAlignment.Center;
            btnRegister.TextPadding = 10;
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
            btnBack.Font = new Font("Segoe UI", 11.5F);
            btnBack.ForeColor = Color.Black;
            btnBack.HoverBackground = Color.FromArgb(242, 242, 242);
            btnBack.HoverForeColor = Color.Black;
            btnBack.HoverImageTint = Color.DimGray;
            btnBack.HoverOutline = Color.Black;
            btnBack.Location = new Point(500, 390);
            btnBack.Name = "btnBack";
            btnBack.NormalBackground = Color.White;
            btnBack.NormalForeColor = Color.Black;
            btnBack.NormalImageTint = Color.Black;
            btnBack.NormalOutline = Color.Black;
            btnBack.OutlineThickness = 1F;
            btnBack.Padding = new Padding(12);
            btnBack.PressedBackground = Color.FromArgb(230, 232, 236);
            btnBack.PressedForeColor = Color.Black;
            btnBack.PressedImageTint = Color.Black;
            btnBack.PressedOutline = Color.Black;
            btnBack.Rounding = new Padding(20);
            btnBack.Size = new Size(160, 45);
            btnBack.TabIndex = 12;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.TextPadding = 10;
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
            Controls.Add(picLogo);
            Controls.Add(chkShowPassword);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            DoubleBuffered = true;
            KeyPreview = true;
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
        private HartUI.Controls.cuiButton btnRegister;
        private HartUI.Controls.cuiButton btnBack;
        private HartUI.Controls.cuiCheckbox chkShowPassword;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private PictureBox picLogo;
        private Label lblError;
    }
}
