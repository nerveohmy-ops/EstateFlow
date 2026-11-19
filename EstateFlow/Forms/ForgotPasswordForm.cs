using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;
using HartUI.Controls;

namespace EstateFlow.Forms
{
    public partial class ForgotPasswordForm : BaseForm
    {
        protected override bool ShowThemeToggle => false;

        private enum RecoveryStage
        {
            EnterEmail,
            EnterCode,
            SetPassword
        }

        private RecoveryStage stage = RecoveryStage.EnterEmail;
        private string expectedCode = "";
        private User matchedUser;
        private bool smtpSent = false;

        public ForgotPasswordForm(string initialEmail = "")
        {
            InitializeComponent();
            UiTheme.AttachIntMask(txtCode, 6);

            if (!string.IsNullOrWhiteSpace(initialEmail) && initialEmail.Contains('@'))
                txtEmail.Content = initialEmail.Trim();

            foreach (var tb in new[] { txtEmail, txtCode, txtNewPassword, txtConfirmPassword })
                errorProvider1.SetIconPadding(tb, 6);

            txtEmail.ContentChanged += (_, _) =>
            {
                ClearError(txtEmail);
                if (stage != RecoveryStage.EnterEmail)
                    ResetToEmailStage();
            };

            txtCode.ContentChanged += (_, _) =>
            {
                ClearError(txtCode);
                if (stage == RecoveryStage.EnterCode && !string.IsNullOrEmpty(expectedCode))
                {
                    string entered = (txtCode.Content ?? "").Trim();
                    if (entered == expectedCode)
                    {
                        AdvanceToPasswordStage();
                    }
                    else if (entered.Length == 6)
                    {
                        ShowError(txtCode, "Неверный 6-значный код подтверждения");
                    }
                }
            };

            txtNewPassword.ContentChanged += (_, _) => ClearError(txtNewPassword);
            txtConfirmPassword.ContentChanged += (_, _) => ClearError(txtConfirmPassword);

            UpdateStageUi();
        }

        private void ClearError(Control ctrl)
        {
            if (!string.IsNullOrEmpty(errorProvider1.GetError(ctrl)))
                errorProvider1.SetError(ctrl, "");
            if (!string.IsNullOrEmpty(lblError.Text) || lblError.Visible)
            {
                lblError.Text = "";
                lblError.Visible = false;
            }
        }

        private void ShowError(Control ctrl, string msg)
        {
            errorProvider1.SetError(ctrl, msg);
            lblError.Text = msg;
            lblError.Visible = true;
            lblError.BringToFront();
        }

        private void ResetToEmailStage()
        {
            stage = RecoveryStage.EnterEmail;
            expectedCode = "";
            matchedUser = null;
            smtpSent = false;
            txtCode.Content = "";
            txtNewPassword.Content = "";
            txtConfirmPassword.Content = "";
            UiTheme.SetTextBoxReadOnly(txtCode, false);
            UpdateStageUi();
        }

        private void AdvanceToPasswordStage()
        {
            ClearError(txtCode);
            stage = RecoveryStage.SetPassword;
            UiTheme.SetTextBoxReadOnly(txtCode, true);
            UpdateStageUi();
            txtNewPassword.Focus();
        }

        private void UpdateStageUi()
        {
            int cx = (ClientSize.Width - 320) / 2;
            int errX = (ClientSize.Width - 440) / 2;

            if (stage == RecoveryStage.EnterEmail)
            {
                lblCodeBanner.Visible = false;
                txtCode.Visible = false;
                txtNewPassword.Visible = false;
                txtConfirmPassword.Visible = false;
                chkShowPassword.Visible = false;

                btnReset.Content = "Получить код";
                btnReset.Location = new Point(cx, 166);
                btnBack.Location = new Point(cx + 166, 166);
                lblError.Location = new Point(errX, 222);
            }
            else if (stage == RecoveryStage.EnterCode)
            {
                lblCodeBanner.Visible = true;
                lblCodeBanner.Location = new Point(cx, 158);
                lblCodeBanner.Size = new Size(320, 42);
                lblCodeBanner.Text = smtpSent
                    ? $"Код отправлен на почту: {expectedCode}\n(скопирован в буфер обмена)"
                    : $"Код подтверждения: {expectedCode}\n(скопирован в буфер — введите ниже)";

                txtCode.Visible = true;
                txtCode.Location = new Point(cx, 208);
                txtNewPassword.Visible = false;
                txtConfirmPassword.Visible = false;
                chkShowPassword.Visible = false;

                btnReset.Content = "Проверить код";
                btnReset.Location = new Point(cx, 264);
                btnBack.Location = new Point(cx + 166, 264);
                lblError.Location = new Point(errX, 318);
            }
            else
            {
                lblCodeBanner.Visible = true;
                lblCodeBanner.Location = new Point(cx, 158);
                lblCodeBanner.Size = new Size(320, 30);
                lblCodeBanner.Text = "✓ Код подтверждён — задайте новый пароль";

                txtCode.Visible = true;
                txtCode.Location = new Point(cx, 196);

                txtNewPassword.Visible = true;
                txtNewPassword.Location = new Point(cx, 246);

                txtConfirmPassword.Visible = true;
                txtConfirmPassword.Location = new Point(cx, 294);

                chkShowPassword.Visible = true;
                chkShowPassword.Location = new Point(cx + 4, 340);

                btnReset.Content = "Сменить пароль";
                btnReset.Location = new Point(cx, 368);
                btnBack.Location = new Point(cx + 166, 368);
                lblError.Location = new Point(errX, 416);
            }

            ApplyLocalTheme();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateStageUi();
        }

        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();
            ApplyLocalTheme();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtEmail.Focus();
        }

        private void ApplyLocalTheme()
        {
            lblError.ForeColor = UiTheme.ErrorText;

            lblCodeBanner.BackColor = UiTheme.CardBg;
            lblCodeBanner.ForeColor = stage == RecoveryStage.SetPassword
                ? (UiTheme.IsDark ? Color.FromArgb(110, 231, 183) : Color.FromArgb(5, 150, 105))
                : UiTheme.TextMain;

            if (UiTheme.IsDark)
            {
                btnReset.NormalBackground = Color.FromArgb(240, 240, 245);
                btnReset.NormalForeColor = Color.Black;
                btnReset.NormalOutline = Color.White;
                btnReset.HoverBackground = Color.White;
                btnReset.HoverForeColor = Color.Black;
                btnReset.HoverOutline = Color.White;
                btnReset.PressedBackground = Color.FromArgb(205, 208, 216);
                btnReset.PressedForeColor = Color.Black;
                btnReset.PressedOutline = Color.White;

                btnBack.PressedBackground = Color.FromArgb(62, 65, 74);
                btnBack.PressedForeColor = Color.White;
                btnBack.PressedOutline = Color.FromArgb(180, 180, 185);
            }
            else
            {
                btnReset.NormalBackground = Color.Black;
                btnReset.NormalForeColor = Color.White;
                btnReset.NormalOutline = Color.Black;
                btnReset.HoverBackground = Color.FromArgb(40, 40, 40);
                btnReset.HoverForeColor = Color.White;
                btnReset.HoverOutline = Color.Black;
                btnReset.PressedBackground = Color.FromArgb(65, 65, 65);
                btnReset.PressedForeColor = Color.White;
                btnReset.PressedOutline = Color.Black;

                btnBack.PressedBackground = Color.FromArgb(230, 232, 236);
                btnBack.PressedForeColor = Color.Black;
                btnBack.PressedOutline = Color.Black;
            }
            btnReset.ForeColor = btnReset.NormalForeColor;
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

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool hide = !chkShowPassword.Checked;
            txtNewPassword.PasswordChar = hide;
            txtConfirmPassword.PasswordChar = hide;
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

            if (stage == RecoveryStage.EnterEmail)
            {
                string email = (txtEmail.Content ?? "").Trim();
                string err = null;
                string generated = null;
                bool sent = false;
                User user = null;

                if (!UiTheme.Try(() => err = AuthService.SendRecoveryCode(email, out generated, out sent, out user)))
                    return;

                if (err != null)
                {
                    ShowError(txtEmail, err);
                    txtEmail.Focus();
                    return;
                }

                expectedCode = generated;
                matchedUser = user;
                smtpSent = sent;
                try { Clipboard.SetText(expectedCode); } catch { }

                stage = RecoveryStage.EnterCode;
                txtCode.Content = "";
                UpdateStageUi();
                txtCode.Focus();
            }
            else if (stage == RecoveryStage.EnterCode)
            {
                string entered = (txtCode.Content ?? "").Trim();
                if (string.IsNullOrEmpty(entered))
                {
                    ShowError(txtCode, "Введите 6-значный код подтверждения");
                    txtCode.Focus();
                    return;
                }
                if (entered != expectedCode)
                {
                    ShowError(txtCode, "Неверный код подтверждения");
                    txtCode.Focus();
                    return;
                }

                AdvanceToPasswordStage();
            }
            else
            {
                if (matchedUser == null)
                {
                    ResetToEmailStage();
                    return;
                }

                string newPass = txtNewPassword.Content ?? "";
                string confirmPass = txtConfirmPassword.Content ?? "";

                string passErr = Validator.Password(newPass);
                if (passErr != null)
                {
                    ShowError(txtNewPassword, passErr);
                    txtNewPassword.Focus();
                    return;
                }

                string repErr = string.IsNullOrEmpty(confirmPass)
                    ? "Повторите новый пароль"
                    : Validator.PasswordRepeat(newPass, confirmPass);
                if (repErr != null)
                {
                    ShowError(txtConfirmPassword, repErr);
                    txtConfirmPassword.Focus();
                    return;
                }

                string saveErr = null;
                if (!UiTheme.Try(() => saveErr = AuthService.ChangePasswordByUserId(matchedUser.Id, newPass)))
                    return;

                if (saveErr != null)
                {
                    ShowError(txtNewPassword, saveErr);
                    txtNewPassword.Focus();
                    return;
                }

                UiTheme.Info("Пароль успешно изменён! Теперь вы можете войти с новым паролем.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
