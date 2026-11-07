using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class PropertiesForm : BaseForm
    {
        public PropertiesForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(grid);

            cmbStatus.SelectedIndex = 0;
            txtSearch.ContentChanged += (s, e) => LoadData();
            cmbType.SelectedIndexChanged += (s, e) => LoadData();
            cmbStatus.SelectedIndexChanged += (s, e) => LoadData();
            txtMinPrice.ContentChanged += (s, e) => LoadData();
            txtMaxPrice.ContentChanged += (s, e) => LoadData();

            if (Session.CurrentUser != null)
            {
                if (Session.CurrentUser.IsClient)
                {
                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;
                    btnDeal.Visible = false;
                    btnShowing.Content = "Записаться на просмотр";
                    btnShowing.Size = new Size(210, 40);
                    btnShowing.Location = new Point(180, 405);
                }
                else if (Session.CurrentUser.IsAgent)
                {
                    btnDelete.Visible = false;
                }
            }

            LoadTypes();
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Content = "";
            if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            txtMinPrice.Content = "";
            txtMaxPrice.Content = "";
            LoadData();
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null && !Session.CurrentUser.IsClient) EditSelected();
            else BookShowing();
        }

        private void btnAdd_Click(object sender, EventArgs e) => OpenEdit(0);
        private void btnEdit_Click(object sender, EventArgs e) => EditSelected();
        private void btnDelete_Click(object sender, EventArgs e) => DeleteSelected();
        private void btnShowing_Click(object sender, EventArgs e) => BookShowing();
        private void btnDeal_Click(object sender, EventArgs e) => CreateDeal();
        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void LoadTypes()
        {
            UiTheme.Try(() =>
            {
                cmbType.Items.Clear();
                cmbType.Items.Add(new LookupItem(0, "Все типы"));
                foreach (var t in PropertyService.GetTypes()) cmbType.Items.Add(t);
                cmbType.SelectedIndex = 0;
            });
        }

        private void LoadData()
        {
            UiTheme.Try(() =>
            {
                int? typeId = null;
                if (cmbType.SelectedItem is LookupItem item && item.Id > 0)
                    typeId = item.Id;

                string status = cmbStatus.SelectedIndex > 0 ? cmbStatus.SelectedItem.ToString() : "";
                decimal? minP = decimal.TryParse((txtMinPrice.Content ?? "").Trim(), out var m1) ? m1 : null;
                decimal? maxP = decimal.TryParse((txtMaxPrice.Content ?? "").Trim(), out var m2) ? m2 : null;

                var table = PropertyService.GetList(txtSearch.Content ?? "", typeId, status, minP, maxP, null);
                grid.DataSource = table;
                lblCount.Text = $"Найдено объектов: {table.Rows.Count}";
            });
        }

        private void OpenEdit(int id)
        {
            using var form = new PropertyEditForm(id);
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
                UiTheme.Warning("Выберите объект для редактирования.");
                return;
            }
            OpenEdit(id.Value);
        }

        private void DeleteSelected()
        {
            var id = UiTheme.SelectedId(grid);
            if (!id.HasValue)
            {
                UiTheme.Warning("Выберите объект для удаления.");
                return;
            }
            if (UiTheme.Confirm("Удалить выбранный объект недвижимости?"))
            {
                if (UiTheme.Try(() => PropertyService.Delete(id.Value)))
                {
                    UiTheme.Info("Объект удалён.");
                    LoadData();
                }
            }
        }

        private string SelectedStatus()
        {
            if (grid.CurrentRow == null || !grid.Columns.Contains("Статус")) return "";
            return grid.CurrentRow.Cells["Статус"].Value?.ToString() ?? "";
        }

        private void BookShowing()
        {
            var id = UiTheme.SelectedId(grid);
            if (!id.HasValue)
            {
                UiTheme.Warning("Выберите объект из списка.");
                return;
            }
            if (SelectedStatus() == PropertyStatus.Sold)
            {
                UiTheme.Warning("Нельзя записаться на просмотр: выбранный объект уже продан.");
                return;
            }
            using var form = new ShowingEditForm(0, id.Value);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                UiTheme.Info("Заявка на просмотр создана.");
            }
        }

        private void CreateDeal()
        {
            var id = UiTheme.SelectedId(grid);
            if (!id.HasValue)
            {
                UiTheme.Warning("Выберите объект из списка.");
                return;
            }
            if (SelectedStatus() == PropertyStatus.Sold)
            {
                UiTheme.Warning("Выбранный объект уже продан.");
                return;
            }
            using var form = new DealEditForm(0, id.Value);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
