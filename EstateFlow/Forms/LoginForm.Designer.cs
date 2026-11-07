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
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            cuiLabel2 = new HartUI.Controls.cuiLabel();
            lnkForgot = new LinkLabel();
            lnkHelp = new LinkLabel();
            lnkAbout = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(412, 74);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 0;
            label1.Text = "EstateFlow";
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.Anchor = AnchorStyles.None;
            cuiTextBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cuiTextBox1.BackColor = Color.White;
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.FocusOutlineColor = Color.Black;
            cuiTextBox1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            cuiTextBox1.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox1.Padding = new Padding(16, 14, 16, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.LightGray;
            cuiTextBox1.PlaceholderText = "Логин, email или телефон..";
            cuiTextBox1.Rounding = new Padding(20);
            cuiTextBox1.Size = new Size(266, 45);
            cuiTextBox1.TabIndex = 1;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = true;
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.Anchor = AnchorStyles.None;
            cuiTextBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cuiTextBox2.BackColor = Color.White;
            cuiTextBox2.BackgroundColor = Color.White;
            cuiTextBox2.Content = "";
            cuiTextBox2.FocusBackgroundColor = Color.White;
            cuiTextBox2.FocusImageTint = Color.White;
            cuiTextBox2.FocusOutlineColor = Color.Black;
            cuiTextBox2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox2.ForeColor = Color.Black;
            cuiTextBox2.Image = null;
            cuiTextBox2.ImageExpand = new Point(0, 0);
            cuiTextBox2.ImageOffset = new Point(0, 0);
            cuiTextBox2.ImageTextSpacing = 8;
            cuiTextBox2.Location = new Point(353, 173);
            cuiTextBox2.Margin = new Padding(4);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox2.Padding = new Padding(16, 14, 16, 0);
            cuiTextBox2.PasswordChar = true;
            cuiTextBox2.PlaceholderColor = Color.LightGray;
            cuiTextBox2.PlaceholderText = "Введите пароль..";
            cuiTextBox2.Rounding = new Padding(20);
            cuiTextBox2.Size = new Size(266, 45);
            cuiTextBox2.TabIndex = 2;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = true;
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
            chkShowPassword.Location = new Point(357, 224);
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
            // lnkForgot
            // 
            lnkForgot.Anchor = AnchorStyles.None;
            lnkForgot.AutoSize = true;
            lnkForgot.BackColor = Color.White;
            lnkForgot.Font = new Font("Segoe UI", 9.5F);
            lnkForgot.LinkColor = Color.Black;
            lnkForgot.ActiveLinkColor = Color.DimGray;
            lnkForgot.Location = new Point(518, 224);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(101, 17);
            lnkForgot.TabIndex = 4;
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
            btnAutorization.HoverBackground = Color.White;
            btnAutorization.HoverForeColor = Color.DimGray;
            btnAutorization.HoverImageTint = Color.DimGray;
            btnAutorization.HoverOutline = Color.Black;
            btnAutorization.Image = null;
            btnAutorization.ImageExpand = new Point(0, 0);
            btnAutorization.Location = new Point(353, 252);
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
            btnAutorization.TabIndex = 5;
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
            btnRegister.HoverBackground = Color.White;
            btnRegister.HoverForeColor = Color.DimGray;
            btnRegister.HoverImageTint = Color.DimGray;
            btnRegister.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRegister.Image = null;
            btnRegister.ImageExpand = new Point(0, 0);
            btnRegister.Location = new Point(494, 252);
            btnRegister.Name = "btnRegister";
            btnRegister.NormalBackground = Color.Black;
            btnRegister.NormalForeColor = Color.White;
            btnRegister.NormalImageTint = Color.Black;
            btnRegister.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegister.OutlineThickness = 1F;
            btnRegister.Padding = new Padding(12);
            btnRegister.PressedBackground = Color.WhiteSmoke;
            btnRegister.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRegister.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRegister.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegister.Rounding = new Padding(20);
            btnRegister.Size = new Size(125, 45);
            btnRegister.TabIndex = 6;
            btnRegister.TextAlignment = StringAlignment.Center;
            btnRegister.TextPadding = 12;
            btnRegister.TextSpacing = 2;
            btnRegister.Click += btnRegister_Click;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Anchor = AnchorStyles.None;
            cuiLabel2.BackColor = Color.White;
            cuiLabel2.Content = "";
            cuiLabel2.Font = new Font("Segoe UI", 9.5F);
            cuiLabel2.ForeColor = Color.DarkRed;
            cuiLabel2.Location = new Point(353, 305);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(266, 40);
            cuiLabel2.TabIndex = 7;
            cuiLabel2.TabStop = false;
            // 
            // lnkHelp
            // 
            lnkHelp.Anchor = AnchorStyles.None;
            lnkHelp.AutoSize = true;
            lnkHelp.BackColor = Color.White;
            lnkHelp.Font = new Font("Segoe UI", 9F);
            lnkHelp.LinkColor = Color.Gray;
            lnkHelp.Location = new Point(380, 355);
            lnkHelp.Name = "lnkHelp";
            lnkHelp.Size = new Size(100, 15);
            lnkHelp.TabIndex = 8;
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
            lnkAbout.Location = new Point(505, 355);
            lnkAbout.Name = "lnkAbout";
            lnkAbout.Size = new Size(85, 15);
            lnkAbout.TabIndex = 9;
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
            Controls.Add(chkShowPassword);
            Controls.Add(cuiLabel2);
            Controls.Add(label1);
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
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private Label label1;
        private HartUI.Controls.cuiLabel cuiLabel2;
        private LinkLabel lnkForgot;
        private LinkLabel lnkHelp;
        private LinkLabel lnkAbout;
    }
}
