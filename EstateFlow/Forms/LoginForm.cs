using EstateFlow.Data;
using EstateFlow.Helpers;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class LoginForm : BaseForm
    {
        protected override bool ShowThemeToggle => true;

        public LoginForm()
        {
            InitializeComponent();
            LoadRemembered();

            chkRemember.CheckedChanged += (s, e) =>
            {
                if (!chkRemember.Checked)
                    AppConfig.SaveRememberedCredentials("", "");
                else if (!string.IsNullOrWhiteSpace(cuiTextBox1.Content))
                    AppConfig.SaveRememberedCredentials(cuiTextBox1.Content.Trim(), cuiTextBox2.Content);
            };

            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F1)
                {
                    using var f = new HelpForm();
                    f.ShowDialog(this);
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    btnAutorization_Click(this, EventArgs.Empty);
                }
            };
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

            string login = cuiTextBox1.Content.Trim();
            string password = cuiTextBox2.Content;

            if (string.IsNullOrWhiteSpace(login))
            {
                errorProvider1.SetError(cuiTextBox1, "Введите логин");
                lblError.Text = "Введите логин, email или телефон";
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                errorProvider1.SetError(cuiTextBox2, "Введите пароль");
                lblError.Text = "Введите пароль";
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
                }
                else
                {
                    errorProvider1.SetError(cuiTextBox1, "Пользователь не найден");
                    lblError.Text = "Пользователь не найден";
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
                cuiTextBox1.Content = regform.RegisteredLogin;
                cuiTextBox2.Content = "";
            }
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var form = new ForgotPasswordForm(cuiTextBox1.Content.Trim());
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
