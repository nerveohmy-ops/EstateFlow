using System.Data;
using EstateFlow.Helpers;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class ReportsForm : BaseForm
    {
        public ReportsForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(grid);

            dtpFrom.Value = new DateTime(2025, 1, 1);
            dtpTo.Value = DateTime.Today;

            if (Session.CurrentUser != null && Session.CurrentUser.IsAdmin)
            {
                cmbReportType.Items.AddRange(ReportService.All);
            }
            else
            {
                cmbReportType.Items.AddRange(new object[] { ReportService.ByMonth, ReportService.ByType, ReportService.ByClient });
            }
            cmbReportType.SelectedIndex = 0;

            cmbReportType.SelectedIndexChanged += (s, e) =>
            {
                bool usesDates = cmbReportType.SelectedItem?.ToString() != ReportService.ByType;
                dtpFrom.Enabled = dtpTo.Enabled = usesDates;
                BuildReport();
            };
            dtpFrom.ValueChanged += (s, e) => BuildReport();
            dtpTo.ValueChanged += (s, e) => BuildReport();

            BuildReport();
        }

        private void btnBuild_Click(object sender, EventArgs e) => BuildReport();
        private void btnExport_Click(object sender, EventArgs e) => ExportReport();
        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void BuildReport()
        {
            UiTheme.Try(() =>
            {
                string rep = cmbReportType.SelectedItem?.ToString() ?? ReportService.ByAgent;
                int? agentId = Session.CurrentUser != null && Session.CurrentUser.IsAgent ? Session.CurrentUser.Id : null;

                var table = ReportService.Build(rep, dtpFrom.Value, dtpTo.Value, agentId);
                grid.DataSource = table;

                if (rep == ReportService.ByType)
                    lblReportSummary.Text = $"Записей в отчёте: {table.Rows.Count}";
                else
                    lblReportSummary.Text = $"Записей: {table.Rows.Count} | Период: {dtpFrom.Value:dd.MM.yyyy} — {dtpTo.Value:dd.MM.yyyy}";
            });
        }

        private void ExportReport()
        {
            if (grid.DataSource is not DataTable dt || dt.Rows.Count == 0)
            {
                UiTheme.Warning("Нет данных для экспорта.");
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "CSV файлы (*.csv)|*.csv",
                FileName = $"Report_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                if (UiTheme.Try(() => ReportService.ExportCsv(dt, sfd.FileName)))
                {
                    UiTheme.Info($"Отчёт экспортирован:\n{sfd.FileName}");
                }
            }
        }
    }
}
