namespace EstateFlow.Forms
{
    partial class UserEditForm
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
            lblRole = new Label();
            cmbRole = new ComboBox();
            txtLogin = new HartUI.Controls.cuiTextBox();
            txtEmail = new HartUI.Controls.cuiTextBox();
            txtPhone = new HartUI.Controls.cuiTextBox();
            txtSecret = new HartUI.Controls.cuiTextBox();
            txtPassword = new HartUI.Controls.cuiTextBox();
            btnGeneratePassword = new HartUI.Controls.cuiButton();
            btnSave = new HartUI.Controls.cuiButton();
            btnCancel = new HartUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F);
            lblTitle.Location = new Point(216, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(254, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Новый пользователь";
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
            txtFullName.Location = new Point(216, 70);
            txtFullName.Name = "txtFullName";
            txtFullName.NormalImageTint = Color.White;
            txtFullName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtFullName.Padding = new Padding(16, 14, 16, 0);
            txtFullName.PasswordChar = false;
            txtFullName.PlaceholderColor = Color.LightGray;
            txtFullName.PlaceholderText = "ФИО";
            txtFullName.Rounding = new Padding(20);
            txtFullName.Size = new Size(360, 45);
            txtFullName.TabIndex = 1;
            txtFullName.UnderlinedStyle = true;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.None;
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.White;
            lblRole.Font = new Font("Segoe UI", 9F);
            lblRole.Location = new Point(590, 68);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(38, 15);
            lblRole.TabIndex = 2;
            lblRole.Text = "Роль:";
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.None;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 9.5F);
            cmbRole.Location = new Point(590, 88);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(176, 25);
            cmbRole.TabIndex = 3;
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
            txtLogin.Location = new Point(216, 130);
            txtLogin.Name = "txtLogin";
            txtLogin.NormalImageTint = Color.White;
            txtLogin.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtLogin.Padding = new Padding(16, 14, 16, 0);
            txtLogin.PasswordChar = false;
            txtLogin.PlaceholderColor = Color.LightGray;
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Rounding = new Padding(20);
            txtLogin.Size = new Size(266, 45);
            txtLogin.TabIndex = 4;
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
            txtEmail.Location = new Point(502, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.NormalImageTint = Color.White;
            txtEmail.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtEmail.Padding = new Padding(16, 14, 16, 0);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.LightGray;
            txtEmail.PlaceholderText = "Email";
            txtEmail.Rounding = new Padding(20);
            txtEmail.Size = new Size(266, 45);
            txtEmail.TabIndex = 5;
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
            txtPhone.Location = new Point(216, 190);
            txtPhone.Name = "txtPhone";
            txtPhone.NormalImageTint = Color.White;
            txtPhone.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtPhone.Padding = new Padding(16, 14, 16, 0);
            txtPhone.PasswordChar = false;
            txtPhone.PlaceholderColor = Color.LightGray;
            txtPhone.PlaceholderText = "Телефон +7(XXX)XXX-XX-XX";
            txtPhone.Rounding = new Padding(20);
            txtPhone.Size = new Size(266, 45);
            txtPhone.TabIndex = 6;
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
            txtSecret.Location = new Point(502, 190);
            txtSecret.Name = "txtSecret";
            txtSecret.NormalImageTint = Color.White;
            txtSecret.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtSecret.Padding = new Padding(16, 14, 16, 0);
            txtSecret.PasswordChar = false;
            txtSecret.PlaceholderColor = Color.LightGray;
            txtSecret.PlaceholderText = "Секретное слово";
            txtSecret.Rounding = new Padding(20);
            txtSecret.Size = new Size(266, 45);
            txtSecret.TabIndex = 7;
            txtSecret.UnderlinedStyle = true;
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
            txtPassword.Location = new Point(216, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.NormalImageTint = Color.White;
            txtPassword.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtPassword.Padding = new Padding(16, 14, 16, 0);
            txtPassword.PasswordChar = false;
            txtPassword.PlaceholderColor = Color.LightGray;
            txtPassword.PlaceholderText = "Пароль (не менее 12 символов)";
            txtPassword.Rounding = new Padding(20);
            txtPassword.Size = new Size(360, 45);
            txtPassword.TabIndex = 8;
            txtPassword.UnderlinedStyle = true;
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.Anchor = AnchorStyles.None;
            btnGeneratePassword.BackColor = Color.White;
            btnGeneratePassword.CheckButton = false;
            btnGeneratePassword.Checked = false;
            btnGeneratePassword.Content = "Сгенерировать";
            btnGeneratePassword.Cursor = Cursors.Hand;
            btnGeneratePassword.Font = new Font("Segoe UI", 10.5F);
            btnGeneratePassword.ForeColor = Color.Black;
            btnGeneratePassword.HoverBackground = Color.White;
            btnGeneratePassword.HoverForeColor = Color.DimGray;
            btnGeneratePassword.HoverOutline = Color.Black;
            btnGeneratePassword.Location = new Point(590, 250);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.NormalBackground = Color.White;
            btnGeneratePassword.NormalForeColor = Color.Black;
            btnGeneratePassword.NormalOutline = Color.Black;
            btnGeneratePassword.OutlineThickness = 1F;
            btnGeneratePassword.Padding = new Padding(12);
            btnGeneratePassword.PressedBackground = Color.WhiteSmoke;
            btnGeneratePassword.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnGeneratePassword.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnGeneratePassword.Rounding = new Padding(20);
            btnGeneratePassword.Size = new Size(178, 45);
            btnGeneratePassword.TabIndex = 9;
            btnGeneratePassword.TextAlignment = StringAlignment.Center;
            btnGeneratePassword.Click += btnGeneratePassword_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.White;
            btnSave.CheckButton = false;
            btnSave.Checked = false;
            btnSave.Content = "Сохранить";
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 10.5F);
            btnSave.ForeColor = Color.White;
            btnSave.HoverBackground = Color.FromArgb(40, 40, 40);
            btnSave.HoverForeColor = Color.White;
            btnSave.HoverOutline = Color.Black;
            btnSave.Location = new Point(216, 335);
            btnSave.Name = "btnSave";
            btnSave.NormalBackground = Color.Black;
            btnSave.NormalForeColor = Color.White;
            btnSave.NormalOutline = Color.Black;
            btnSave.OutlineThickness = 1F;
            btnSave.Padding = new Padding(12);
            btnSave.PressedBackground = Color.WhiteSmoke;
            btnSave.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSave.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSave.Rounding = new Padding(20);
            btnSave.Size = new Size(266, 45);
            btnSave.TabIndex = 10;
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.White;
            btnCancel.CheckButton = false;
            btnCancel.Checked = false;
            btnCancel.Content = "Назад";
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10.5F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.HoverBackground = Color.White;
            btnCancel.HoverForeColor = Color.DimGray;
            btnCancel.HoverOutline = Color.Black;
            btnCancel.Location = new Point(502, 335);
            btnCancel.Name = "btnCancel";
            btnCancel.NormalBackground = Color.White;
            btnCancel.NormalForeColor = Color.Black;
            btnCancel.NormalOutline = Color.Black;
            btnCancel.OutlineThickness = 1F;
            btnCancel.Padding = new Padding(12);
            btnCancel.PressedBackground = Color.WhiteSmoke;
            btnCancel.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCancel.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancel.Rounding = new Padding(20);
            btnCancel.Size = new Size(266, 45);
            btnCancel.TabIndex = 11;
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
            // 
            // UserEditForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnGeneratePassword);
            Controls.Add(txtPassword);
            Controls.Add(txtSecret);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLogin);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(txtFullName);
            Controls.Add(lblTitle);
            DoubleBuffered = true;
            Name = "UserEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пользователь — EstateFlow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private HartUI.Controls.cuiTextBox txtFullName;
        private Label lblRole;
        private ComboBox cmbRole;
        private HartUI.Controls.cuiTextBox txtLogin;
        private HartUI.Controls.cuiTextBox txtEmail;
        private HartUI.Controls.cuiTextBox txtPhone;
        private HartUI.Controls.cuiTextBox txtSecret;
        private HartUI.Controls.cuiTextBox txtPassword;
        private HartUI.Controls.cuiButton btnGeneratePassword;
        private HartUI.Controls.cuiButton btnSave;
        private HartUI.Controls.cuiButton btnCancel;
    }
}
