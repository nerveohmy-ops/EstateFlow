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
            txtFullName = new HartUI.Controls.cuiTextBox();
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
            label1 = new Label();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 22);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 0;
            label1.Text = "EstateFlow";
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
            txtFullName.Image = null;
            txtFullName.ImageExpand = new Point(0, 0);
            txtFullName.ImageOffset = new Point(0, 0);
            txtFullName.ImageTextSpacing = 8;
            txtFullName.Location = new Point(355, 64);
            txtFullName.Margin = new Padding(4);
            txtFullName.Multiline = false;
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
            txtFullName.TextOffset = new Size(0, 0);
            txtFullName.UnderlinedStyle = true;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.BackColor = Color.White;
            txtLogin.BackgroundColor = Color.White;
            txtLogin.Content = "";
            txtLogin.FocusBackgroundColor = Color.White;
            txtLogin.FocusImageTint = Color.White;
            txtLogin.FocusOutlineColor = Color.Black;
            txtLogin.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.Black;
            txtLogin.Image = null;
            txtLogin.ImageExpand = new Point(0, 0);
            txtLogin.ImageOffset = new Point(0, 0);
            txtLogin.ImageTextSpacing = 8;
            txtLogin.Location = new Point(355, 117);
            txtLogin.Margin = new Padding(4);
            txtLogin.Multiline = false;
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
            txtLogin.TextOffset = new Size(0, 0);
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
            txtEmail.Image = null;
            txtEmail.ImageExpand = new Point(0, 0);
            txtEmail.ImageOffset = new Point(0, 0);
            txtEmail.ImageTextSpacing = 8;
            txtEmail.Location = new Point(355, 170);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
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
            txtEmail.TextOffset = new Size(0, 0);
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
            txtPhone.Image = null;
            txtPhone.ImageExpand = new Point(0, 0);
            txtPhone.ImageOffset = new Point(0, 0);
            txtPhone.ImageTextSpacing = 8;
            txtPhone.Location = new Point(355, 223);
            txtPhone.Margin = new Padding(4);
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.NormalImageTint = Color.White;
            txtPhone.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtPhone.Padding = new Padding(16, 14, 16, 0);
            txtPhone.PasswordChar = false;
            txtPhone.PlaceholderColor = Color.LightGray;
            txtPhone.PlaceholderText = "+7(XXX)XXX-XX-XX";
            txtPhone.Rounding = new Padding(20);
            txtPhone.Size = new Size(266, 45);
            txtPhone.TabIndex = 4;
            txtPhone.TextOffset = new Size(0, 0);
            txtPhone.UnderlinedStyle = true;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.White;
            txtPassword.BackgroundColor = Color.White;
            txtPassword.Content = "";
            txtPassword.FocusBackgroundColor = Color.White;
            txtPassword.FocusImageTint = Color.White;
            txtPassword.FocusOutlineColor = Color.Black;
            txtPassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Image = null;
            txtPassword.ImageExpand = new Point(0, 0);
            txtPassword.ImageOffset = new Point(0, 0);
            txtPassword.ImageTextSpacing = 8;
            txtPassword.Location = new Point(355, 276);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.NormalImageTint = Color.White;
            txtPassword.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtPassword.Padding = new Padding(16, 14, 16, 0);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.LightGray;
            txtPassword.PlaceholderText = "Пароль (от 12 симв.)";
            txtPassword.Rounding = new Padding(20);
            txtPassword.Size = new Size(266, 45);
            txtPassword.TabIndex = 5;
            txtPassword.TextOffset = new Size(0, 0);
            txtPassword.UnderlinedStyle = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.None;
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BackgroundColor = Color.White;
            txtConfirmPassword.Content = "";
            txtConfirmPassword.FocusBackgroundColor = Color.White;
            txtConfirmPassword.FocusImageTint = Color.White;
            txtConfirmPassword.FocusOutlineColor = Color.Black;
            txtConfirmPassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.Black;
            txtConfirmPassword.Image = null;
            txtConfirmPassword.ImageExpand = new Point(0, 0);
            txtConfirmPassword.ImageOffset = new Point(0, 0);
            txtConfirmPassword.ImageTextSpacing = 8;
            txtConfirmPassword.Location = new Point(355, 329);
            txtConfirmPassword.Margin = new Padding(4);
            txtConfirmPassword.Multiline = false;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.NormalImageTint = Color.White;
            txtConfirmPassword.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtConfirmPassword.Padding = new Padding(16, 14, 16, 0);
            txtConfirmPassword.PasswordChar = true;
            txtConfirmPassword.PlaceholderColor = Color.LightGray;
            txtConfirmPassword.PlaceholderText = "Подтвердите пароль";
            txtConfirmPassword.Rounding = new Padding(20);
            txtConfirmPassword.Size = new Size(266, 45);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.TextOffset = new Size(0, 0);
            txtConfirmPassword.UnderlinedStyle = true;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.None;
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.White;
            lblRole.Font = new Font("Segoe UI", 9F);
            lblRole.ForeColor = Color.Gray;
            lblRole.Location = new Point(635, 64);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(38, 15);
            lblRole.TabIndex = 7;
            lblRole.Text = "Роль:";
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.None;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.Font = new Font("Segoe UI", 9.5F);
            cmbRole.Items.AddRange(new object[] { "Клиент", "Агент" });
            cmbRole.Location = new Point(635, 83);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(190, 25);
            cmbRole.TabIndex = 8;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // txtInvite
            // 
            txtInvite.Anchor = AnchorStyles.None;
            txtInvite.BackColor = Color.White;
            txtInvite.BackgroundColor = Color.White;
            txtInvite.Content = "";
            txtInvite.FocusBackgroundColor = Color.White;
            txtInvite.FocusImageTint = Color.White;
            txtInvite.FocusOutlineColor = Color.Black;
            txtInvite.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInvite.ForeColor = Color.Black;
            txtInvite.Location = new Point(635, 117);
            txtInvite.Name = "txtInvite";
            txtInvite.NormalImageTint = Color.White;
            txtInvite.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtInvite.Padding = new Padding(16, 14, 16, 0);
            txtInvite.PasswordChar = false;
            txtInvite.PlaceholderColor = Color.LightGray;
            txtInvite.PlaceholderText = "Код сотрудника";
            txtInvite.Rounding = new Padding(20);
            txtInvite.Size = new Size(190, 45);
            txtInvite.TabIndex = 9;
            txtInvite.UnderlinedStyle = true;
            txtInvite.Visible = false;
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
            txtSecret.Location = new Point(635, 170);
            txtSecret.Name = "txtSecret";
            txtSecret.NormalImageTint = Color.White;
            txtSecret.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtSecret.Padding = new Padding(16, 14, 16, 0);
            txtSecret.PasswordChar = false;
            txtSecret.PlaceholderColor = Color.LightGray;
            txtSecret.PlaceholderText = "Секретное слово";
            txtSecret.Rounding = new Padding(20);
            txtSecret.Size = new Size(190, 45);
            txtSecret.TabIndex = 10;
            txtSecret.UnderlinedStyle = true;
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
            chkShowPassword.Location = new Point(635, 290);
            chkShowPassword.MinimumSize = new Size(16, 16);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.OutlineThickness = 1F;
            chkShowPassword.Rounding = 4;
            chkShowPassword.ShowSymbols = true;
            chkShowPassword.Size = new Size(145, 18);
            chkShowPassword.TabIndex = 11;
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
            lblError.Location = new Point(635, 325);
            lblError.Name = "lblError";
            lblError.Size = new Size(230, 50);
            lblError.TabIndex = 12;
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
            btnRegister.HoverBackground = Color.White;
            btnRegister.HoverForeColor = Color.DimGray;
            btnRegister.HoverImageTint = Color.DimGray;
            btnRegister.HoverOutline = Color.Black;
            btnRegister.Image = null;
            btnRegister.ImageExpand = new Point(0, 0);
            btnRegister.Location = new Point(355, 381);
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
            btnRegister.Size = new Size(125, 45);
            btnRegister.TabIndex = 13;
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
            btnBack.HoverBackground = Color.Transparent;
            btnBack.HoverForeColor = Color.DimGray;
            btnBack.HoverImageTint = Color.DimGray;
            btnBack.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnBack.Image = null;
            btnBack.ImageExpand = new Point(0, 0);
            btnBack.Location = new Point(496, 381);
            btnBack.Name = "btnBack";
            btnBack.NormalBackground = Color.Black;
            btnBack.NormalForeColor = Color.White;
            btnBack.NormalImageTint = Color.Black;
            btnBack.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnBack.OutlineThickness = 1F;
            btnBack.Padding = new Padding(12);
            btnBack.PressedBackground = Color.WhiteSmoke;
            btnBack.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnBack.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnBack.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnBack.Rounding = new Padding(20);
            btnBack.Size = new Size(125, 45);
            btnBack.TabIndex = 14;
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
            Controls.Add(label1);
            Controls.Add(chkShowPassword);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLogin);
            Controls.Add(txtFullName);
            DoubleBuffered = true;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HartUI.Controls.cuiTextBox txtFullName;
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
        private Label label1;
        private Label lblError;
    }
}
