using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class ProfileForm : BaseForm
    {
        public ProfileForm()
        {
            InitializeComponent();
            UiTheme.AttachPhoneMask(txtPhone);
            if (Session.CurrentUser != null)
            {
                lblTitle.Text = $"Личный кабинет ({Session.CurrentUser.RoleName})";
                LoadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LoadData()
        {
            var u = Session.CurrentUser;
            txtFullName.Content = u.FullName;
            txtLogin.Content = u.Login;
            txtEmail.Content = u.Email;
            txtPhone.Content = u.Phone;
            txtSecret.Content = u.SecretWord;
        }

        private void BtnSaveProfile_Click(object sender, EventArgs e)
        {
            string fullName = (txtFullName.Content ?? "").Trim();
            string email = (txtEmail.Content ?? "").Trim();
            string phone = (txtPhone.Content ?? "").Trim();
            string secret = (txtSecret.Content ?? "").Trim();

            string nameErr = Validator.FullName(fullName);
            if (nameErr != null) { UiTheme.Warning(nameErr); txtFullName.Focus(); return; }

            string emailErr = Validator.Email(email);
            if (emailErr != null) { UiTheme.Warning(emailErr); txtEmail.Focus(); return; }
            if (UserService.EmailExists(email, Session.CurrentUser.Id))
            {
                UiTheme.Warning("Пользователь с таким email уже зарегистрирован.");
                txtEmail.Focus();
                return;
            }

            string phoneErr = Validator.Phone(phone);
            if (phoneErr != null) { UiTheme.Warning(phoneErr); txtPhone.Focus(); return; }
            if (UserService.PhoneExists(phone, Session.CurrentUser.Id))
            {
                UiTheme.Warning("Пользователь с таким номером телефона уже существует.");
                txtPhone.Focus();
                return;
            }

            string secretErr = Validator.SecretWord(secret);
            if (secretErr != null) { UiTheme.Warning(secretErr); txtSecret.Focus(); return; }

            var updated = new User
            {
                Id = Session.CurrentUser.Id,
                Login = Session.CurrentUser.Login,
                RoleId = Session.CurrentUser.RoleId,
                RoleName = Session.CurrentUser.RoleName,
                FullName = fullName,
                Email = email,
                Phone = phone,
                SecretWord = secret
            };

            if (UiTheme.Try(() => UserService.Update(updated)))
            {
                Session.CurrentUser.FullName = updated.FullName;
                Session.CurrentUser.Email = updated.Email;
                Session.CurrentUser.Phone = updated.Phone;
                Session.CurrentUser.SecretWord = updated.SecretWord;
                UiTheme.Info("Данные профиля обновлены.");
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            string oldP = txtOldPassword.Content ?? "";
            string newP = txtNewPassword.Content ?? "";
            string repP = txtRepeatPassword.Content ?? "";

            if (string.IsNullOrEmpty(oldP))
            {
                UiTheme.Warning("Введите текущий пароль.");
                txtOldPassword.Focus();
                return;
            }

            if (!PasswordHasher.Verify(oldP, Session.CurrentUser.PasswordHash))
            {
                UiTheme.Warning("Текущий пароль указан неверно.");
                txtOldPassword.Focus();
                return;
            }

            string passErr = Validator.Password(newP);
            if (passErr != null)
            {
                UiTheme.Warning(passErr);
                txtNewPassword.Focus();
                return;
            }

            string repErr = Validator.PasswordRepeat(newP, repP);
            if (repErr != null)
            {
                UiTheme.Warning(repErr);
                txtRepeatPassword.Focus();
                return;
            }

            if (UiTheme.Try(() =>
            {
                UserService.ChangePassword(Session.CurrentUser.Id, newP);
                Session.CurrentUser.PasswordHash = PasswordHasher.Hash(newP);
            }))
            {
                txtOldPassword.Content = "";
                txtNewPassword.Content = "";
                txtRepeatPassword.Content = "";
                UiTheme.Info("Пароль изменён.");
            }
        }
    }
}
