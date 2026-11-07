using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class UserEditForm : BaseForm
    {
        private int userId;

        public UserEditForm(int id = 0)
        {
            userId = id;
            InitializeComponent();
            UiTheme.AttachPhoneMask(txtPhone);

            if (id > 0)
            {
                Text = "Редактирование пользователя — EstateFlow";
                lblTitle.Text = "Редактирование пользователя #" + id;
                txtPassword.PlaceholderText = "Новый пароль (необязательно)";
            }

            LoadData();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            string p = PasswordHasher.Generate();
            txtPassword.Content = p;
            try { Clipboard.SetText(p); } catch { }
            UiTheme.Info($"Сгенерирован пароль: {p}\n(Скопирован в буфер обмена)");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadData()
        {
            UiTheme.Try(() =>
            {
                cmbRole.Items.Clear();
                foreach (var r in UserService.GetRoles()) cmbRole.Items.Add(r);
                if (cmbRole.Items.Count > 0) cmbRole.SelectedIndex = 0;

                if (userId > 0)
                {
                    var u = UserService.GetById(userId);
                    if (u != null)
                    {
                        txtFullName.Content = u.FullName;
                        txtLogin.Content = u.Login;
                        txtEmail.Content = u.Email;
                        txtPhone.Content = u.Phone;
                        UiTheme.SelectById(cmbRole, u.RoleId);
                        txtSecret.Content = u.SecretWord;
                    }
                }
                else
                {
                    txtPassword.Content = PasswordHasher.Generate();
                }
            });
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string fullName = (txtFullName.Content ?? "").Trim();
            string login = (txtLogin.Content ?? "").Trim();
            string email = (txtEmail.Content ?? "").Trim();
            string phone = (txtPhone.Content ?? "").Trim();
            string secret = (txtSecret.Content ?? "").Trim();
            string pass = txtPassword.Content ?? "";

            string nameErr = Validator.FullName(fullName);
            if (nameErr != null) { UiTheme.Warning(nameErr); txtFullName.Focus(); return; }

            string loginErr = Validator.Login(login);
            if (loginErr != null) { UiTheme.Warning(loginErr); txtLogin.Focus(); return; }
            if (UserService.LoginExists(login, userId))
            {
                UiTheme.Warning("Пользователь с таким логином уже существует.");
                txtLogin.Focus();
                return;
            }

            string emailErr = Validator.Email(email);
            if (emailErr != null) { UiTheme.Warning(emailErr); txtEmail.Focus(); return; }
            if (UserService.EmailExists(email, userId))
            {
                UiTheme.Warning("Пользователь с таким email уже существует.");
                txtEmail.Focus();
                return;
            }

            string phoneErr = Validator.Phone(phone);
            if (phoneErr != null) { UiTheme.Warning(phoneErr); txtPhone.Focus(); return; }
            if (UserService.PhoneExists(phone, userId))
            {
                UiTheme.Warning("Пользователь с таким номером телефона уже существует.");
                txtPhone.Focus();
                return;
            }

            var roleItem = cmbRole.SelectedItem as LookupItem;
            if (roleItem == null || roleItem.Id == 0)
            {
                UiTheme.Warning("Выберите роль пользователя.");
                cmbRole.Focus();
                return;
            }

            if (userId == 0)
            {
                string passErr = Validator.Password(pass);
                if (passErr != null) { UiTheme.Warning(passErr); txtPassword.Focus(); return; }

                var user = new User
                {
                    FullName = fullName,
                    Login = login,
                    Email = email,
                    Phone = phone,
                    RoleId = roleItem.Id,
                    SecretWord = secret
                };

                if (UiTheme.Try(() => UserService.Create(user, pass)))
                {
                    UiTheme.Info("Пользователь создан.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                var user = new User
                {
                    Id = userId,
                    FullName = fullName,
                    Login = login,
                    Email = email,
                    Phone = phone,
                    RoleId = roleItem.Id,
                    SecretWord = secret
                };

                if (UiTheme.Try(() =>
                {
                    UserService.Update(user);
                    if (!string.IsNullOrWhiteSpace(pass))
                    {
                        string passErr = Validator.Password(pass);
                        if (passErr != null) throw new InvalidOperationException(passErr);
                        UserService.ChangePassword(userId, pass);
                    }
                }))
                {
                    UiTheme.Info("Данные пользователя обновлены.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
