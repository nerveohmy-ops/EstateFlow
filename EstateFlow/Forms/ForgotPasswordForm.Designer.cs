namespace EstateFlow.Forms
{
    partial class ForgotPasswordForm
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
            picLogo = new PictureBox();
            lblSub = new Label();
            txtEmail = new HartUI.Controls.cuiTextBox();
            lblCodeBanner = new Label();
            txtCode = new HartUI.Controls.cuiTextBox();
            txtNewPassword = new HartUI.Controls.cuiTextBox();
            txtConfirmPassword = new HartUI.Controls.cuiTextBox();
            chkShowPassword = new HartUI.Controls.cuiCheckbox();
            btnReset = new HartUI.Controls.cuiButton();
            btnBack = new HartUI.Controls.cuiButton();
            lblError = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.BackColor = Color.Transparent;
            picLogo.Location = new Point(382, 16);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(220, 58);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblSub
            // 
            lblSub.Anchor = AnchorStyles.None;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblSub.ForeColor = Color.DimGray;
            lblSub.Location = new Point(332, 78);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(320, 22);
            lblSub.TabIndex = 1;
            lblSub.Text = "Восстановление пароля";
            lblSub.TextAlign = ContentAlignment.MiddleCenter;
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
            txtEmail.Location = new Point(332, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.NormalImageTint = Color.White;
            txtEmail.OutlineColor = Color.FromArgb(95, 95, 95);
            txtEmail.Padding = new Padding(14, 12, 14, 0);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtEmail.PlaceholderText = "Введите ваш Email";
            txtEmail.Rounding = new Padding(12);
            txtEmail.Size = new Size(320, 42);
            txtEmail.TabIndex = 2;
            txtEmail.UnderlinedStyle = false;
            // 
            // lblCodeBanner
            // 
            lblCodeBanner.Anchor = AnchorStyles.None;
            lblCodeBanner.BackColor = Color.White;
            lblCodeBanner.BorderStyle = BorderStyle.FixedSingle;
            lblCodeBanner.Font = new Font("Segoe UI", 8.8F);
            lblCodeBanner.ForeColor = Color.Black;
            lblCodeBanner.Location = new Point(332, 158);
            lblCodeBanner.Name = "lblCodeBanner";
            lblCodeBanner.Padding = new Padding(6, 4, 6, 4);
            lblCodeBanner.Size = new Size(320, 42);
            lblCodeBanner.TabIndex = 3;
            lblCodeBanner.Text = "";
            lblCodeBanner.TextAlign = ContentAlignment.MiddleCenter;
            lblCodeBanner.Visible = false;
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.None;
            txtCode.BackColor = Color.White;
            txtCode.FocusBackgroundColor = Color.White;
            txtCode.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtCode.Content = "";
            txtCode.FocusImageTint = Color.White;
            txtCode.FocusOutlineColor = Color.Black;
            txtCode.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.ForeColor = Color.Black;
            txtCode.Location = new Point(332, 210);
            txtCode.Name = "txtCode";
            txtCode.NormalImageTint = Color.White;
            txtCode.OutlineColor = Color.FromArgb(95, 95, 95);
            txtCode.Padding = new Padding(14, 12, 14, 0);
            txtCode.PasswordChar = false;
            txtCode.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtCode.PlaceholderText = "6-значный код подтверждения";
            txtCode.Rounding = new Padding(12);
            txtCode.Size = new Size(320, 40);
            txtCode.TabIndex = 4;
            txtCode.UnderlinedStyle = false;
            txtCode.Visible = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.None;
            txtNewPassword.BackColor = Color.White;
            txtNewPassword.FocusBackgroundColor = Color.White;
            txtNewPassword.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtNewPassword.Content = "";
            txtNewPassword.FocusImageTint = Color.White;
            txtNewPassword.FocusOutlineColor = Color.Black;
            txtNewPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.Black;
            txtNewPassword.Location = new Point(332, 246);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.NormalImageTint = Color.White;
            txtNewPassword.OutlineColor = Color.FromArgb(95, 95, 95);
            txtNewPassword.Padding = new Padding(14, 12, 14, 0);
            txtNewPassword.PasswordChar = true;
            txtNewPassword.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtNewPassword.PlaceholderText = "Новый пароль (от 12 символов)";
            txtNewPassword.Rounding = new Padding(12);
            txtNewPassword.Size = new Size(320, 40);
            txtNewPassword.TabIndex = 5;
            txtNewPassword.UnderlinedStyle = false;
            txtNewPassword.Visible = false;
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
            txtConfirmPassword.Location = new Point(332, 294);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.NormalImageTint = Color.White;
            txtConfirmPassword.OutlineColor = Color.FromArgb(95, 95, 95);
            txtConfirmPassword.Padding = new Padding(14, 12, 14, 0);
            txtConfirmPassword.PasswordChar = true;
            txtConfirmPassword.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtConfirmPassword.PlaceholderText = "Повторите новый пароль";
            txtConfirmPassword.Rounding = new Padding(12);
            txtConfirmPassword.Size = new Size(320, 40);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UnderlinedStyle = false;
            txtConfirmPassword.Visible = false;
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
            chkShowPassword.Location = new Point(336, 340);
            chkShowPassword.MinimumSize = new Size(16, 16);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.OutlineThickness = 1F;
            chkShowPassword.Rounding = 4;
            chkShowPassword.ShowSymbols = true;
            chkShowPassword.Size = new Size(170, 22);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.UncheckedForeground = Color.Empty;
            chkShowPassword.UncheckedOutlineColor = Color.Gray;
            chkShowPassword.UncheckedSymbolColor = Color.Empty;
            chkShowPassword.Visible = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = Color.White;
            btnReset.CheckButton = false;
            btnReset.Checked = false;
            btnReset.CheckedBackground = Color.Black;
            btnReset.CheckedForeColor = Color.White;
            btnReset.CheckedImageTint = Color.White;
            btnReset.CheckedOutline = Color.Black;
            btnReset.Content = "Получить код";
            btnReset.Cursor = Cursors.Hand;
            btnReset.DialogResult = DialogResult.None;
            btnReset.Font = new Font("Segoe UI", 10.5F);
            btnReset.ForeColor = Color.White;
            btnReset.HoverBackground = Color.FromArgb(40, 40, 40);
            btnReset.HoverForeColor = Color.White;
            btnReset.HoverImageTint = Color.DimGray;
            btnReset.HoverOutline = Color.Black;
            btnReset.Location = new Point(332, 166);
            btnReset.Name = "btnReset";
            btnReset.NormalBackground = Color.Black;
            btnReset.NormalForeColor = Color.White;
            btnReset.NormalImageTint = Color.Black;
            btnReset.NormalOutline = Color.Black;
            btnReset.OutlineThickness = 1F;
            btnReset.Padding = new Padding(10);
            btnReset.PressedBackground = Color.FromArgb(65, 65, 65);
            btnReset.PressedForeColor = Color.White;
            btnReset.PressedImageTint = Color.White;
            btnReset.PressedOutline = Color.Black;
            btnReset.Rounding = new Padding(20);
            btnReset.Size = new Size(154, 42);
            btnReset.TabIndex = 8;
            btnReset.TextAlignment = StringAlignment.Center;
            btnReset.TextPadding = 8;
            btnReset.TextSpacing = 2;
            btnReset.Click += BtnReset_Click;
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
            btnBack.Font = new Font("Segoe UI", 10.5F);
            btnBack.ForeColor = Color.Black;
            btnBack.HoverBackground = Color.FromArgb(242, 242, 242);
            btnBack.HoverForeColor = Color.Black;
            btnBack.HoverImageTint = Color.DimGray;
            btnBack.HoverOutline = Color.Black;
            btnBack.Location = new Point(498, 166);
            btnBack.Name = "btnBack";
            btnBack.NormalBackground = Color.White;
            btnBack.NormalForeColor = Color.Black;
            btnBack.NormalImageTint = Color.Black;
            btnBack.NormalOutline = Color.Black;
            btnBack.OutlineThickness = 1F;
            btnBack.Padding = new Padding(10);
            btnBack.PressedBackground = Color.FromArgb(230, 232, 236);
            btnBack.PressedForeColor = Color.Black;
            btnBack.PressedImageTint = Color.Black;
            btnBack.PressedOutline = Color.Black;
            btnBack.Rounding = new Padding(20);
            btnBack.Size = new Size(154, 42);
            btnBack.TabIndex = 9;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.TextPadding = 8;
            btnBack.TextSpacing = 2;
            btnBack.Click += btnBack_Click;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(185, 28, 28);
            lblError.Location = new Point(272, 222);
            lblError.Name = "lblError";
            lblError.Size = new Size(440, 36);
            lblError.TabIndex = 10;
            lblError.Text = "";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // ForgotPasswordForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(lblError);
            Controls.Add(btnBack);
            Controls.Add(btnReset);
            Controls.Add(chkShowPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCode);
            Controls.Add(lblCodeBanner);
            Controls.Add(txtEmail);
            Controls.Add(lblSub);
            Controls.Add(picLogo);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Восстановление пароля";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblSub;
        private HartUI.Controls.cuiTextBox txtEmail;
        private Label lblCodeBanner;
        private HartUI.Controls.cuiTextBox txtCode;
        private HartUI.Controls.cuiTextBox txtNewPassword;
        private HartUI.Controls.cuiTextBox txtConfirmPassword;
        private HartUI.Controls.cuiCheckbox chkShowPassword;
        private HartUI.Controls.cuiButton btnReset;
        private HartUI.Controls.cuiButton btnBack;
        private Label lblError;
        private ErrorProvider errorProvider1;
    }
}
