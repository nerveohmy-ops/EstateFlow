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
                    isCardsView = true;
                    btnViewCards.Visible = false;
                    btnViewCards.Enabled = false;
                    btnViewTable.Visible = false;
                    btnViewTable.Enabled = false;

                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;
                    btnDeal.Visible = false;

                    btnShowing.Content = "Записаться на просмотр";
                    btnShowing.Location = new Point(148, 622);
                    btnShowing.Size = new Size(215, 38);
                    btnShowing.NormalBackground = Color.Black;
                    btnShowing.NormalForeColor = Color.White;
                    btnShowing.ForeColor = Color.White;
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
            pnlRooms.BackColor = UiTheme.Background;

            cuiButton[] btns = { btnRoomAll, btnRoom0, btnRoom1, btnRoom2, btnRoom3, btnRoom4 };
            int?[] vals = { null, 0, 1, 2, 3, 4 };

            for (int i = 0; i < btns.Length; i++)
            {
                var btn = btns[i];
                bool active = selectedRooms == vals[i];
                btn.BackColor = UiTheme.Background;

                if (active)
                {
                    btn.NormalBackground = isDark ? Color.FromArgb(240, 240, 245) : Color.Black;
                    btn.NormalForeColor = isDark ? Color.Black : Color.White;
                    btn.NormalOutline = isDark ? Color.White : Color.Black;
                    btn.HoverBackground = isDark ? Color.White : Color.FromArgb(40, 40, 40);
                    btn.HoverForeColor = isDark ? Color.Black : Color.White;
                    btn.HoverOutline = isDark ? Color.White : Color.Black;
                    btn.PressedBackground = isDark ? Color.FromArgb(215, 215, 222) : Color.FromArgb(65, 65, 65);
                    btn.PressedForeColor = isDark ? Color.Black : Color.White;
                    btn.PressedOutline = btn.NormalOutline;
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Bold);
                }
                else
                {
                    btn.NormalBackground = isDark ? Color.FromArgb(32, 33, 37) : Color.White;
                    btn.NormalForeColor = isDark ? Color.FromArgb(220, 220, 225) : Color.Black;
                    btn.NormalOutline = isDark ? Color.FromArgb(70, 72, 80) : Color.FromArgb(180, 180, 180);
                    btn.HoverBackground = isDark ? Color.FromArgb(45, 47, 54) : Color.FromArgb(242, 242, 242);
                    btn.HoverForeColor = isDark ? Color.White : Color.Black;
                    btn.HoverOutline = isDark ? Color.FromArgb(140, 144, 156) : Color.Black;
                    btn.PressedBackground = isDark ? Color.FromArgb(55, 58, 66) : Color.FromArgb(228, 228, 228);
                    btn.PressedForeColor = isDark ? Color.White : Color.Black;
                    btn.PressedOutline = btn.HoverOutline;
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
            if (Session.CurrentUser != null && Session.CurrentUser.IsClient)
            {
                isCardsView = true;
                UpdateViewMode();
                return;
            }
            if (!isCardsView) return;
            isCardsView = false;
            UpdateViewMode();
        }

        private void UpdateViewMode()
        {
            bool isDark = UiTheme.IsDark;
            bool isClient = Session.CurrentUser != null && Session.CurrentUser.IsClient;

            if (isClient)
            {
                isCardsView = true;
                btnViewCards.Visible = false;
                btnViewTable.Visible = false;
            }

            pnlCatalog.Visible = isCardsView;
            grid.Visible = !isCardsView;

            btnViewCards.BackColor = UiTheme.Background;
            btnViewTable.BackColor = UiTheme.Background;

            if (isCardsView)
            {
                pnlCatalog.BringToFront();

                StyleToggleButton(btnViewCards, true, isDark);
                StyleToggleButton(btnViewTable, false, isDark);

                // В режиме витрины кнопки действия по выбранному в таблице менее актуальны
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                grid.BringToFront();

                StyleToggleButton(btnViewTable, true, isDark);
                StyleToggleButton(btnViewCards, false, isDark);

                // В режиме таблицы возвращаем кнопки редактирования
                if (Session.CurrentUser != null && !Session.CurrentUser.IsClient)
                {
                    btnEdit.Visible = true;
                    btnDelete.Visible = Session.CurrentUser.IsAdmin;
                }
            }

            if (isCardsView) UpdateCardWidths();
        }

        private static void StyleToggleButton(cuiButton btn, bool active, bool isDark)
        {
            btn.BackColor = UiTheme.Background;
            if (active)
            {
                btn.NormalBackground = isDark ? Color.FromArgb(240, 240, 245) : Color.Black;
                btn.NormalForeColor = isDark ? Color.Black : Color.White;
                btn.NormalOutline = isDark ? Color.White : Color.Black;
                btn.HoverBackground = isDark ? Color.White : Color.FromArgb(40, 40, 40);
                btn.HoverForeColor = isDark ? Color.Black : Color.White;
                btn.HoverOutline = btn.NormalOutline;
                btn.PressedBackground = isDark ? Color.FromArgb(215, 215, 222) : Color.FromArgb(65, 65, 65);
                btn.PressedForeColor = btn.NormalForeColor;
                btn.PressedOutline = btn.NormalOutline;
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Bold);
            }
            else
            {
                btn.NormalBackground = isDark ? Color.FromArgb(32, 33, 37) : Color.White;
                btn.NormalForeColor = isDark ? Color.FromArgb(220, 220, 225) : Color.Black;
                btn.NormalOutline = isDark ? Color.FromArgb(70, 72, 80) : Color.FromArgb(170, 170, 170);
                btn.HoverBackground = isDark ? Color.FromArgb(45, 47, 54) : Color.FromArgb(242, 242, 242);
                btn.HoverForeColor = isDark ? Color.White : Color.Black;
                btn.HoverOutline = isDark ? Color.FromArgb(140, 144, 156) : Color.Black;
                btn.PressedBackground = isDark ? Color.FromArgb(55, 58, 66) : Color.FromArgb(228, 228, 228);
                btn.PressedForeColor = isDark ? Color.White : Color.Black;
                btn.PressedOutline = btn.HoverOutline;
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
            }
            btn.Invalidate();
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

                string rawMin = new string((txtMinPrice.Content ?? "").Where(char.IsDigit).ToArray());
                string rawMax = new string((txtMaxPrice.Content ?? "").Where(char.IsDigit).ToArray());
                decimal? minP = decimal.TryParse(rawMin, out var m1) && m1 > 0 ? m1 : null;
                decimal? maxP = decimal.TryParse(rawMax, out var m2) && m2 > 0 ? m2 : null;

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
                    Size = new Size(Math.Max(400, availableWidth - pnlCatalog.Padding.Horizontal - 16), 120),
                    Font = new Font("Segoe UI", 12F),
                    BackColor = Color.Transparent,
                    ForeColor = UiTheme.TextMuted,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "По выбранным критериям ничего не найдено.\nПопробуйте изменить параметры поиска или сбросить фильтры."
                };
                pnlCatalog.Controls.Add(lblEmpty);
                pnlCatalog.ResumeLayout(true);
                return;
            }

            int cardWidth = Math.Max(700, availableWidth - pnlCatalog.Padding.Horizontal - 6);

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
                        ShowPropertyDetails(p);
                };

                pnlCatalog.Controls.Add(card);
            }

            pnlCatalog.ResumeLayout(true);
            UpdateCardWidths();
        }

        private void UpdateCardWidths()
        {
            int availableWidth = pnlCatalog.ClientSize.Width > 0 ? pnlCatalog.ClientSize.Width : pnlCatalog.Width;
            if (availableWidth <= 0) availableWidth = 1040;
            int cardWidth = Math.Max(700, availableWidth - pnlCatalog.Padding.Horizontal - 6);

            pnlCatalog.SuspendLayout();
            foreach (Control c in pnlCatalog.Controls)
            {
                if (c is PropertyCardControl card)
                    card.Width = cardWidth;
                else if (c is Label lblEmpty)
                    lblEmpty.Width = Math.Max(400, availableWidth - pnlCatalog.Padding.Horizontal - 16);
            }
            pnlCatalog.ResumeLayout(true);
            pnlCatalog.PerformLayout();
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
            if (isCardsView)
            {
                using var form = new ShowingEditForm(0, 0);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    UiTheme.Info("Заявка на просмотр успешно создана.");
                }
                return;
            }

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
            if (isCardsView)
            {
                using var form = new DealEditForm(0, 0);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
                return;
            }

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

        private void ShowPropertyDetails(Property p)
        {
            if (p == null) return;

            bool isDark = UiTheme.IsDark;
            using var dlg = new Form
            {
                Text = $"{p.FullTitle} — EstateFlow",
                ClientSize = new Size(760, 470),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = UiTheme.Background,
                KeyPreview = true
            };
            dlg.KeyDown += (s, e) => { if (e.KeyCode == Keys.Escape) dlg.Close(); };

            var pic = new PictureBox
            {
                Location = new Point(22, 22),
                Size = new Size(300, 230),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = isDark ? Color.FromArgb(20, 21, 24) : Color.FromArgb(240, 242, 245),
                Image = PropertyImageHelper.GetImage(p.Photo)
            };

            string st = p.Status ?? PropertyStatus.Free;
            var lblBadge = new Label
            {
                AutoSize = true,
                Location = new Point(10, 10),
                Padding = new Padding(8, 3, 8, 3),
                Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold),
                Text = st,
                BackColor = st == PropertyStatus.Free
                    ? Color.FromArgb(16, 185, 129)
                    : (st == PropertyStatus.Reserved ? Color.FromArgb(245, 158, 11) : Color.FromArgb(107, 114, 128)),
                ForeColor = st == PropertyStatus.Reserved ? Color.Black : Color.White
            };
            pic.Controls.Add(lblBadge);

            var lblPrice = new Label
            {
                AutoSize = true,
                Location = new Point(340, 20),
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = UiTheme.TextMain,
                BackColor = UiTheme.Background,
                Text = $"{p.Price:N0} ₽".Replace('\u00A0', ' ')
            };

            int priceW = Math.Max(lblPrice.Width, lblPrice.PreferredWidth);
            var lblPpm = new Label
            {
                AutoSize = true,
                Location = new Point(340 + priceW + 12, 28),
                Font = new Font("Segoe UI", 10F),
                ForeColor = UiTheme.TextMuted,
                BackColor = UiTheme.Background,
                Text = p.PricePerMeter > 0 ? $"({p.PricePerMeter:N0} ₽/м²)" : ""
            };

            var lblPropTitle = new Label
            {
                AutoSize = false,
                Location = new Point(340, 58),
                Size = new Size(398, 28),
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = UiTheme.TextMain,
                BackColor = UiTheme.Background,
                AutoEllipsis = true,
                Text = p.FullTitle
            };

            string dist = string.IsNullOrWhiteSpace(p.District) ? "" : $"р-н {p.District}, ";
            var lblAddr = new Label
            {
                AutoSize = false,
                Location = new Point(340, 90),
                Size = new Size(398, 40),
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = isDark ? Color.FromArgb(180, 200, 240) : Color.FromArgb(40, 50, 70),
                BackColor = UiTheme.Background,
                Text = $"📍 {dist}{p.Address}"
            };

            var details = new List<string>();
            if (!string.IsNullOrWhiteSpace(p.TypeName)) details.Add($"Тип: {p.TypeName}");
            if (p.Rooms >= 0) details.Add($"Планировка: {p.RoomsDisplay}");
            if (!string.IsNullOrEmpty(p.FloorDisplay)) details.Add($"Этаж: {p.FloorDisplay}");
            if (p.Area > 0) details.Add($"Общая площадь: {p.Area:0.##} м²");
            if (p.LivingArea.HasValue && p.LivingArea.Value > 0) details.Add($"Жилая площадь: {p.LivingArea.Value:0.##} м²");
            if (p.KitchenArea.HasValue && p.KitchenArea.Value > 0) details.Add($"Кухня: {p.KitchenArea.Value:0.##} м²");
            if (p.YearBuilt.HasValue && p.YearBuilt.Value > 0) details.Add($"Год постройки: {p.YearBuilt.Value}");
            if (!string.IsNullOrWhiteSpace(p.AgentName)) details.Add($"Ответственный агент: {p.AgentName}");

            var lblSpecs = new Label
            {
                AutoSize = false,
                Location = new Point(340, 134),
                Size = new Size(398, 122),
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = UiTheme.TextMain,
                BackColor = UiTheme.Background,
                Text = string.Join("\n", details)
            };

            var lblDescHeader = new Label
            {
                AutoSize = true,
                Location = new Point(22, 266),
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                ForeColor = UiTheme.TextMain,
                BackColor = UiTheme.Background,
                Text = "Описание объекта:"
            };

            var txtDesc = new TextBox
            {
                Location = new Point(22, 290),
                Size = new Size(716, 108),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 9.5F),
                BackColor = UiTheme.CardBg,
                ForeColor = UiTheme.TextMain,
                TabStop = false,
                Text = string.IsNullOrWhiteSpace(p.Description)
                    ? "Уютный объект недвижимости в г. Благовещенск. Подробности уточняйте у агента при записи на просмотр."
                    : p.Description.Trim()
            };

            var btnClose = UiTheme.CreateButton("Закрыть", false, 140, 40);
            btnClose.Location = new Point(598, 412);
            btnClose.Click += (s, e) => dlg.Close();

            dlg.Controls.AddRange(new Control[]
            {
                pic, lblPrice, lblPpm, lblPropTitle, lblAddr, lblSpecs, lblDescHeader, txtDesc, btnClose
            });

            if (p.Status != PropertyStatus.Sold)
            {
                var btnBook = UiTheme.CreateButton("Записаться на просмотр", true, 236, 40);
                btnBook.Padding = new Padding(6);
                btnBook.Location = new Point(350, 412);
                btnBook.Click += (s, e) =>
                {
                    dlg.DialogResult = DialogResult.Yes;
                    dlg.Close();
                };
                dlg.Controls.Add(btnBook);
            }

            // Темизация кнопок под текущую тему без перетирания цветов текста описания/цены
            if (isDark)
            {
                foreach (Control c in dlg.Controls)
                {
                    if (c is cuiButton btn)
                    {
                        bool isPrimary = btn.NormalBackground == Color.Black;
                        btn.BackColor = UiTheme.Background;
                        btn.NormalBackground = isPrimary ? Color.FromArgb(240, 240, 245) : Color.FromArgb(38, 40, 45);
                        btn.NormalForeColor = isPrimary ? Color.Black : Color.FromArgb(240, 240, 245);
                        btn.NormalOutline = isPrimary ? Color.White : Color.FromArgb(85, 88, 98);
                        btn.HoverBackground = isPrimary ? Color.White : Color.FromArgb(52, 54, 62);
                        btn.HoverForeColor = isPrimary ? Color.Black : Color.White;
                        btn.HoverOutline = Color.White;
                        btn.PressedBackground = isPrimary ? Color.FromArgb(215, 215, 222) : Color.FromArgb(65, 68, 78);
                        btn.PressedForeColor = btn.HoverForeColor;
                        btn.PressedOutline = Color.White;
                    }
                }
            }

            if (dlg.ShowDialog(this) == DialogResult.Yes)
            {
                BookShowing(p.Id, p.Status);
            }
        }

        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();
            pnlRooms.BackColor = UiTheme.Background;
            UpdateRoomButtonStyles();
            UpdateViewMode();
            foreach (Control c in pnlCatalog.Controls)
            {
                if (c is PropertyCardControl card)
                    card.ApplyTheme();
                else if (c is Label lblEmpty)
                {
                    lblEmpty.BackColor = Color.Transparent;
                    lblEmpty.ForeColor = UiTheme.TextMuted;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            pnlRooms.BackColor = UiTheme.Background;
            UpdateRoomButtonStyles();
            UpdateViewMode();
            if (pnlCatalog.Controls.Count == 0)
                LoadData();
            UpdateCardWidths();
        }
    }
}
