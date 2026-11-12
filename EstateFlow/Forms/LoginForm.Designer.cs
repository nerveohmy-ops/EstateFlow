namespace EstateFlow.Forms
{
    partial class LoginForm
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
            cuiTextBox1 = new HartUI.Controls.cuiTextBox();
            cuiTextBox2 = new HartUI.Controls.cuiTextBox();
            btnAutorization = new HartUI.Controls.cuiButton();
            btnRegister = new HartUI.Controls.cuiButton();
            chkShowPassword = new HartUI.Controls.cuiCheckbox();
            chkRemember = new HartUI.Controls.cuiCheckbox();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            picLogo = new PictureBox();
            lblError = new Label();
            lnkForgot = new LinkLabel();
            lnkHelp = new LinkLabel();
            lnkAbout = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.BackColor = Color.White;
            picLogo.Location = new Point(377, 32);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(220, 85);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 11;
            picLogo.TabStop = false;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.Anchor = AnchorStyles.None;
            cuiTextBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cuiTextBox1.BackColor = Color.White;
            cuiTextBox1.BackgroundColor = Color.FromArgb(245, 246, 248);
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.FocusOutlineColor = Color.Black;
            cuiTextBox1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiTextBox1.ForeColor = Color.Black;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.ImageTextSpacing = 8;
            cuiTextBox1.Location = new Point(353, 120);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.OutlineColor = Color.FromArgb(95, 95, 95);
            cuiTextBox1.Padding = new Padding(14, 12, 14, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.FromArgb(115, 115, 115);
            cuiTextBox1.PlaceholderText = "Логин, email или телефон..";
            cuiTextBox1.Rounding = new Padding(12);
            cuiTextBox1.Size = new Size(266, 44);
            cuiTextBox1.TabIndex = 1;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = false;
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.Anchor = AnchorStyles.None;
            cuiTextBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cuiTextBox2.BackColor = Color.White;
            cuiTextBox2.BackgroundColor = Color.FromArgb(245, 246, 248);
            cuiTextBox2.Content = "";
            cuiTextBox2.FocusBackgroundColor = Color.White;
            cuiTextBox2.FocusImageTint = Color.White;
            cuiTextBox2.FocusOutlineColor = Color.Black;
            cuiTextBox2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiTextBox2.ForeColor = Color.Black;
            cuiTextBox2.Image = null;
            cuiTextBox2.ImageExpand = new Point(0, 0);
            cuiTextBox2.ImageOffset = new Point(0, 0);
            cuiTextBox2.ImageTextSpacing = 8;
            cuiTextBox2.Location = new Point(353, 172);
            cuiTextBox2.Margin = new Padding(4);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.OutlineColor = Color.FromArgb(95, 95, 95);
            cuiTextBox2.Padding = new Padding(14, 12, 14, 0);
            cuiTextBox2.PasswordChar = true;
            cuiTextBox2.PlaceholderColor = Color.FromArgb(115, 115, 115);
            cuiTextBox2.PlaceholderText = "Введите пароль..";
            cuiTextBox2.Rounding = new Padding(12);
            cuiTextBox2.Size = new Size(266, 44);
            cuiTextBox2.TabIndex = 2;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = false;
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
            chkShowPassword.Location = new Point(357, 222);
            chkShowPassword.MinimumSize = new Size(16, 16);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.OutlineThickness = 1F;
            chkShowPassword.Rounding = 4;
            chkShowPassword.ShowSymbols = true;
            chkShowPassword.Size = new Size(135, 18);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.UncheckedForeground = Color.Empty;
            chkShowPassword.UncheckedOutlineColor = Color.Gray;
            chkShowPassword.UncheckedSymbolColor = Color.Empty;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // chkRemember
            // 
            chkRemember.Anchor = AnchorStyles.None;
            chkRemember.BackColor = Color.White;
            chkRemember.Checked = false;
            chkRemember.CheckedForeground = Color.Black;
            chkRemember.CheckedOutlineColor = Color.Black;
            chkRemember.CheckedSymbolColor = Color.White;
            chkRemember.Content = "Запомнить меня";
            chkRemember.Cursor = Cursors.Hand;
            chkRemember.Font = new Font("Segoe UI", 9.5F);
            chkRemember.Location = new Point(357, 246);
            chkRemember.MinimumSize = new Size(16, 16);
            chkRemember.Name = "chkRemember";
            chkRemember.OutlineThickness = 1F;
            chkRemember.Rounding = 4;
            chkRemember.ShowSymbols = true;
            chkRemember.Size = new Size(135, 18);
            chkRemember.TabIndex = 4;
            chkRemember.UncheckedForeground = Color.Empty;
            chkRemember.UncheckedOutlineColor = Color.Gray;
            chkRemember.UncheckedSymbolColor = Color.Empty;
            // 
            // lnkForgot
            // 
            lnkForgot.Anchor = AnchorStyles.None;
            lnkForgot.AutoSize = true;
            lnkForgot.BackColor = Color.White;
            lnkForgot.Font = new Font("Segoe UI", 9.5F);
            lnkForgot.LinkColor = Color.Black;
            lnkForgot.ActiveLinkColor = Color.DimGray;
            lnkForgot.Location = new Point(518, 222);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(101, 17);
            lnkForgot.TabIndex = 5;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Забыли пароль?";
            lnkForgot.LinkClicked += lnkForgot_LinkClicked;
            // 
            // btnAutorization
            // 
            btnAutorization.Anchor = AnchorStyles.None;
            btnAutorization.BackColor = Color.White;
            btnAutorization.CheckButton = false;
            btnAutorization.Checked = false;
            btnAutorization.CheckedBackground = Color.Black;
            btnAutorization.CheckedForeColor = Color.White;
            btnAutorization.CheckedImageTint = Color.White;
            btnAutorization.CheckedOutline = Color.Black;
            btnAutorization.Content = "Вход";
            btnAutorization.Cursor = Cursors.Hand;
            btnAutorization.DialogResult = DialogResult.None;
            btnAutorization.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAutorization.ForeColor = Color.Black;
            btnAutorization.HoverBackground = Color.FromArgb(242, 242, 242);
            btnAutorization.HoverForeColor = Color.Black;
            btnAutorization.HoverImageTint = Color.DimGray;
            btnAutorization.HoverOutline = Color.Black;
            btnAutorization.Image = null;
            btnAutorization.ImageExpand = new Point(0, 0);
            btnAutorization.Location = new Point(353, 274);
            btnAutorization.Name = "btnAutorization";
            btnAutorization.NormalBackground = Color.White;
            btnAutorization.NormalForeColor = Color.Black;
            btnAutorization.NormalImageTint = Color.Black;
            btnAutorization.NormalOutline = Color.Black;
            btnAutorization.OutlineThickness = 1F;
            btnAutorization.Padding = new Padding(12);
            btnAutorization.PressedBackground = Color.WhiteSmoke;
            btnAutorization.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnAutorization.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnAutorization.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnAutorization.Rounding = new Padding(20);
            btnAutorization.Size = new Size(125, 45);
            btnAutorization.TabIndex = 6;
            btnAutorization.TextAlignment = StringAlignment.Center;
            btnAutorization.TextPadding = 12;
            btnAutorization.TextSpacing = 2;
            btnAutorization.Click += btnAutorization_Click;
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
            btnRegister.ForeColor = Color.White;
            btnRegister.HoverBackground = Color.FromArgb(40, 40, 40);
            btnRegister.HoverForeColor = Color.White;
            btnRegister.HoverImageTint = Color.DimGray;
            btnRegister.HoverOutline = Color.Black;
            btnRegister.Image = null;
            btnRegister.ImageExpand = new Point(0, 0);
            btnRegister.Location = new Point(494, 274);
            btnRegister.Name = "btnRegister";
            btnRegister.NormalBackground = Color.Black;
            btnRegister.NormalForeColor = Color.White;
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
            btnRegister.TabIndex = 7;
            btnRegister.TextAlignment = StringAlignment.Center;
            btnRegister.TextPadding = 12;
            btnRegister.TextSpacing = 2;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Segoe UI", 9.5F);
            lblError.ForeColor = Color.Crimson;
            lblError.Location = new Point(320, 322);
            lblError.Margin = new Padding(4, 3, 4, 3);
            lblError.Name = "lblError";
            lblError.Size = new Size(344, 34);
            lblError.TabIndex = 8;
            lblError.Text = "";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lnkHelp
            // 
            lnkHelp.Anchor = AnchorStyles.None;
            lnkHelp.AutoSize = true;
            lnkHelp.BackColor = Color.White;
            lnkHelp.Font = new Font("Segoe UI", 9F);
            lnkHelp.LinkColor = Color.Gray;
            lnkHelp.Location = new Point(380, 365);
            lnkHelp.Name = "lnkHelp";
            lnkHelp.Size = new Size(100, 15);
            lnkHelp.TabIndex = 9;
            lnkHelp.TabStop = true;
            lnkHelp.Text = "Руководство (F1)";
            lnkHelp.LinkClicked += lnkHelp_LinkClicked;
            // 
            // lnkAbout
            // 
            lnkAbout.Anchor = AnchorStyles.None;
            lnkAbout.AutoSize = true;
            lnkAbout.BackColor = Color.White;
            lnkAbout.Font = new Font("Segoe UI", 9F);
            lnkAbout.LinkColor = Color.Gray;
            lnkAbout.Location = new Point(505, 365);
            lnkAbout.Name = "lnkAbout";
            lnkAbout.Size = new Size(85, 15);
            lnkAbout.TabIndex = 10;
            lnkAbout.TabStop = true;
            lnkAbout.Text = "О программе";
            lnkAbout.LinkClicked += lnkAbout_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(lnkAbout);
            Controls.Add(lnkHelp);
            Controls.Add(lnkForgot);
            Controls.Add(chkRemember);
            Controls.Add(chkShowPassword);
            Controls.Add(lblError);
            Controls.Add(picLogo);
            Controls.Add(btnRegister);
            Controls.Add(btnAutorization);
            Controls.Add(cuiTextBox2);
            Controls.Add(cuiTextBox1);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HartUI.Controls.cuiTextBox cuiTextBox1;
        private HartUI.Controls.cuiTextBox cuiTextBox2;
        private HartUI.Controls.cuiButton btnAutorization;
        private HartUI.Controls.cuiButton btnRegister;
        private HartUI.Controls.cuiCheckbox chkShowPassword;
        private HartUI.Controls.cuiCheckbox chkRemember;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private PictureBox picLogo;
        private Label lblError;
        private LinkLabel lnkForgot;
        private LinkLabel lnkHelp;
        private LinkLabel lnkAbout;
    }
}
