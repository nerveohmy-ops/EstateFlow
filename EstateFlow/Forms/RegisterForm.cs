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
                txtLogin, txtPassword, txtConfirmPassword
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

            if (UiTheme.IsDark)
            {
                btnRegister.PressedBackground = Color.FromArgb(205, 208, 216);
                btnRegister.PressedForeColor = Color.Black;
                btnRegister.PressedOutline = Color.White;

                btnBack.PressedBackground = Color.FromArgb(62, 65, 74);
                btnBack.PressedForeColor = Color.White;
                btnBack.PressedOutline = Color.FromArgb(180, 180, 185);
            }
            else
            {
                btnRegister.PressedBackground = Color.FromArgb(65, 65, 65);
                btnRegister.PressedForeColor = Color.White;
                btnRegister.PressedOutline = Color.Black;

                btnBack.PressedBackground = Color.FromArgb(230, 232, 236);
                btnBack.PressedForeColor = Color.Black;
                btnBack.PressedOutline = Color.Black;
            }
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
                RoleId = (int)UserRole.Client
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
