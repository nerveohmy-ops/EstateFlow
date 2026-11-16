using EstateFlow.Helpers;
using EstateFlow.Services;
using HartUI.Controls;

namespace EstateFlow.Forms
{
    public partial class ForgotPasswordForm : BaseForm
    {
        protected override bool ShowThemeToggle => false;

        public ForgotPasswordForm(string initialIdentity = "")
        {
            InitializeComponent();
            txtIdentity.Content = initialIdentity ?? "";

            errorProvider1.SetIconPadding(txtIdentity, 6);
            errorProvider1.SetIconPadding(txtSecret, 6);

            txtIdentity.ContentChanged += (_, _) => ClearFieldError(txtIdentity);
            txtSecret.ContentChanged += (_, _) => ClearFieldError(txtSecret);
        }

        private void ClearFieldError(Control ctrl)
        {
            if (!string.IsNullOrEmpty(errorProvider1.GetError(ctrl)))
                errorProvider1.SetError(ctrl, "");
            if (!string.IsNullOrEmpty(lblError.Text) || lblError.Visible)
            {
                lblError.Text = "";
                lblError.Visible = false;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyLocalTheme();
        }

        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();
            ApplyLocalTheme();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (!string.IsNullOrWhiteSpace(txtIdentity.Content))
                txtSecret.Focus();
            else
                txtIdentity.Focus();
        }

        private void ApplyLocalTheme()
        {
            lblError.ForeColor = UiTheme.IsDark
                ? Color.FromArgb(255, 118, 118)
                : Color.FromArgb(185, 28, 28);

            lblResult.BackColor = UiTheme.CardBg;
            lblResult.ForeColor = UiTheme.TextMain;

            btnReset.NormalBackground = UiTheme.Accent;
            btnReset.NormalForeColor = Color.White;
            btnReset.NormalOutline = UiTheme.Accent;
            btnReset.HoverBackground = UiTheme.AccentHover;
            btnReset.HoverForeColor = Color.White;
            btnReset.HoverOutline = UiTheme.AccentHover;
            btnReset.PressedBackground = UiTheme.AccentPressed;
            btnReset.PressedForeColor = Color.White;
            btnReset.PressedOutline = UiTheme.AccentPressed;

            btnBack.PressedBackground = UiTheme.IsDark ? Color.FromArgb(71, 85, 105) : Color.FromArgb(226, 232, 240);
            btnBack.PressedForeColor = UiTheme.TextMain;
            btnBack.PressedOutline = UiTheme.Accent;
            btnReset.Invalidate();
            btnBack.Invalidate();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                btnBack_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.Enter)
            {
                if (ActiveControl is cuiButton btn)
                {
                    btn.PerformClick();
                    return true;
                }

                BtnReset_Click(this, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblError.Text = "";
            lblError.Visible = false;
            lblResult.Visible = false;
            lblResult.Text = "";

            string id = (txtIdentity.Content ?? "").Trim();
            string secret = (txtSecret.Content ?? "").Trim();

            if (string.IsNullOrEmpty(id))
            {
                const string msg = "Введите логин, email или телефон";
                errorProvider1.SetError(txtIdentity, msg);
                lblError.Text = msg;
                lblError.Visible = true;
                lblError.BringToFront();
                txtIdentity.Focus();
                return;
            }
            if (string.IsNullOrEmpty(secret))
            {
                const string msg = "Введите секретное слово";
                errorProvider1.SetError(txtSecret, msg);
                lblError.Text = msg;
                lblError.Visible = true;
                lblError.BringToFront();
                txtSecret.Focus();
                return;
            }

            string error = null;
            string newPass = null;
            bool sent = false;
            string email = null;

            if (!UiTheme.Try(() => error = AuthService.ResetPassword(id, secret, out newPass, out sent, out email)))
                return;

            if (error != null)
            {
                Control errCtrl = error.Contains("Пользователь", StringComparison.OrdinalIgnoreCase)
                    ? txtIdentity
                    : txtSecret;
                errorProvider1.SetError(errCtrl, error);
                lblError.Text = error;
                lblError.Visible = true;
                lblError.BringToFront();
                errCtrl.Focus();
                UiTheme.Warning(error);
                return;
            }

            lblError.Text = "";
            lblError.Visible = false;
            lblResult.Text = sent
                ? $"Новый пароль отправлен на {email}\nВременный пароль: {newPass}\n(скопирован в буфер обмена)"
                : $"Ваш новый пароль: {newPass}\n(скопирован в буфер обмена, смените его в профиле)";
            lblResult.Visible = true;
            lblResult.BringToFront();

            try { Clipboard.SetText(newPass); } catch { }
        }
    }
}
