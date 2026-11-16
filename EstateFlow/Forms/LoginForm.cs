using EstateFlow.Data;
using EstateFlow.Helpers;
using EstateFlow.Services;
using HartUI.Controls;

namespace EstateFlow.Forms
{
    public partial class LoginForm : BaseForm
    {
        protected override bool ShowThemeToggle => true;

        public LoginForm()
        {
            InitializeComponent();
            LoadRemembered();

            errorProvider1.SetIconPadding(cuiTextBox1, 6);
            errorProvider1.SetIconPadding(cuiTextBox2, 6);

            cuiTextBox1.ContentChanged += (_, _) => ClearFieldError(cuiTextBox1);
            cuiTextBox2.ContentChanged += (_, _) => ClearFieldError(cuiTextBox2);

            chkRemember.CheckedChanged += (s, e) =>
            {
                if (!chkRemember.Checked)
                    AppConfig.SaveRememberedCredentials("", "");
                else if (!string.IsNullOrWhiteSpace(cuiTextBox1.Content))
                    AppConfig.SaveRememberedCredentials(cuiTextBox1.Content.Trim(), cuiTextBox2.Content ?? "");
            };
        }

        private void ClearFieldError(Control ctrl)
        {
            if (!string.IsNullOrEmpty(errorProvider1.GetError(ctrl)))
                errorProvider1.SetError(ctrl, "");
            if (!string.IsNullOrEmpty(lblError.Text))
                lblError.Text = "";
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
            if (string.IsNullOrWhiteSpace(cuiTextBox1.Content))
                cuiTextBox1.Focus();
            else
                cuiTextBox2.Focus();
        }

        private void ApplyLocalTheme()
        {
            lblError.ForeColor = UiTheme.IsDark
                ? Color.FromArgb(255, 118, 118)
                : Color.FromArgb(185, 28, 28);

            Color linkColor = UiTheme.IsDark ? Color.FromArgb(147, 197, 253) : UiTheme.Accent;
            foreach (var lnk in new[] { lnkForgot, lnkHelp, lnkAbout })
            {
                lnk.LinkColor = linkColor;
                lnk.VisitedLinkColor = linkColor;
            }

            btnAutorization.PressedBackground = UiTheme.IsDark ? Color.FromArgb(71, 85, 105) : Color.FromArgb(226, 232, 240);
            btnAutorization.PressedForeColor = UiTheme.TextMain;
            btnAutorization.PressedOutline = UiTheme.Accent;

            btnRegister.PressedBackground = UiTheme.AccentPressed;
            btnRegister.PressedForeColor = Color.White;
            btnRegister.PressedOutline = UiTheme.AccentPressed;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                using var f = new HelpForm();
                f.ShowDialog(this);
                return true;
            }

            if (keyData == Keys.Escape)
            {
                if (!string.IsNullOrEmpty(lblError.Text)
                    || !string.IsNullOrEmpty(errorProvider1.GetError(cuiTextBox1))
                    || !string.IsNullOrEmpty(errorProvider1.GetError(cuiTextBox2)))
                {
                    errorProvider1.Clear();
                    lblError.Text = "";
                    return true;
                }
                return base.ProcessCmdKey(ref msg, keyData);
            }

            if (keyData == Keys.Enter)
            {
                if (ActiveControl is LinkLabel)
                    return base.ProcessCmdKey(ref msg, keyData);

                if (ActiveControl is cuiButton btn)
                {
                    btn.PerformClick();
                    return true;
                }

                btnAutorization_Click(this, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LoadRemembered()
        {
            var (remLogin, remPass) = AppConfig.GetRememberedCredentials();
            if (!string.IsNullOrWhiteSpace(remLogin))
            {
                cuiTextBox1.Content = remLogin;
                cuiTextBox2.Content = remPass;
                chkRemember.Checked = true;
            }
        }

        // логика кнопки вход
        private void btnAutorization_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblError.Text = "";

            string login = (cuiTextBox1.Content ?? "").Trim();
            string password = cuiTextBox2.Content ?? "";

            if (string.IsNullOrWhiteSpace(login))
            {
                errorProvider1.SetError(cuiTextBox1, "Введите логин");
                lblError.Text = "Введите логин, email или телефон";
                cuiTextBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                errorProvider1.SetError(cuiTextBox2, "Введите пароль");
                lblError.Text = "Введите пароль";
                cuiTextBox2.Focus();
                return;
            }

            Models.User user = null;
            if (!UiTheme.Try(() => user = AuthService.Authenticate(login, password)))
                return;

            if (user == null)
            {
                bool exists = false;
                UiTheme.Try(() => exists = UserService.FindByIdentity(login) != null);
                if (exists)
                {
                    errorProvider1.SetError(cuiTextBox2, "Неверный пароль");
                    lblError.Text = "Неверный пароль";
                    cuiTextBox2.Focus();
                }
                else
                {
                    errorProvider1.SetError(cuiTextBox1, "Пользователь не найден");
                    lblError.Text = "Пользователь не найден";
                    cuiTextBox1.Focus();
                    if (UiTheme.Confirm("Пользователь не найден. Перейти к регистрации?"))
                        OpenRegistration();
                }
                return;
            }

            if (chkRemember.Checked)
                AppConfig.SaveRememberedCredentials(login, password);
            else
                AppConfig.SaveRememberedCredentials("", "");

            Session.CurrentUser = user;

            using var main = new MainForm();
            main.ShowDialog(this);
            Session.Logout();

            if (!main.LogoutRequested)
            {
                Close();
            }
            else if (chkRemember.Checked)
            {
                LoadRemembered();
            }
            else
            {
                cuiTextBox2.Content = "";
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            cuiTextBox2.PasswordChar = !chkShowPassword.Checked;
        }

        private void btnRegister_Click(object sender, EventArgs e) => OpenRegistration();

        private void OpenRegistration()
        {
            using var regform = new RegisterForm();
            if (regform.ShowDialog(this) == DialogResult.OK)
            {
                errorProvider1.Clear();
                lblError.Text = "";
                cuiTextBox1.Content = regform.RegisteredLogin;
                cuiTextBox2.Content = "";
                cuiTextBox2.Focus();
            }
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var form = new ForgotPasswordForm((cuiTextBox1.Content ?? "").Trim());
            form.ShowDialog(this);
        }

        private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var form = new HelpForm();
            form.ShowDialog(this);
        }

        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var form = new AboutForm();
            form.ShowDialog(this);
        }
    }
}
