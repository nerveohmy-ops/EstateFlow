using EstateFlow.Data;
using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class UsersForm : BaseForm
    {
        public UsersForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(grid);

            txtSearch.ContentChanged += (s, e) => LoadData();
            cmbRole.SelectedIndexChanged += (s, e) => LoadData();

            LoadRoles();
            LoadData();
        }

        private void LoadRoles()
        {
            UiTheme.Try(() =>
            {
                cmbRole.Items.Clear();
                cmbRole.Items.Add(new LookupItem(0, "Все роли"));
                foreach (var r in UserService.GetRoles()) cmbRole.Items.Add(r);
                cmbRole.SelectedIndex = 0;
            });
        }

        private void grid_DoubleClick(object sender, EventArgs e) => EditSelected();
        private void btnAdd_Click(object sender, EventArgs e) => OpenEdit(0);
        private void btnEdit_Click(object sender, EventArgs e) => EditSelected();
        private void btnResetPassword_Click(object sender, EventArgs e) => ResetPasswordSelected();
        private void btnDelete_Click(object sender, EventArgs e) => DeleteSelected();
        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void btnResetDb_Click(object sender, EventArgs e)
        {
            if (UiTheme.Confirm("Восстановить исходные демонстрационные данные БД (по 20 записей в каждой таблице)?\nВсе добавленные вручную записи будут заменены тестовым набором."))
            {
                if (UiTheme.Try(() => DbInitializer.ResetDatabase()))
                {
                    UiTheme.Info("Демонстрационные данные успешно восстановлены.");
                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            UiTheme.Try(() =>
            {
                int? roleId = null;
                if (cmbRole.SelectedItem is LookupItem item && item.Id > 0)
                    roleId = item.Id;

                var table = UserService.GetList(txtSearch.Content ?? "", roleId);
                grid.DataSource = table;
                lblCount.Text = $"Пользователей в списке: {table.Rows.Count}";
            });
        }

        private void OpenEdit(int id)
        {
            using var form = new UserEditForm(id);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void EditSelected()
        {
            var id = UiTheme.SelectedId(grid);
            if (!id.HasValue)
            {
                UiTheme.Warning("Выберите пользователя для редактирования.");
                return;
            }
            OpenEdit(id.Value);
        }

        private void ResetPasswordSelected()
        {
            var id = UiTheme.SelectedId(grid);
            if (!id.HasValue)
            {
                UiTheme.Warning("Выберите пользователя.");
                return;
            }

            var u = UserService.GetById(id.Value);
            if (u == null) return;

            string newPass = PasswordHasher.Generate();
            if (UiTheme.Confirm($"Сгенерировать новый пароль для пользователя {u.FullName} ({u.Login})?"))
            {
                if (UiTheme.Try(() => UserService.ChangePassword(u.Id, newPass)))
                {
                    try { Clipboard.SetText(newPass); } catch { }
                    UiTheme.Info($"Пароль обновлён.\n\nНовый пароль: {newPass}\n(Скопирован в буфер обмена)");
                }
            }
        }

        private void DeleteSelected()
        {
            var id = UiTheme.SelectedId(grid);
            if (!id.HasValue)
            {
                UiTheme.Warning("Выберите пользователя для удаления.");
                return;
            }

            if (Session.CurrentUser != null && id.Value == Session.CurrentUser.Id)
            {
                UiTheme.Warning("Нельзя удалить собственную учётную запись.");
                return;
            }

            if (UiTheme.Confirm("Удалить выбранного пользователя?"))
            {
                if (UiTheme.Try(() => UserService.Delete(id.Value)))
                {
                    UiTheme.Info("Пользователь удалён.");
                    LoadData();
                }
            }
        }
    }
}
