using EstateFlow.Helpers;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class ForgotPasswordForm : BaseForm
    {
        protected override bool ShowThemeToggle => false;

        public ForgotPasswordForm(string initialIdentity = "")
        {
            InitializeComponent();
            txtIdentity.Content = initialIdentity ?? "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string id = (txtIdentity.Content ?? "").Trim();
            string secret = (txtSecret.Content ?? "").Trim();

            if (string.IsNullOrEmpty(id))
            {
                errorProvider1.SetError(txtIdentity, "Введите логин, email или телефон");
                return;
            }
            if (string.IsNullOrEmpty(secret))
            {
                errorProvider1.SetError(txtSecret, "Введите секретное слово");
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
                errorProvider1.SetError(txtSecret, error);
                UiTheme.Warning(error);
                return;
            }

            lblResult.Visible = true;
            lblResult.Text = sent
                ? $"Новый пароль отправлен на {email}\nВременный пароль: {newPass}\n(скопирован в буфер обмена)"
                : $"Ваш новый пароль: {newPass}\n(скопирован в буфер обмена, смените его в профиле)";

            try { Clipboard.SetText(newPass); } catch { }
        }
    }
}
