using System.Data;
using EstateFlow.Controls;
using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;
using HartUI.Controls;

namespace EstateFlow.Forms
{
    public partial class PropertiesForm : BaseForm
    {
        private int? selectedRooms = null;
        private bool isCardsView = true;
        private bool isInitializing = true;

        public PropertiesForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(grid);
            UiTheme.AttachPriceFormatter(txtMinPrice);
            UiTheme.AttachPriceFormatter(txtMaxPrice);

            InitFilters();
            SetupRolePermissions();
            InitRoomButtons();

            pnlCatalog.Resize += (s, e) => UpdateCardWidths();

            isInitializing = false;
            LoadData();
        }

        private void InitFilters()
        {
            LoadDistricts();
            LoadTypes();

            cmbStatus.SelectedIndex = 0;
            cmbSort.SelectedIndex = 0;

            txtSearch.ContentChanged += (s, e) => { if (!isInitializing) LoadData(); };
            cmbDistrict.SelectedIndexChanged += (s, e) => { if (!isInitializing) LoadData(); };
            cmbType.SelectedIndexChanged += (s, e) => { if (!isInitializing) LoadData(); };
            cmbStatus.SelectedIndexChanged += (s, e) => { if (!isInitializing) LoadData(); };
            cmbSort.SelectedIndexChanged += (s, e) => { if (!isInitializing) LoadData(); };
            txtMinPrice.ContentChanged += (s, e) => { if (!isInitializing) LoadData(); };
            txtMaxPrice.ContentChanged += (s, e) => { if (!isInitializing) LoadData(); };
        }

        private void SetupRolePermissions()
        {
            if (Session.CurrentUser != null)
            {
                if (Session.CurrentUser.IsClient)
                {
                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;
                    btnDeal.Visible = false;
                    btnShowing.Content = "Записаться на просмотр";
                    btnShowing.Size = new Size(200, 38);
                }
                else if (Session.CurrentUser.IsAgent)
                {
                    btnDelete.Visible = false;
                }
            }
        }

        private void InitRoomButtons()
        {
            btnRoomAll.Click += (s, e) => SetRoomsFilter(null);
            btnRoom0.Click += (s, e) => SetRoomsFilter(0);
            btnRoom1.Click += (s, e) => SetRoomsFilter(1);
            btnRoom2.Click += (s, e) => SetRoomsFilter(2);
            btnRoom3.Click += (s, e) => SetRoomsFilter(3);
            btnRoom4.Click += (s, e) => SetRoomsFilter(4);

            UpdateRoomButtonStyles();
        }

        private void SetRoomsFilter(int? rooms)
        {
            selectedRooms = rooms;
            UpdateRoomButtonStyles();
            LoadData();
        }

        private void UpdateRoomButtonStyles()
        {
            bool isDark = UiTheme.IsDark;
            cuiButton[] btns = { btnRoomAll, btnRoom0, btnRoom1, btnRoom2, btnRoom3, btnRoom4 };
            int?[] vals = { null, 0, 1, 2, 3, 4 };

            for (int i = 0; i < btns.Length; i++)
            {
                var btn = btns[i];
                bool active = selectedRooms == vals[i];

                if (active)
                {
                    btn.NormalBackground = isDark ? Color.FromArgb(240, 240, 245) : Color.Black;
                    btn.NormalForeColor = isDark ? Color.Black : Color.White;
                    btn.NormalOutline = isDark ? Color.White : Color.Black;
                    btn.HoverBackground = isDark ? Color.White : Color.FromArgb(40, 40, 40);
                    btn.HoverForeColor = isDark ? Color.Black : Color.White;
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Bold);
                }
                else
                {
                    btn.NormalBackground = isDark ? Color.FromArgb(32, 33, 37) : Color.White;
                    btn.NormalForeColor = isDark ? Color.FromArgb(220, 220, 225) : Color.Black;
                    btn.NormalOutline = isDark ? Color.FromArgb(70, 72, 80) : Color.FromArgb(180, 180, 180);
                    btn.HoverBackground = isDark ? Color.FromArgb(45, 47, 54) : Color.FromArgb(242, 242, 242);
                    btn.HoverForeColor = isDark ? Color.White : Color.Black;
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
                }
                btn.Invalidate();
            }
        }

        private void LoadDistricts()
        {
            UiTheme.Try(() =>
            {
                cmbDistrict.Items.Clear();
                cmbDistrict.Items.Add("Все районы");
                foreach (var d in PropertyService.GetDistricts())
                    cmbDistrict.Items.Add(d);
                cmbDistrict.SelectedIndex = 0;
            });
        }

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

        private void btnViewCards_Click(object sender, EventArgs e)
        {
            if (isCardsView) return;
            isCardsView = true;
            UpdateViewMode();
        }

        private void btnViewTable_Click(object sender, EventArgs e)
        {
            if (!isCardsView) return;
            isCardsView = false;
            UpdateViewMode();
        }

        private void UpdateViewMode()
        {
            bool isDark = UiTheme.IsDark;

            pnlCatalog.Visible = isCardsView;
            grid.Visible = !isCardsView;

            if (isCardsView)
            {
                pnlCatalog.BringToFront();

                btnViewCards.NormalBackground = isDark ? Color.FromArgb(240, 240, 245) : Color.Black;
                btnViewCards.NormalForeColor = isDark ? Color.Black : Color.White;
                btnViewCards.NormalOutline = isDark ? Color.White : Color.Black;

                btnViewTable.NormalBackground = isDark ? Color.FromArgb(32, 33, 37) : Color.White;
                btnViewTable.NormalForeColor = isDark ? Color.FromArgb(220, 220, 225) : Color.Black;
                btnViewTable.NormalOutline = isDark ? Color.FromArgb(70, 72, 80) : Color.FromArgb(170, 170, 170);

                // В режиме витрины кнопки действия по выбранному в таблице менее актуальны
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                grid.BringToFront();

                btnViewTable.NormalBackground = isDark ? Color.FromArgb(240, 240, 245) : Color.Black;
                btnViewTable.NormalForeColor = isDark ? Color.Black : Color.White;
                btnViewTable.NormalOutline = isDark ? Color.White : Color.Black;

                btnViewCards.NormalBackground = isDark ? Color.FromArgb(32, 33, 37) : Color.White;
                btnViewCards.NormalForeColor = isDark ? Color.FromArgb(220, 220, 225) : Color.Black;
                btnViewCards.NormalOutline = isDark ? Color.FromArgb(70, 72, 80) : Color.FromArgb(170, 170, 170);

                // В режиме таблицы возвращаем кнопки редактирования
                if (Session.CurrentUser != null && !Session.CurrentUser.IsClient)
                {
                    btnEdit.Visible = true;
                    btnDelete.Visible = Session.CurrentUser.IsAdmin;
                }
            }

            btnViewCards.Invalidate();
            btnViewTable.Invalidate();

            if (isCardsView) UpdateCardWidths();
        }

        private void LoadData()
        {
            UiTheme.Try(() =>
            {
                int? typeId = null;
                if (cmbType.SelectedItem is LookupItem item && item.Id > 0)
                    typeId = item.Id;

                string district = cmbDistrict.SelectedIndex > 0 ? cmbDistrict.SelectedItem.ToString() : null;
                string status = cmbStatus.SelectedIndex > 0 ? cmbStatus.SelectedItem.ToString() : "";

                string rawMin = (txtMinPrice.Content ?? "").Replace(" ", "").Replace("\u00A0", "").Trim();
                string rawMax = (txtMaxPrice.Content ?? "").Replace(" ", "").Replace("\u00A0", "").Trim();
                decimal? minP = decimal.TryParse(rawMin, out var m1) ? m1 : null;
                decimal? maxP = decimal.TryParse(rawMax, out var m2) ? m2 : null;

                string sortBy = "newest";
                switch (cmbSort.SelectedIndex)
                {
                    case 1: sortBy = "price_asc"; break;
                    case 2: sortBy = "price_desc"; break;
                    case 3: sortBy = "area_desc"; break;
                    default: sortBy = "newest"; break;
                }

                string search = txtSearch.Content ?? "";

                // Получаем список объектов как моделей
                var properties = PropertyService.GetProperties(
                    search, typeId, status, minP, maxP, null, selectedRooms, district, sortBy);

                // Получаем DataTable для режима таблицы
                var table = PropertyService.GetList(
                    search, typeId, status, minP, maxP, null, selectedRooms, district, sortBy);

                grid.DataSource = table;
                lblCount.Text = $"Найдено предложений: {properties.Count}";

                PopulateCatalogCards(properties);
            });
        }

        private void PopulateCatalogCards(List<Property> properties)
        {
            pnlCatalog.SuspendLayout();
            pnlCatalog.Controls.Clear();

            int availableWidth = pnlCatalog.ClientSize.Width > 0 ? pnlCatalog.ClientSize.Width : pnlCatalog.Width;
            if (availableWidth <= 0) availableWidth = 1040;

            if (properties.Count == 0)
            {
                var lblEmpty = new Label
                {
                    AutoSize = false,
                    Size = new Size(availableWidth - 40, 120),
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = UiTheme.TextMuted,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "По выбранным критериям ничего не найдено.\nПопробуйте изменить параметры поиска или сбросить фильтры."
                };
                pnlCatalog.Controls.Add(lblEmpty);
                pnlCatalog.ResumeLayout();
                return;
            }

            int cardWidth = Math.Max(700, availableWidth - (pnlCatalog.VerticalScroll.Visible ? 25 : 15));

            foreach (var prop in properties)
            {
                var card = new PropertyCardControl
                {
                    Width = cardWidth,
                    Margin = new Padding(0, 0, 0, 10)
                };

                card.Bind(prop);

                card.ShowingRequested += (s, p) => BookShowing(p.Id, p.Status);
                card.EditRequested += (s, p) => OpenEdit(p.Id);
                card.DealRequested += (s, p) => CreateDeal(p.Id, p.Status);
                card.DeleteRequested += (s, p) => DeleteProperty(p.Id);
                card.CardClicked += (s, p) =>
                {
                    if (Session.CurrentUser != null && !Session.CurrentUser.IsClient)
                        OpenEdit(p.Id);
                    else
                        BookShowing(p.Id, p.Status);
                };

                pnlCatalog.Controls.Add(card);
            }

            pnlCatalog.ResumeLayout();
        }

        private void UpdateCardWidths()
        {
            int availableWidth = pnlCatalog.ClientSize.Width > 0 ? pnlCatalog.ClientSize.Width : pnlCatalog.Width;
            if (availableWidth <= 0) availableWidth = 1040;
            int cardWidth = Math.Max(700, availableWidth - (pnlCatalog.VerticalScroll.Visible ? 25 : 15));

            foreach (Control c in pnlCatalog.Controls)
            {
                if (c is PropertyCardControl card)
                    card.Width = cardWidth;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isInitializing = true;
            txtSearch.Content = "";
            selectedRooms = null;
            UpdateRoomButtonStyles();
            if (cmbDistrict.Items.Count > 0) cmbDistrict.SelectedIndex = 0;
            if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            cmbSort.SelectedIndex = 0;
            txtMinPrice.Content = "";
            txtMaxPrice.Content = "";
            isInitializing = false;
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
            DeleteProperty(id.Value);
        }

        private void DeleteProperty(int id)
        {
            if (UiTheme.Confirm("Удалить выбранный объект недвижимости?"))
            {
                if (UiTheme.Try(() => PropertyService.Delete(id)))
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
            BookShowing(id.Value, SelectedStatus());
        }

        private void BookShowing(int propertyId, string status)
        {
            if (status == PropertyStatus.Sold)
            {
                UiTheme.Warning("Нельзя записаться на просмотр: выбранный объект уже продан.");
                return;
            }
            using var form = new ShowingEditForm(0, propertyId);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                UiTheme.Info("Заявка на просмотр успешно создана.");
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
            CreateDeal(id.Value, SelectedStatus());
        }

        private void CreateDeal(int propertyId, string status)
        {
            if (status == PropertyStatus.Sold)
            {
                UiTheme.Warning("Выбранный объект уже продан.");
                return;
            }
            using var form = new DealEditForm(0, propertyId);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }

        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();
            UpdateRoomButtonStyles();
            UpdateViewMode();
            foreach (Control c in pnlCatalog.Controls)
            {
                if (c is PropertyCardControl card)
                    card.ApplyTheme();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateViewMode();
            if (pnlCatalog.Controls.Count == 0)
                LoadData();
            UpdateCardWidths();
        }
    }
}
