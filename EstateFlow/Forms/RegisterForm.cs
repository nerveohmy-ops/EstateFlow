using EstateFlow.Data;
using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class RegisterForm : BaseForm
    {
        public string RegisteredLogin { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
            cmbRole.SelectedIndex = 0;
            UiTheme.AttachPhoneMask(txtPhone);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblError.Text = "";

            string fullName = txtFullName.Content.Trim();
            string login = txtLogin.Content.Trim();
            string email = txtEmail.Content.Trim();
            string phone = txtPhone.Content.Trim();
            string password = txtPassword.Content;
            string confirm = txtConfirmPassword.Content;
            string secret = txtSecret.Content.Trim();

            Control firstField = null;
            string firstError = null;

            void AddError(Control ctrl, string msg)
            {
                if (msg == null) return;
                errorProvider1.SetError(ctrl, msg);
                if (firstField == null)
                {
                    firstField = ctrl;
                    firstError = msg;
                }
            }

            // проверка полей
            bool dbOk = UiTheme.Try(() =>
            {
                AddError(txtFullName, Validator.FullName(fullName));
                AddError(txtLogin, Validator.Login(login) ??
                    (UserService.LoginExists(login) ? "Такой логин уже занят" : null));
                AddError(txtEmail, Validator.Email(email) ??
                    (UserService.EmailExists(email) ? "Такой email уже зарегистрирован" : null));
                AddError(txtPhone, Validator.Phone(phone) ??
                    (UserService.PhoneExists(phone) ? "Такой телефон уже зарегистрирован" : null));
                AddError(txtPassword, Validator.Password(password));
                AddError(txtConfirmPassword, string.IsNullOrEmpty(confirm) ? "Повторите пароль" : Validator.PasswordRepeat(password, confirm));
                AddError(txtSecret, Validator.SecretWord(secret));

                if (cmbRole.SelectedIndex == 1 && txtInvite.Content.Trim() != AppConfig.Current.AgentInviteCode)
                {
                    AddError(txtInvite, "Неверный код сотрудника");
                }
            });
            if (!dbOk) return;

            if (firstField != null)
            {
                lblError.Text = firstError;
                toolTip1.Show(firstError, firstField, 0, firstField.Height + 4, 3500);
                return;
            }

            var user = new User
            {
                FullName = fullName,
                Login = login,
                Email = email,
                Phone = phone,
                RoleId = cmbRole.SelectedIndex == 1 ? (int)UserRole.Agent : (int)UserRole.Client,
                SecretWord = secret
            };

            if (UiTheme.Try(() => UserService.Create(user, password)))
            {
                RegisteredLogin = user.Login;
                UiTheme.Info("Регистрация успешно завершена!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isAgent = cmbRole.SelectedIndex == 1;
            txtInvite.Visible = isAgent;
            if (!isAgent) errorProvider1.SetError(txtInvite, "");
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !chkShowPassword.Checked;
            txtConfirmPassword.PasswordChar = !chkShowPassword.Checked;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
