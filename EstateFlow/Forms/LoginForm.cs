using EstateFlow.Helpers;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
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

        // логика кнопки вход
        private void btnAutorization_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            cuiLabel2.Content = "";

            string login = cuiTextBox1.Content.Trim();
            string password = cuiTextBox2.Content;

            if (string.IsNullOrWhiteSpace(login))
            {
                errorProvider1.SetError(cuiTextBox1, "Введите логин");
                cuiLabel2.Content = "Введите логин, email или телефон";
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                errorProvider1.SetError(cuiTextBox2, "Введите пароль");
                cuiLabel2.Content = "Введите пароль";
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
                    cuiLabel2.Content = "Неверный пароль";
                }
                else
                {
                    errorProvider1.SetError(cuiTextBox1, "Пользователь не найден");
                    cuiLabel2.Content = "Пользователь не найден";
                    if (UiTheme.Confirm("Пользователь не найден. Перейти к регистрации?"))
                        OpenRegistration();
                }
                return;
            }

            Session.CurrentUser = user;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            cuiTextBox2.PasswordChar = !chkShowPassword.Checked;
        }

        private void btnRegister_Click(object sender, EventArgs e) => OpenRegistration();

        private void OpenRegistration()
        {
            using var regform = new RegisterForm();
            Hide();
            if (regform.ShowDialog(this) == DialogResult.OK)
            {
                cuiTextBox1.Content = regform.RegisteredLogin;
                cuiTextBox2.Content = "";
            }
            Show();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var form = new ForgotPasswordForm(cuiTextBox1.Content.Trim());
            Hide();
            form.ShowDialog(this);
            Show();
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
