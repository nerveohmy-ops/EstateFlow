using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class PropertyEditForm : BaseForm
    {
        protected override bool ShowThemeToggle => false;

        private int propertyId;
        private string currentPhotoFile;

        public PropertyEditForm(int id = 0)
        {
            propertyId = id;
            InitializeComponent();
            UiTheme.AttachPriceFormatter(txtPrice, lblPriceHint);

            InitDropdowns();

            if (id > 0)
            {
                Text = "Редактирование объекта — EstateFlow";
                lblTitle.Text = "Редактирование объекта #" + id;
            }
            LoadData();
        }

        private void InitDropdowns()
        {
            // Районы Благовещенска
            cmbDistrict.Items.Clear();
            foreach (var d in PropertyService.GetDistricts())
            {
                cmbDistrict.Items.Add(d);
            }
            if (cmbDistrict.Items.Count > 0) cmbDistrict.SelectedIndex = 0;

            // Комнаты
            cmbRooms.Items.Clear();
            cmbRooms.Items.Add(new KeyValuePair<int, string>(0, "0 (Студия)"));
            cmbRooms.Items.Add(new KeyValuePair<int, string>(1, "1-комнатная"));
            cmbRooms.Items.Add(new KeyValuePair<int, string>(2, "2-комнатная"));
            cmbRooms.Items.Add(new KeyValuePair<int, string>(3, "3-комнатная"));
            cmbRooms.Items.Add(new KeyValuePair<int, string>(4, "4-комнатная"));
            cmbRooms.Items.Add(new KeyValuePair<int, string>(5, "5+ комнат"));
            cmbRooms.DisplayMember = "Value";
            cmbRooms.ValueMember = "Key";
            cmbRooms.SelectedIndex = 1; // 1-к по умолчанию

            // Предустановленные фото
            cmbPhoto.Items.Clear();
            var photos = PropertyImageHelper.GetAvailablePhotoPresets();
            foreach (var ph in photos)
            {
                cmbPhoto.Items.Add(ph);
            }
            if (cmbPhoto.Items.Count > 0) cmbPhoto.SelectedIndex = 0;

            cmbPhoto.SelectedIndexChanged += (s, e) =>
            {
                UpdatePhotoPreview(cmbPhoto.Text);
            };
            cmbPhoto.TextChanged += (s, e) =>
            {
                UpdatePhotoPreview(cmbPhoto.Text);
            };

            cmbStatus.SelectedIndex = 0;
        }

        private void UpdatePhotoPreview(string photo)
        {
            currentPhotoFile = photo?.Trim();
            picPhotoPreview.Image = PropertyImageHelper.GetImage(currentPhotoFile);
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Выберите фотографию объекта недвижимости",
                Filter = "Изображения (*.jpg;*.jpeg;*.png;*.webp)|*.jpg;*.jpeg;*.png;*.webp|Все файлы (*.*)|*.*"
            };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    string destDir = PropertyImageHelper.PropertiesDirectory;
                    string destFileName = "user_" + Path.GetFileName(ofd.FileName);
                    string destPath = Path.Combine(destDir, destFileName);
                    File.Copy(ofd.FileName, destPath, true);

                    if (!cmbPhoto.Items.Contains(destFileName))
                        cmbPhoto.Items.Insert(0, destFileName);

                    cmbPhoto.Text = destFileName;
                    UpdatePhotoPreview(destFileName);
                }
                catch
                {
                    // Если скопировать не удалось, используем прямой путь
                    cmbPhoto.Text = ofd.FileName;
                    UpdatePhotoPreview(ofd.FileName);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadData()
        {
            UiTheme.Try(() =>
            {
                cmbType.Items.Clear();
                foreach (var t in PropertyService.GetTypes()) cmbType.Items.Add(t);
                if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;

                cmbAgent.Items.Clear();
                cmbAgent.Items.Add(new LookupItem(0, "— Не назначен —"));
                foreach (var a in UserService.GetLookup(UserRole.Agent)) cmbAgent.Items.Add(a);
                cmbAgent.SelectedIndex = 0;

                if (propertyId > 0)
                {
                    var p = PropertyService.GetById(propertyId);
                    if (p != null)
                    {
                        Validator.SplitAddress(p.Address, out string city, out string street, out string house, out string apt);
                        txtCity.Content = string.IsNullOrWhiteSpace(city) ? "г. Благовещенск" : city;
                        txtStreet.Content = street;
                        txtHouse.Content = house;
                        txtApartment.Content = apt;

                        if (!string.IsNullOrWhiteSpace(p.District))
                        {
                            if (!cmbDistrict.Items.Contains(p.District))
                                cmbDistrict.Items.Add(p.District);
                            cmbDistrict.SelectedItem = p.District;
                        }

                        UiTheme.SelectById(cmbType, p.TypeId);

                        // Комнаты
                        int rIdx = p.Rooms >= 5 ? 5 : (p.Rooms < 0 ? 0 : p.Rooms);
                        if (rIdx < cmbRooms.Items.Count)
                            cmbRooms.SelectedIndex = rIdx;

                        txtFloor.Content = p.Floor?.ToString() ?? "";
                        txtTotalFloors.Content = p.TotalFloors?.ToString() ?? "";
                        txtYearBuilt.Content = p.YearBuilt?.ToString() ?? "";

                        txtArea.Content = p.Area.ToString("0.##");
                        txtLivingArea.Content = p.LivingArea?.ToString("0.##") ?? "";
                        txtKitchenArea.Content = p.KitchenArea?.ToString("0.##") ?? "";

                        cmbStatus.SelectedItem = p.Status;
                        txtPrice.Content = ((long)p.Price).ToString();
                        if (p.AgentId.HasValue) UiTheme.SelectById(cmbAgent, p.AgentId.Value);

                        txtDescription.Content = p.Description;

                        if (!string.IsNullOrWhiteSpace(p.Photo))
                        {
                            if (!cmbPhoto.Items.Contains(p.Photo))
                                cmbPhoto.Items.Insert(0, p.Photo);
                            cmbPhoto.Text = p.Photo;
                        }
                        UpdatePhotoPreview(p.Photo);
                    }
                }
                else
                {
                    txtCity.Content = "г. Благовещенск";
                    if (Session.CurrentUser != null && Session.CurrentUser.IsAgent)
                    {
                        UiTheme.SelectById(cmbAgent, Session.CurrentUser.Id);
                    }
                    UpdatePhotoPreview(cmbPhoto.Text);
                }
            });
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string city = string.IsNullOrWhiteSpace(txtCity.Content) ? "г. Благовещенск" : txtCity.Content.Trim();
            string addrErr = Validator.AddressParts(
                city, txtStreet.Content, txtHouse.Content, txtApartment.Content, out string addr);
            if (addrErr != null)
            {
                UiTheme.Warning(addrErr);
                return;
            }

            var typeItem = cmbType.SelectedItem as LookupItem;
            if (typeItem == null || typeItem.Id == 0)
            {
                UiTheme.Warning("Выберите тип недвижимости.");
                cmbType.Focus();
                return;
            }

            string areaErr = Validator.PositiveDecimal(txtArea.Content ?? "", "Площадь", out decimal area);
            if (areaErr != null)
            {
                UiTheme.Warning(areaErr);
                txtArea.Focus();
                return;
            }

            string priceErr = Validator.PositiveDecimal(txtPrice.Content ?? "", "Стоимость", out decimal price);
            if (priceErr != null)
            {
                UiTheme.Warning(priceErr);
                txtPrice.Focus();
                return;
            }

            // Комнаты
            int rooms = 1;
            if (cmbRooms.SelectedItem is KeyValuePair<int, string> kvp)
            {
                rooms = kvp.Key;
            }
            else if (int.TryParse(cmbRooms.Text, out int r))
            {
                rooms = r;
            }

            // Этажи
            int? floor = null;
            if (int.TryParse((txtFloor.Content ?? "").Trim(), out int fl) && fl > 0)
                floor = fl;

            int? totalFloors = null;
            if (int.TryParse((txtTotalFloors.Content ?? "").Trim(), out int tf) && tf > 0)
                totalFloors = tf;

            if (floor.HasValue && totalFloors.HasValue && floor > totalFloors)
            {
                UiTheme.Warning("Этаж не может быть больше общего количества этажей в здании.");
                txtFloor.Focus();
                return;
            }

            // Дополнительные площади
            decimal? livingArea = null;
            if (decimal.TryParse((txtLivingArea.Content ?? "").Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal la) && la > 0)
                livingArea = la;

            decimal? kitchenArea = null;
            if (decimal.TryParse((txtKitchenArea.Content ?? "").Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal ka) && ka > 0)
                kitchenArea = ka;

            // Год постройки
            int? yearBuilt = null;
            if (int.TryParse((txtYearBuilt.Content ?? "").Trim(), out int yb) && yb >= 1800 && yb <= DateTime.Now.Year + 5)
                yearBuilt = yb;

            int? agentId = null;
            if (cmbAgent.SelectedItem is LookupItem aItem && aItem.Id > 0)
                agentId = aItem.Id;

            string district = cmbDistrict.Text?.Trim();
            if (string.IsNullOrWhiteSpace(district)) district = "Центр";

            string photo = string.IsNullOrWhiteSpace(cmbPhoto.Text) ? null : cmbPhoto.Text.Trim();

            var prop = new Property
            {
                Id = propertyId,
                Address = addr,
                District = district,
                TypeId = typeItem.Id,
                Rooms = rooms,
                Floor = floor,
                TotalFloors = totalFloors,
                Area = area,
                LivingArea = livingArea,
                KitchenArea = kitchenArea,
                YearBuilt = yearBuilt,
                Price = price,
                Status = cmbStatus.SelectedItem?.ToString() ?? PropertyStatus.Free,
                AgentId = agentId,
                Description = (txtDescription.Content ?? "").Trim(),
                Photo = photo
            };

            if (UiTheme.Try(() => PropertyService.Save(prop)))
            {
                UiTheme.Info("Данные объекта сохранены.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
