using System.Text.RegularExpressions;
using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;
using HartUI.Controls;

namespace EstateFlow.Forms
{
    public partial class RegisterForm : BaseForm
    {
        public string RegisteredLogin { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
            UiTheme.AttachPhoneMask(txtPhone);

            cuiTextBox[] fields =
            {
                txtLastName, txtFirstName, txtMiddleName, txtPhone, txtEmail,
                txtLogin, txtPassword, txtConfirmPassword, txtSecret
            };

            foreach (var tb in fields)
            {
                errorProvider1.SetIconPadding(tb, 6);
                tb.ContentChanged += (_, _) =>
                {
                    if (!string.IsNullOrEmpty(errorProvider1.GetError(tb)))
                        errorProvider1.SetError(tb, "");
                    if (!string.IsNullOrEmpty(lblError.Text))
                        lblError.Text = "";
                };
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
            txtLastName.Focus();
        }

        private void ApplyLocalTheme()
        {
            lblError.ForeColor = UiTheme.IsDark
                ? Color.FromArgb(255, 118, 118)
                : Color.FromArgb(185, 28, 28);

            btnRegister.PressedBackground = UiTheme.AccentPressed;
            btnRegister.PressedForeColor = Color.White;
            btnRegister.PressedOutline = UiTheme.AccentPressed;

            btnBack.PressedBackground = UiTheme.IsDark ? Color.FromArgb(71, 85, 105) : Color.FromArgb(226, 232, 240);
            btnBack.PressedForeColor = UiTheme.TextMain;
            btnBack.PressedOutline = UiTheme.Accent;
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

                btnRegister_Click(this, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblError.Text = "";

            string lastName = (txtLastName.Content ?? "").Trim();
            string firstName = (txtFirstName.Content ?? "").Trim();
            string middleName = (txtMiddleName.Content ?? "").Trim();
            string login = (txtLogin.Content ?? "").Trim();
            string email = (txtEmail.Content ?? "").Trim();
            string phone = (txtPhone.Content ?? "").Trim();
            string password = txtPassword.Content ?? "";
            string confirm = txtConfirmPassword.Content ?? "";
            string secret = (txtSecret.Content ?? "").Trim();

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

            string fullName = "";

            bool dbOk = UiTheme.Try(() =>
            {
                string nameErr = Validator.FullNameParts(lastName, firstName, middleName, out fullName);
                if (nameErr != null)
                {
                    Control target = string.IsNullOrWhiteSpace(lastName) ? txtLastName :
                                     string.IsNullOrWhiteSpace(firstName) ? txtFirstName :
                                     (!string.IsNullOrWhiteSpace(middleName) &&
                                      !Regex.IsMatch(middleName, @"^[А-Яа-яЁёA-Za-z\- ]+$")) ? txtMiddleName :
                                     (!Regex.IsMatch(firstName, @"^[А-Яа-яЁёA-Za-z\- ]+$") ? txtFirstName : txtLastName);
                    AddError(target, nameErr);
                }

                AddError(txtLogin, Validator.Login(login) ??
                    (UserService.LoginExists(login) ? "Такой логин уже занят" : null));
                AddError(txtEmail, Validator.Email(email) ??
                    (UserService.EmailExists(email) ? "Такой email уже зарегистрирован" : null));
                AddError(txtPhone, Validator.Phone(phone) ??
                    (UserService.PhoneExists(phone) ? "Такой телефон уже зарегистрирован" : null));
                AddError(txtPassword, Validator.Password(password));
                AddError(txtConfirmPassword, string.IsNullOrEmpty(confirm) ? "Повторите пароль" : Validator.PasswordRepeat(password, confirm));
                AddError(txtSecret, Validator.SecretWord(secret));
            });
            if (!dbOk) return;

            if (firstField != null)
            {
                lblError.Text = firstError;
                firstField.Focus();
                toolTip1.Show(firstError, firstField, 0, firstField.Height + 4, 3500);
                return;
            }

            var user = new User
            {
                FullName = fullName,
                Login = login,
                Email = email,
                Phone = phone,
                RoleId = (int)UserRole.Client,
                SecretWord = secret
            };

            if (UiTheme.Try(() => AuthService.Register(user, password)))
            {
                RegisteredLogin = user.Login;
                toolTip1.RemoveAll();
                UiTheme.Info("Регистрация успешно завершена!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !chkShowPassword.Checked;
            txtConfirmPassword.PasswordChar = !chkShowPassword.Checked;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            toolTip1.RemoveAll();
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
