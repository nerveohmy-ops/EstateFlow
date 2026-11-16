namespace EstateFlow.Forms
{
    partial class PropertyEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblAddrHeader = new Label();
            txtCity = new HartUI.Controls.cuiTextBox();
            cmbDistrict = new ComboBox();
            txtStreet = new HartUI.Controls.cuiTextBox();
            txtHouse = new HartUI.Controls.cuiTextBox();
            txtApartment = new HartUI.Controls.cuiTextBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblRooms = new Label();
            cmbRooms = new ComboBox();
            lblFloor = new Label();
            txtFloor = new HartUI.Controls.cuiTextBox();
            lblTotalFloors = new Label();
            txtTotalFloors = new HartUI.Controls.cuiTextBox();
            lblYearBuilt = new Label();
            txtYearBuilt = new HartUI.Controls.cuiTextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblAgent = new Label();
            cmbAgent = new ComboBox();
            lblArea = new Label();
            txtArea = new HartUI.Controls.cuiTextBox();
            lblLivingArea = new Label();
            txtLivingArea = new HartUI.Controls.cuiTextBox();
            lblKitchenArea = new Label();
            txtKitchenArea = new HartUI.Controls.cuiTextBox();
            lblPrice = new Label();
            txtPrice = new HartUI.Controls.cuiTextBox();
            lblPriceHint = new Label();
            lblPhoto = new Label();
            cmbPhoto = new ComboBox();
            btnBrowsePhoto = new HartUI.Controls.cuiButton();
            picPhotoPreview = new PictureBox();
            txtDescription = new HartUI.Controls.cuiTextBox();
            btnSave = new HartUI.Controls.cuiButton();
            btnCancel = new HartUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)picPhotoPreview).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15.5F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(42, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(310, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Новый объект недвижимости";
            // 
            // lblAddrHeader
            // 
            lblAddrHeader.Anchor = AnchorStyles.None;
            lblAddrHeader.AutoSize = true;
            lblAddrHeader.Font = new Font("Segoe UI", 9F);
            lblAddrHeader.ForeColor = Color.DimGray;
            lblAddrHeader.Location = new Point(42, 50);
            lblAddrHeader.Name = "lblAddrHeader";
            lblAddrHeader.Size = new Size(385, 15);
            lblAddrHeader.TabIndex = 1;
            lblAddrHeader.Text = "Адрес и район (г. Благовещенск, Амурская область):";
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.None;
            txtCity.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtCity.Content = "г. Благовещенск";
            txtCity.FocusBackgroundColor = Color.White;
            txtCity.FocusOutlineColor = Color.Black;
            txtCity.Font = new Font("Segoe UI", 9.5F);
            txtCity.ForeColor = Color.Black;
            txtCity.Location = new Point(42, 73);
            txtCity.Name = "txtCity";
            txtCity.OutlineColor = Color.FromArgb(95, 95, 95);
            txtCity.Padding = new Padding(10, 10, 10, 0);
            txtCity.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtCity.PlaceholderText = "Город";
            txtCity.Rounding = new Padding(10);
            txtCity.Size = new Size(160, 38);
            txtCity.TabIndex = 2;
            txtCity.UnderlinedStyle = false;
            // 
            // cmbDistrict
            // 
            cmbDistrict.Anchor = AnchorStyles.None;
            cmbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistrict.Font = new Font("Segoe UI", 9.5F);
            cmbDistrict.Location = new Point(212, 80);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Size = new Size(150, 25);
            cmbDistrict.TabIndex = 3;
            // 
            // txtStreet
            // 
            txtStreet.Anchor = AnchorStyles.None;
            txtStreet.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtStreet.Content = "";
            txtStreet.FocusBackgroundColor = Color.White;
            txtStreet.FocusOutlineColor = Color.Black;
            txtStreet.Font = new Font("Segoe UI", 9.5F);
            txtStreet.ForeColor = Color.Black;
            txtStreet.Location = new Point(372, 73);
            txtStreet.Name = "txtStreet";
            txtStreet.OutlineColor = Color.FromArgb(95, 95, 95);
            txtStreet.Padding = new Padding(10, 10, 10, 0);
            txtStreet.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtStreet.PlaceholderText = "Улица / проспект";
            txtStreet.Rounding = new Padding(10);
            txtStreet.Size = new Size(275, 38);
            txtStreet.TabIndex = 4;
            txtStreet.UnderlinedStyle = false;
            // 
            // txtHouse
            // 
            txtHouse.Anchor = AnchorStyles.None;
            txtHouse.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtHouse.Content = "";
            txtHouse.FocusBackgroundColor = Color.White;
            txtHouse.FocusOutlineColor = Color.Black;
            txtHouse.Font = new Font("Segoe UI", 9.5F);
            txtHouse.ForeColor = Color.Black;
            txtHouse.Location = new Point(657, 73);
            txtHouse.Name = "txtHouse";
            txtHouse.OutlineColor = Color.FromArgb(95, 95, 95);
            txtHouse.Padding = new Padding(10, 10, 10, 0);
            txtHouse.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtHouse.PlaceholderText = "Дом / корп.";
            txtHouse.Rounding = new Padding(10);
            txtHouse.Size = new Size(130, 38);
            txtHouse.TabIndex = 5;
            txtHouse.UnderlinedStyle = false;
            // 
            // txtApartment
            // 
            txtApartment.Anchor = AnchorStyles.None;
            txtApartment.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtApartment.Content = "";
            txtApartment.FocusBackgroundColor = Color.White;
            txtApartment.FocusOutlineColor = Color.Black;
            txtApartment.Font = new Font("Segoe UI", 9.5F);
            txtApartment.ForeColor = Color.Black;
            txtApartment.Location = new Point(797, 73);
            txtApartment.Name = "txtApartment";
            txtApartment.OutlineColor = Color.FromArgb(95, 95, 95);
            txtApartment.Padding = new Padding(10, 10, 10, 0);
            txtApartment.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtApartment.PlaceholderText = "Кв. / оф.";
            txtApartment.Rounding = new Padding(10);
            txtApartment.Size = new Size(145, 38);
            txtApartment.TabIndex = 6;
            txtApartment.UnderlinedStyle = false;
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.None;
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 8.5F);
            lblType.ForeColor = Color.Black;
            lblType.Location = new Point(42, 118);
            lblType.Name = "lblType";
            lblType.Size = new Size(111, 15);
            lblType.TabIndex = 7;
            lblType.Text = "Тип недвижимости:";
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.None;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 9.5F);
            cmbType.Location = new Point(42, 142);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(160, 25);
            cmbType.TabIndex = 8;
            // 
            // lblRooms
            // 
            lblRooms.Anchor = AnchorStyles.None;
            lblRooms.AutoSize = true;
            lblRooms.Font = new Font("Segoe UI", 8.5F);
            lblRooms.ForeColor = Color.Black;
            lblRooms.Location = new Point(212, 118);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(52, 15);
            lblRooms.TabIndex = 9;
            lblRooms.Text = "Комнат:";
            // 
            // cmbRooms
            // 
            cmbRooms.Anchor = AnchorStyles.None;
            cmbRooms.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRooms.Font = new Font("Segoe UI", 9.5F);
            cmbRooms.Location = new Point(212, 142);
            cmbRooms.Name = "cmbRooms";
            cmbRooms.Size = new Size(150, 25);
            cmbRooms.TabIndex = 10;
            // 
            // lblFloor
            // 
            lblFloor.Anchor = AnchorStyles.None;
            lblFloor.AutoSize = true;
            lblFloor.Font = new Font("Segoe UI", 8.5F);
            lblFloor.ForeColor = Color.Black;
            lblFloor.Location = new Point(372, 118);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(39, 15);
            lblFloor.TabIndex = 11;
            lblFloor.Text = "Этаж:";
            // 
            // txtFloor
            // 
            txtFloor.Anchor = AnchorStyles.None;
            txtFloor.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtFloor.Content = "";
            txtFloor.FocusBackgroundColor = Color.White;
            txtFloor.FocusOutlineColor = Color.Black;
            txtFloor.Font = new Font("Segoe UI", 9.5F);
            txtFloor.ForeColor = Color.Black;
            txtFloor.Location = new Point(372, 140);
            txtFloor.Name = "txtFloor";
            txtFloor.OutlineColor = Color.FromArgb(95, 95, 95);
            txtFloor.Padding = new Padding(8, 8, 8, 0);
            txtFloor.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtFloor.PlaceholderText = "5";
            txtFloor.Rounding = new Padding(8);
            txtFloor.Size = new Size(80, 34);
            txtFloor.TabIndex = 12;
            txtFloor.UnderlinedStyle = false;
            // 
            // lblTotalFloors
            // 
            lblTotalFloors.Anchor = AnchorStyles.None;
            lblTotalFloors.AutoSize = true;
            lblTotalFloors.Font = new Font("Segoe UI", 8.5F);
            lblTotalFloors.ForeColor = Color.Black;
            lblTotalFloors.Location = new Point(462, 118);
            lblTotalFloors.Name = "lblTotalFloors";
            lblTotalFloors.Size = new Size(79, 15);
            lblTotalFloors.TabIndex = 13;
            lblTotalFloors.Text = "Этажность:";
            // 
            // txtTotalFloors
            // 
            txtTotalFloors.Anchor = AnchorStyles.None;
            txtTotalFloors.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtTotalFloors.Content = "";
            txtTotalFloors.FocusBackgroundColor = Color.White;
            txtTotalFloors.FocusOutlineColor = Color.Black;
            txtTotalFloors.Font = new Font("Segoe UI", 9.5F);
            txtTotalFloors.ForeColor = Color.Black;
            txtTotalFloors.Location = new Point(462, 140);
            txtTotalFloors.Name = "txtTotalFloors";
            txtTotalFloors.OutlineColor = Color.FromArgb(95, 95, 95);
            txtTotalFloors.Padding = new Padding(8, 8, 8, 0);
            txtTotalFloors.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtTotalFloors.PlaceholderText = "9";
            txtTotalFloors.Rounding = new Padding(8);
            txtTotalFloors.Size = new Size(95, 34);
            txtTotalFloors.TabIndex = 14;
            txtTotalFloors.UnderlinedStyle = false;
            // 
            // lblYearBuilt
            // 
            lblYearBuilt.Anchor = AnchorStyles.None;
            lblYearBuilt.AutoSize = true;
            lblYearBuilt.Font = new Font("Segoe UI", 8.5F);
            lblYearBuilt.ForeColor = Color.Black;
            lblYearBuilt.Location = new Point(567, 118);
            lblYearBuilt.Name = "lblYearBuilt";
            lblYearBuilt.Size = new Size(89, 15);
            lblYearBuilt.TabIndex = 15;
            lblYearBuilt.Text = "Год постройки:";
            // 
            // txtYearBuilt
            // 
            txtYearBuilt.Anchor = AnchorStyles.None;
            txtYearBuilt.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtYearBuilt.Content = "";
            txtYearBuilt.FocusBackgroundColor = Color.White;
            txtYearBuilt.FocusOutlineColor = Color.Black;
            txtYearBuilt.Font = new Font("Segoe UI", 9.5F);
            txtYearBuilt.ForeColor = Color.Black;
            txtYearBuilt.Location = new Point(567, 140);
            txtYearBuilt.Name = "txtYearBuilt";
            txtYearBuilt.OutlineColor = Color.FromArgb(95, 95, 95);
            txtYearBuilt.Padding = new Padding(8, 8, 8, 0);
            txtYearBuilt.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtYearBuilt.PlaceholderText = "2021";
            txtYearBuilt.Rounding = new Padding(8);
            txtYearBuilt.Size = new Size(100, 34);
            txtYearBuilt.TabIndex = 16;
            txtYearBuilt.UnderlinedStyle = false;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.None;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 8.5F);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(677, 118);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 15);
            lblStatus.TabIndex = 17;
            lblStatus.Text = "Статус:";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.None;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "Свободен", "Забронирован", "Продан" });
            cmbStatus.Location = new Point(677, 142);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(125, 25);
            cmbStatus.TabIndex = 18;
            // 
            // lblAgent
            // 
            lblAgent.Anchor = AnchorStyles.None;
            lblAgent.AutoSize = true;
            lblAgent.Font = new Font("Segoe UI", 8.5F);
            lblAgent.ForeColor = Color.Black;
            lblAgent.Location = new Point(812, 118);
            lblAgent.Name = "lblAgent";
            lblAgent.Size = new Size(42, 15);
            lblAgent.TabIndex = 19;
            lblAgent.Text = "Агент:";
            // 
            // cmbAgent
            // 
            cmbAgent.Anchor = AnchorStyles.None;
            cmbAgent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAgent.Font = new Font("Segoe UI", 9.5F);
            cmbAgent.Location = new Point(812, 142);
            cmbAgent.Name = "cmbAgent";
            cmbAgent.Size = new Size(130, 25);
            cmbAgent.TabIndex = 20;
            // 
            // lblArea
            // 
            lblArea.Anchor = AnchorStyles.None;
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 8.5F);
            lblArea.ForeColor = Color.Black;
            lblArea.Location = new Point(42, 182);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(101, 15);
            lblArea.TabIndex = 21;
            lblArea.Text = "Общая пл-дь (м²):";
            // 
            // txtArea
            // 
            txtArea.Anchor = AnchorStyles.None;
            txtArea.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtArea.Content = "";
            txtArea.FocusBackgroundColor = Color.White;
            txtArea.FocusOutlineColor = Color.Black;
            txtArea.Font = new Font("Segoe UI", 9.5F);
            txtArea.ForeColor = Color.Black;
            txtArea.Location = new Point(42, 204);
            txtArea.Name = "txtArea";
            txtArea.OutlineColor = Color.FromArgb(95, 95, 95);
            txtArea.Padding = new Padding(10, 10, 10, 0);
            txtArea.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtArea.PlaceholderText = "58.4";
            txtArea.Rounding = new Padding(8);
            txtArea.Size = new Size(148, 36);
            txtArea.TabIndex = 22;
            txtArea.UnderlinedStyle = false;
            // 
            // lblLivingArea
            // 
            lblLivingArea.Anchor = AnchorStyles.None;
            lblLivingArea.AutoSize = true;
            lblLivingArea.Font = new Font("Segoe UI", 8.5F);
            lblLivingArea.ForeColor = Color.Black;
            lblLivingArea.Location = new Point(200, 182);
            lblLivingArea.Name = "lblLivingArea";
            lblLivingArea.Size = new Size(71, 15);
            lblLivingArea.TabIndex = 23;
            lblLivingArea.Text = "Жилая (м²):";
            // 
            // txtLivingArea
            // 
            txtLivingArea.Anchor = AnchorStyles.None;
            txtLivingArea.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtLivingArea.Content = "";
            txtLivingArea.FocusBackgroundColor = Color.White;
            txtLivingArea.FocusOutlineColor = Color.Black;
            txtLivingArea.Font = new Font("Segoe UI", 9.5F);
            txtLivingArea.ForeColor = Color.Black;
            txtLivingArea.Location = new Point(200, 204);
            txtLivingArea.Name = "txtLivingArea";
            txtLivingArea.OutlineColor = Color.FromArgb(95, 95, 95);
            txtLivingArea.Padding = new Padding(10, 10, 10, 0);
            txtLivingArea.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtLivingArea.PlaceholderText = "34.0";
            txtLivingArea.Rounding = new Padding(8);
            txtLivingArea.Size = new Size(140, 36);
            txtLivingArea.TabIndex = 24;
            txtLivingArea.UnderlinedStyle = false;
            // 
            // lblKitchenArea
            // 
            lblKitchenArea.Anchor = AnchorStyles.None;
            lblKitchenArea.AutoSize = true;
            lblKitchenArea.Font = new Font("Segoe UI", 8.5F);
            lblKitchenArea.ForeColor = Color.Black;
            lblKitchenArea.Location = new Point(350, 182);
            lblKitchenArea.Name = "lblKitchenArea";
            lblKitchenArea.Size = new Size(69, 15);
            lblKitchenArea.TabIndex = 25;
            lblKitchenArea.Text = "Кухня (м²):";
            // 
            // txtKitchenArea
            // 
            txtKitchenArea.Anchor = AnchorStyles.None;
            txtKitchenArea.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtKitchenArea.Content = "";
            txtKitchenArea.FocusBackgroundColor = Color.White;
            txtKitchenArea.FocusOutlineColor = Color.Black;
            txtKitchenArea.Font = new Font("Segoe UI", 9.5F);
            txtKitchenArea.ForeColor = Color.Black;
            txtKitchenArea.Location = new Point(350, 204);
            txtKitchenArea.Name = "txtKitchenArea";
            txtKitchenArea.OutlineColor = Color.FromArgb(95, 95, 95);
            txtKitchenArea.Padding = new Padding(10, 10, 10, 0);
            txtKitchenArea.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtKitchenArea.PlaceholderText = "11.2";
            txtKitchenArea.Rounding = new Padding(8);
            txtKitchenArea.Size = new Size(132, 36);
            txtKitchenArea.TabIndex = 26;
            txtKitchenArea.UnderlinedStyle = false;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.None;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 8.5F);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(492, 182);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(86, 15);
            lblPrice.TabIndex = 27;
            lblPrice.Text = "Стоимость (₽):";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtPrice.Content = "";
            txtPrice.FocusBackgroundColor = Color.White;
            txtPrice.FocusOutlineColor = Color.Black;
            txtPrice.Font = new Font("Segoe UI", 9.5F);
            txtPrice.ForeColor = Color.Black;
            txtPrice.Location = new Point(492, 204);
            txtPrice.Name = "txtPrice";
            txtPrice.OutlineColor = Color.FromArgb(95, 95, 95);
            txtPrice.Padding = new Padding(10, 10, 10, 0);
            txtPrice.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtPrice.PlaceholderText = "8 900 000";
            txtPrice.Rounding = new Padding(8);
            txtPrice.Size = new Size(220, 36);
            txtPrice.TabIndex = 28;
            txtPrice.UnderlinedStyle = false;
            // 
            // lblPriceHint
            // 
            lblPriceHint.Anchor = AnchorStyles.None;
            lblPriceHint.AutoSize = true;
            lblPriceHint.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            lblPriceHint.ForeColor = Color.DimGray;
            lblPriceHint.Location = new Point(494, 243);
            lblPriceHint.Name = "lblPriceHint";
            lblPriceHint.Size = new Size(130, 13);
            lblPriceHint.TabIndex = 29;
            lblPriceHint.Text = "Например: 8 900 000 ₽";
            // 
            // lblPhoto
            // 
            lblPhoto.Anchor = AnchorStyles.None;
            lblPhoto.AutoSize = true;
            lblPhoto.Font = new Font("Segoe UI", 8.5F);
            lblPhoto.ForeColor = Color.Black;
            lblPhoto.Location = new Point(722, 182);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new Size(76, 15);
            lblPhoto.TabIndex = 30;
            lblPhoto.Text = "Фотография:";
            // 
            // cmbPhoto
            // 
            cmbPhoto.Anchor = AnchorStyles.None;
            cmbPhoto.DropDownStyle = ComboBoxStyle.DropDown;
            cmbPhoto.Font = new Font("Segoe UI", 9F);
            cmbPhoto.Location = new Point(722, 207);
            cmbPhoto.Name = "cmbPhoto";
            cmbPhoto.Size = new Size(130, 23);
            cmbPhoto.TabIndex = 31;
            // 
            // btnBrowsePhoto
            // 
            btnBrowsePhoto.Anchor = AnchorStyles.None;
            btnBrowsePhoto.CheckButton = false;
            btnBrowsePhoto.Checked = false;
            btnBrowsePhoto.Content = "Обзор...";
            btnBrowsePhoto.Cursor = Cursors.Hand;
            btnBrowsePhoto.Font = new Font("Segoe UI", 8.5F);
            btnBrowsePhoto.ForeColor = Color.Black;
            btnBrowsePhoto.Location = new Point(858, 205);
            btnBrowsePhoto.Name = "btnBrowsePhoto";
            btnBrowsePhoto.NormalBackground = Color.White;
            btnBrowsePhoto.NormalForeColor = Color.Black;
            btnBrowsePhoto.NormalOutline = Color.FromArgb(120, 120, 120);
            btnBrowsePhoto.OutlineThickness = 1F;
            btnBrowsePhoto.Padding = new Padding(2);
            btnBrowsePhoto.Rounding = new Padding(12);
            btnBrowsePhoto.Size = new Size(84, 34);
            btnBrowsePhoto.TabIndex = 32;
            btnBrowsePhoto.TextAlignment = StringAlignment.Center;
            btnBrowsePhoto.TextPadding = 2;
            btnBrowsePhoto.Click += btnBrowsePhoto_Click;
            // 
            // picPhotoPreview
            // 
            picPhotoPreview.Anchor = AnchorStyles.None;
            picPhotoPreview.BorderStyle = BorderStyle.FixedSingle;
            picPhotoPreview.Location = new Point(722, 264);
            picPhotoPreview.Name = "picPhotoPreview";
            picPhotoPreview.Size = new Size(220, 184);
            picPhotoPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPhotoPreview.TabIndex = 33;
            picPhotoPreview.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.None;
            txtDescription.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtDescription.Content = "";
            txtDescription.FocusBackgroundColor = Color.White;
            txtDescription.FocusOutlineColor = Color.Black;
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(42, 264);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.OutlineColor = Color.FromArgb(95, 95, 95);
            txtDescription.Padding = new Padding(12, 12, 12, 0);
            txtDescription.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtDescription.PlaceholderText = "Описание объекта: вид из окна, состояние, ремонт, инфраструктура, мебель, техника...";
            txtDescription.Rounding = new Padding(12);
            txtDescription.Size = new Size(668, 184);
            txtDescription.TabIndex = 34;
            txtDescription.UnderlinedStyle = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.CheckButton = false;
            btnSave.Checked = false;
            btnSave.Content = "Сохранить";
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(282, 468);
            btnSave.Name = "btnSave";
            btnSave.NormalBackground = Color.Black;
            btnSave.NormalForeColor = Color.White;
            btnSave.NormalOutline = Color.Black;
            btnSave.OutlineThickness = 1F;
            btnSave.Padding = new Padding(10);
            btnSave.Rounding = new Padding(20);
            btnSave.Size = new Size(200, 42);
            btnSave.TabIndex = 35;
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.CheckButton = false;
            btnCancel.Checked = false;
            btnCancel.Content = "Отмена";
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(502, 468);
            btnCancel.Name = "btnCancel";
            btnCancel.NormalBackground = Color.White;
            btnCancel.NormalForeColor = Color.Black;
            btnCancel.NormalOutline = Color.Black;
            btnCancel.OutlineThickness = 1F;
            btnCancel.Padding = new Padding(10);
            btnCancel.Rounding = new Padding(20);
            btnCancel.Size = new Size(200, 42);
            btnCancel.TabIndex = 36;
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
            // 
            // PropertyEditForm
            // 
            ClientSize = new Size(984, 530);
            MinimumSize = new Size(1000, 569);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(picPhotoPreview);
            Controls.Add(btnBrowsePhoto);
            Controls.Add(cmbPhoto);
            Controls.Add(lblPhoto);
            Controls.Add(lblPriceHint);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtKitchenArea);
            Controls.Add(lblKitchenArea);
            Controls.Add(txtLivingArea);
            Controls.Add(lblLivingArea);
            Controls.Add(txtArea);
            Controls.Add(lblArea);
            Controls.Add(cmbAgent);
            Controls.Add(lblAgent);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(txtYearBuilt);
            Controls.Add(lblYearBuilt);
            Controls.Add(txtTotalFloors);
            Controls.Add(lblTotalFloors);
            Controls.Add(txtFloor);
            Controls.Add(lblFloor);
            Controls.Add(cmbRooms);
            Controls.Add(lblRooms);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(txtApartment);
            Controls.Add(txtHouse);
            Controls.Add(txtStreet);
            Controls.Add(cmbDistrict);
            Controls.Add(txtCity);
            Controls.Add(lblAddrHeader);
            Controls.Add(lblTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PropertyEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Объект недвижимости — EstateFlow";
            ((System.ComponentModel.ISupportInitialize)picPhotoPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAddrHeader;
        private HartUI.Controls.cuiTextBox txtCity;
        private ComboBox cmbDistrict;
        private HartUI.Controls.cuiTextBox txtStreet;
        private HartUI.Controls.cuiTextBox txtHouse;
        private HartUI.Controls.cuiTextBox txtApartment;
        private Label lblType;
        private ComboBox cmbType;
        private Label lblRooms;
        private ComboBox cmbRooms;
        private Label lblFloor;
        private HartUI.Controls.cuiTextBox txtFloor;
        private Label lblTotalFloors;
        private HartUI.Controls.cuiTextBox txtTotalFloors;
        private Label lblYearBuilt;
        private HartUI.Controls.cuiTextBox txtYearBuilt;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblAgent;
        private ComboBox cmbAgent;
        private Label lblArea;
        private HartUI.Controls.cuiTextBox txtArea;
        private Label lblLivingArea;
        private HartUI.Controls.cuiTextBox txtLivingArea;
        private Label lblKitchenArea;
        private HartUI.Controls.cuiTextBox txtKitchenArea;
        private Label lblPrice;
        private HartUI.Controls.cuiTextBox txtPrice;
        private Label lblPriceHint;
        private Label lblPhoto;
        private ComboBox cmbPhoto;
        private HartUI.Controls.cuiButton btnBrowsePhoto;
        private PictureBox picPhotoPreview;
        private HartUI.Controls.cuiTextBox txtDescription;
        private HartUI.Controls.cuiButton btnSave;
        private HartUI.Controls.cuiButton btnCancel;
    }
}
