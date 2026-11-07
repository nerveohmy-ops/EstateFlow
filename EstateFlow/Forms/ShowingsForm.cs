using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class ShowingsForm : BaseForm
    {
        public ShowingsForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(grid);

            cmbStatus.SelectedIndex = 0;
            cmbStatus.SelectedIndexChanged += (s, e) => LoadData();

            if (Session.CurrentUser != null)
            {
                if (Session.CurrentUser.IsClient)
                {
                    btnConfirm.Visible = false;
                    btnDone.Visible = false;
                    btnDelete.Visible = false;
                    btnCancel.Location = new Point(320, 405);
                }
                else if (Session.CurrentUser.IsAgent)
                {
                    btnDelete.Visible = false;
                }
            }

            LoadData();
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            var id = UiTheme.SelectedId(grid);
            if (id.HasValue && Session.CurrentUser != null && !Session.CurrentUser.IsClient)
                OpenEdit(id.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e) => OpenEdit(0);
        private void btnConfirm_Click(object sender, EventArgs e) => ChangeStatus(ShowingStatus.Confirmed);
        private void btnDone_Click(object sender, EventArgs e) => ChangeStatus(ShowingStatus.Done);
        private void btnCancel_Click(object sender, EventArgs e) => ChangeStatus(ShowingStatus.Cancelled);
        private void btnDelete_Click(object sender, EventArgs e) => DeleteSelected();
        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void LoadData()
        {
            UiTheme.Try(() =>
            {
                string status = cmbStatus.SelectedIndex > 0 ? cmbStatus.SelectedItem.ToString() : "";
                int? agentId = Session.CurrentUser != null && Session.CurrentUser.IsAgent ? Session.CurrentUser.Id : null;
                int? clientId = Session.CurrentUser != null && Session.CurrentUser.IsClient ? Session.CurrentUser.Id : null;

                var table = ShowingService.GetList(status, agentId, clientId);
                grid.DataSource = table;
                lblCount.Text = $"Заявок в списке: {table.Rows.Count}";
            });
        }

        private void OpenEdit(int id)
        {
            using var form = new ShowingEditForm(id);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ChangeStatus(string newStatus)
        {
            var id = UiTheme.SelectedId(grid);
            if (!id.HasValue)
            {
                UiTheme.Warning("Выберите заявку из списка.");
                return;
            }
            if (UiTheme.Try(() => ShowingService.SetStatus(id.Value, newStatus)))
            {
                UiTheme.Info($"Статус заявки изменён на «{newStatus}».");
                LoadData();
            }
        }

        private void DeleteSelected()
        {
            var id = UiTheme.SelectedId(grid);
            if (!id.HasValue)
            {
                UiTheme.Warning("Выберите заявку для удаления.");
                return;
            }
            if (UiTheme.Confirm("Удалить выбранную заявку на просмотр?"))
            {
                if (UiTheme.Try(() => ShowingService.Delete(id.Value)))
                {
                    UiTheme.Info("Заявка удалена.");
                    LoadData();
                }
            }
        }
    }
}
