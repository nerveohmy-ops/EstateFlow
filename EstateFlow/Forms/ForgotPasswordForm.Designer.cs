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
            lblBrand = new Label();
            lblSub = new Label();
            txtIdentity = new HartUI.Controls.cuiTextBox();
            txtSecret = new HartUI.Controls.cuiTextBox();
            btnReset = new HartUI.Controls.cuiButton();
            btnBack = new HartUI.Controls.cuiButton();
            lblResult = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblBrand
            // 
            lblBrand.Anchor = AnchorStyles.None;
            lblBrand.AutoSize = true;
            lblBrand.BackColor = Color.White;
            lblBrand.Font = new Font("Microsoft Sans Serif", 20.25F);
            lblBrand.Location = new Point(412, 70);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(150, 31);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "EstateFlow";
            // 
            // lblSub
            // 
            lblSub.Anchor = AnchorStyles.None;
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.White;
            lblSub.Font = new Font("Segoe UI", 10F);
            lblSub.ForeColor = Color.DimGray;
            lblSub.Location = new Point(404, 108);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(168, 19);
            lblSub.TabIndex = 1;
            lblSub.Text = "Восстановление пароля";
            // 
            // txtIdentity
            // 
            txtIdentity.Anchor = AnchorStyles.None;
            txtIdentity.BackColor = Color.White;
            txtIdentity.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtIdentity.Content = "";
            txtIdentity.FocusBackgroundColor = Color.White;
            txtIdentity.FocusImageTint = Color.White;
            txtIdentity.FocusOutlineColor = Color.Black;
            txtIdentity.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdentity.ForeColor = Color.Black;
            txtIdentity.Location = new Point(353, 140);
            txtIdentity.Name = "txtIdentity";
            txtIdentity.NormalImageTint = Color.White;
            txtIdentity.OutlineColor = Color.FromArgb(95, 95, 95);
            txtIdentity.Padding = new Padding(16, 14, 16, 0);
            txtIdentity.PasswordChar = false;
            txtIdentity.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtIdentity.PlaceholderText = "Логин, email или телефон..";
            txtIdentity.Rounding = new Padding(12);
            txtIdentity.Size = new Size(266, 45);
            txtIdentity.TabIndex = 2;
            txtIdentity.UnderlinedStyle = false;
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
            txtSecret.Location = new Point(353, 195);
            txtSecret.Name = "txtSecret";
            txtSecret.NormalImageTint = Color.White;
            txtSecret.OutlineColor = Color.FromArgb(95, 95, 95);
            txtSecret.Padding = new Padding(16, 14, 16, 0);
            txtSecret.PasswordChar = false;
            txtSecret.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtSecret.PlaceholderText = "Секретное слово..";
            txtSecret.Rounding = new Padding(12);
            txtSecret.Size = new Size(266, 45);
            txtSecret.TabIndex = 3;
            txtSecret.UnderlinedStyle = false;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = Color.White;
            btnReset.CheckButton = false;
            btnReset.Checked = false;
            btnReset.Content = "Сбросить";
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 10.5F);
            btnReset.ForeColor = Color.Black;
            btnReset.HoverBackground = Color.White;
            btnReset.HoverForeColor = Color.DimGray;
            btnReset.HoverOutline = Color.Black;
            btnReset.Location = new Point(353, 252);
            btnReset.Name = "btnReset";
            btnReset.NormalBackground = Color.White;
            btnReset.NormalForeColor = Color.Black;
            btnReset.NormalOutline = Color.Black;
            btnReset.OutlineThickness = 1F;
            btnReset.Padding = new Padding(12);
            btnReset.PressedBackground = Color.WhiteSmoke;
            btnReset.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnReset.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnReset.Rounding = new Padding(20);
            btnReset.Size = new Size(125, 45);
            btnReset.TabIndex = 4;
            btnReset.TextAlignment = StringAlignment.Center;
            btnReset.Click += BtnReset_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.White;
            btnBack.CheckButton = false;
            btnBack.Checked = false;
            btnBack.Content = "Назад";
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 10.5F);
            btnBack.ForeColor = Color.White;
            btnBack.HoverBackground = Color.FromArgb(40, 40, 40);
            btnBack.HoverForeColor = Color.White;
            btnBack.HoverOutline = Color.Black;
            btnBack.Location = new Point(494, 252);
            btnBack.Name = "btnBack";
            btnBack.NormalBackground = Color.Black;
            btnBack.NormalForeColor = Color.White;
            btnBack.NormalOutline = Color.Black;
            btnBack.OutlineThickness = 1F;
            btnBack.Padding = new Padding(12);
            btnBack.PressedBackground = Color.WhiteSmoke;
            btnBack.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnBack.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnBack.Rounding = new Padding(20);
            btnBack.Size = new Size(125, 45);
            btnBack.TabIndex = 5;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.Click += btnBack_Click;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.None;
            lblResult.BackColor = Color.White;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 9.5F);
            lblResult.ForeColor = Color.Black;
            lblResult.Location = new Point(320, 310);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(8);
            lblResult.Size = new Size(335, 90);
            lblResult.TabIndex = 6;
            lblResult.Visible = false;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // ForgotPasswordForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(lblResult);
            Controls.Add(btnBack);
            Controls.Add(btnReset);
            Controls.Add(txtSecret);
            Controls.Add(txtIdentity);
            Controls.Add(lblSub);
            Controls.Add(lblBrand);
            DoubleBuffered = true;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Восстановление пароля";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrand;
        private Label lblSub;
        private HartUI.Controls.cuiTextBox txtIdentity;
        private HartUI.Controls.cuiTextBox txtSecret;
        private HartUI.Controls.cuiButton btnReset;
        private HartUI.Controls.cuiButton btnBack;
        private Label lblResult;
        private ErrorProvider errorProvider1;
    }
}
