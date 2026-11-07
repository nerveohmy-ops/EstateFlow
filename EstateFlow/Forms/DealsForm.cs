using System.Data;
using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class DealsForm : BaseForm
    {
        public DealsForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(grid);

            cmbStatus.SelectedIndex = 0;
            dtpFrom.Value = new DateTime(2025, 1, 1);
            dtpTo.Value = DateTime.Today;

            txtSearch.ContentChanged += (s, e) => LoadData();
            cmbStatus.SelectedIndexChanged += (s, e) => LoadData();
            chkUseDate.CheckedChanged += (s, e) =>
            {
                dtpFrom.Enabled = dtpTo.Enabled = chkUseDate.Checked;
                LoadData();
            };
            dtpFrom.ValueChanged += (s, e) => LoadData();
            dtpTo.ValueChanged += (s, e) => LoadData();

            if (Session.CurrentUser != null)
            {
                if (Session.CurrentUser.IsClient)
                {
                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;
                    btnExport.Location = new Point(180, 405);
                }
                else if (Session.CurrentUser.IsAgent)
                {
                    btnDelete.Visible = false;
                }
            }

            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Content = "";
            cmbStatus.SelectedIndex = 0;
            chkUseDate.Checked = false;
            LoadData();
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null && !Session.CurrentUser.IsClient) EditSelected();
        }

        private void btnAdd_Click(object sender, EventArgs e) => OpenEdit(0);
        private void btnEdit_Click(object sender, EventArgs e) => EditSelected();
        private void btnDelete_Click(object sender, EventArgs e) => DeleteSelected();
        private void btnExport_Click(object sender, EventArgs e) => ExportCsv();
        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void LoadData()
        {
            UiTheme.Try(() =>
            {
                string status = cmbStatus.SelectedIndex > 0 ? cmbStatus.SelectedItem.ToString() : "";
                DateTime? from = chkUseDate.Checked ? dtpFrom.Value.Date : null;
                DateTime? to = chkUseDate.Checked ? dtpTo.Value.Date : null;

                int? agentId = Session.CurrentUser != null && Session.CurrentUser.IsAgent ? Session.CurrentUser.Id : null;
                int? clientId = Session.CurrentUser != null && Session.CurrentUser.IsClient ? Session.CurrentUser.Id : null;

                var table = DealService.GetList(txtSearch.Content ?? "", status, agentId, clientId, from, to);
                grid.DataSource = table;

                decimal sum = 0;
                foreach (DataRow r in table.Rows)
                {
                    if (r["Сумма, ₽"] is decimal val && r["Статус"]?.ToString() == DealStatus.Completed)
                        sum += val;
                }
                lblTotalSummary.Text = $"Сделок: {table.Rows.Count} | Завершённых на сумму: {sum:N0} ₽";
            });
        }

        private void OpenEdit(int id)
        {
            using var form = new DealEditForm(id);
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
                UiTheme.Warning("Выберите сделку из таблицы.");
                return;
            }
            OpenEdit(id.Value);
        }

        private void DeleteSelected()
        {
            var id = UiTheme.SelectedId(grid);
            if (!id.HasValue)
            {
                UiTheme.Warning("Выберите сделку для удаления.");
                return;
            }
            if (UiTheme.Confirm("Удалить выбранную сделку?"))
            {
                if (UiTheme.Try(() => DealService.Delete(id.Value)))
                {
                    UiTheme.Info("Сделка удалена.");
                    LoadData();
                }
            }
        }

        private void ExportCsv()
        {
            if (grid.DataSource is not DataTable dt || dt.Rows.Count == 0)
            {
                UiTheme.Warning("Нет данных для экспорта.");
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "CSV файлы (*.csv)|*.csv",
                FileName = $"Deals_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                if (UiTheme.Try(() => ReportService.ExportCsv(dt, sfd.FileName)))
                {
                    UiTheme.Info($"Данные выгружены в файл:\n{sfd.FileName}");
                }
            }
        }
    }
}
