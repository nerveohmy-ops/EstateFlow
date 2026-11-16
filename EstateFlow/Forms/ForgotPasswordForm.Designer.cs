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
            txtIdentity = new HartUI.Controls.cuiTextBox();
            txtSecret = new HartUI.Controls.cuiTextBox();
            btnReset = new HartUI.Controls.cuiButton();
            btnBack = new HartUI.Controls.cuiButton();
            lblError = new Label();
            lblResult = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.BackColor = Color.Transparent;
            picLogo.Location = new Point(382, 28);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(220, 64);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblSub
            // 
            lblSub.Anchor = AnchorStyles.None;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 10F);
            lblSub.ForeColor = Color.DimGray;
            lblSub.Location = new Point(350, 98);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(284, 24);
            lblSub.TabIndex = 1;
            lblSub.Text = "Восстановление пароля";
            lblSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIdentity
            // 
            txtIdentity.Anchor = AnchorStyles.None;
            txtIdentity.BackColor = Color.White;
            txtIdentity.FocusBackgroundColor = Color.White;
            txtIdentity.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtIdentity.Content = "";
            txtIdentity.FocusImageTint = Color.White;
            txtIdentity.FocusOutlineColor = Color.Black;
            txtIdentity.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdentity.ForeColor = Color.Black;
            txtIdentity.Location = new Point(352, 134);
            txtIdentity.Name = "txtIdentity";
            txtIdentity.NormalImageTint = Color.White;
            txtIdentity.OutlineColor = Color.FromArgb(95, 95, 95);
            txtIdentity.Padding = new Padding(14, 13, 14, 0);
            txtIdentity.PasswordChar = false;
            txtIdentity.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtIdentity.PlaceholderText = "Логин, email или телефон..";
            txtIdentity.Rounding = new Padding(12);
            txtIdentity.Size = new Size(280, 44);
            txtIdentity.TabIndex = 2;
            txtIdentity.UnderlinedStyle = false;
            // 
            // txtSecret
            // 
            txtSecret.Anchor = AnchorStyles.None;
            txtSecret.BackColor = Color.White;
            txtSecret.FocusBackgroundColor = Color.White;
            txtSecret.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtSecret.Content = "";
            txtSecret.FocusImageTint = Color.White;
            txtSecret.FocusOutlineColor = Color.Black;
            txtSecret.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecret.ForeColor = Color.Black;
            txtSecret.Location = new Point(352, 188);
            txtSecret.Name = "txtSecret";
            txtSecret.NormalImageTint = Color.White;
            txtSecret.OutlineColor = Color.FromArgb(95, 95, 95);
            txtSecret.Padding = new Padding(14, 13, 14, 0);
            txtSecret.PasswordChar = false;
            txtSecret.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtSecret.PlaceholderText = "Секретное слово..";
            txtSecret.Rounding = new Padding(12);
            txtSecret.Size = new Size(280, 44);
            txtSecret.TabIndex = 3;
            txtSecret.UnderlinedStyle = false;
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
            btnReset.Content = "Сбросить";
            btnReset.Cursor = Cursors.Hand;
            btnReset.DialogResult = DialogResult.None;
            btnReset.Font = new Font("Segoe UI", 11.5F);
            btnReset.ForeColor = Color.White;
            btnReset.HoverBackground = Color.FromArgb(40, 40, 40);
            btnReset.HoverForeColor = Color.White;
            btnReset.HoverImageTint = Color.DimGray;
            btnReset.HoverOutline = Color.Black;
            btnReset.Location = new Point(352, 248);
            btnReset.Name = "btnReset";
            btnReset.NormalBackground = Color.Black;
            btnReset.NormalForeColor = Color.White;
            btnReset.NormalImageTint = Color.Black;
            btnReset.NormalOutline = Color.Black;
            btnReset.OutlineThickness = 1F;
            btnReset.Padding = new Padding(12);
            btnReset.PressedBackground = Color.FromArgb(65, 65, 65);
            btnReset.PressedForeColor = Color.White;
            btnReset.PressedImageTint = Color.White;
            btnReset.PressedOutline = Color.Black;
            btnReset.Rounding = new Padding(20);
            btnReset.Size = new Size(134, 45);
            btnReset.TabIndex = 4;
            btnReset.TextAlignment = StringAlignment.Center;
            btnReset.TextPadding = 10;
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
            btnBack.Font = new Font("Segoe UI", 11.5F);
            btnBack.ForeColor = Color.Black;
            btnBack.HoverBackground = Color.FromArgb(242, 242, 242);
            btnBack.HoverForeColor = Color.Black;
            btnBack.HoverImageTint = Color.DimGray;
            btnBack.HoverOutline = Color.Black;
            btnBack.Location = new Point(498, 248);
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
            btnBack.Size = new Size(134, 45);
            btnBack.TabIndex = 5;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.TextPadding = 10;
            btnBack.TextSpacing = 2;
            btnBack.Click += btnBack_Click;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(185, 28, 28);
            lblError.Location = new Point(292, 304);
            lblError.Name = "lblError";
            lblError.Size = new Size(400, 40);
            lblError.TabIndex = 6;
            lblError.Text = "";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.None;
            lblResult.BackColor = Color.White;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 9.5F);
            lblResult.ForeColor = Color.Black;
            lblResult.Location = new Point(272, 308);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(12, 8, 12, 8);
            lblResult.Size = new Size(440, 96);
            lblResult.TabIndex = 7;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
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
            Controls.Add(lblError);
            Controls.Add(btnBack);
            Controls.Add(btnReset);
            Controls.Add(txtSecret);
            Controls.Add(txtIdentity);
            Controls.Add(lblSub);
            Controls.Add(picLogo);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Восстановление пароля";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblSub;
        private HartUI.Controls.cuiTextBox txtIdentity;
        private HartUI.Controls.cuiTextBox txtSecret;
        private HartUI.Controls.cuiButton btnReset;
        private HartUI.Controls.cuiButton btnBack;
        private Label lblError;
        private Label lblResult;
        private ErrorProvider errorProvider1;
    }
}
