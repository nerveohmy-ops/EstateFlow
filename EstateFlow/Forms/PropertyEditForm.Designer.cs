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
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15.5F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(310, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Новый объект недвижимости";
            // 
            // lblAddrHeader
            // 
            lblAddrHeader.AutoSize = true;
            lblAddrHeader.Font = new Font("Segoe UI", 9F);
            lblAddrHeader.ForeColor = Color.DimGray;
            lblAddrHeader.Location = new Point(30, 48);
            lblAddrHeader.Name = "lblAddrHeader";
            lblAddrHeader.Size = new Size(385, 15);
            lblAddrHeader.TabIndex = 1;
            lblAddrHeader.Text = "Адрес и район (г. Благовещенск, Амурская область):";
            // 
            // txtCity
            // 
            txtCity.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtCity.Content = "г. Благовещенск";
            txtCity.Font = new Font("Segoe UI", 9.5F);
            txtCity.Location = new Point(30, 68);
            txtCity.Name = "txtCity";
            txtCity.Padding = new Padding(10, 10, 10, 0);
            txtCity.PlaceholderText = "Город";
            txtCity.Rounding = new Padding(10);
            txtCity.Size = new Size(160, 38);
            txtCity.TabIndex = 2;
            // 
            // cmbDistrict
            // 
            cmbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistrict.Font = new Font("Segoe UI", 9.5F);
            cmbDistrict.Location = new Point(200, 75);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Size = new Size(150, 25);
            cmbDistrict.TabIndex = 3;
            // 
            // txtStreet
            // 
            txtStreet.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtStreet.Content = "";
            txtStreet.Font = new Font("Segoe UI", 9.5F);
            txtStreet.Location = new Point(360, 68);
            txtStreet.Name = "txtStreet";
            txtStreet.Padding = new Padding(10, 10, 10, 0);
            txtStreet.PlaceholderText = "Улица / проспект";
            txtStreet.Rounding = new Padding(10);
            txtStreet.Size = new Size(270, 38);
            txtStreet.TabIndex = 4;
            // 
            // txtHouse
            // 
            txtHouse.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtHouse.Content = "";
            txtHouse.Font = new Font("Segoe UI", 9.5F);
            txtHouse.Location = new Point(640, 68);
            txtHouse.Name = "txtHouse";
            txtHouse.Padding = new Padding(10, 10, 10, 0);
            txtHouse.PlaceholderText = "Дом / корп.";
            txtHouse.Rounding = new Padding(10);
            txtHouse.Size = new Size(130, 38);
            txtHouse.TabIndex = 5;
            // 
            // txtApartment
            // 
            txtApartment.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtApartment.Content = "";
            txtApartment.Font = new Font("Segoe UI", 9.5F);
            txtApartment.Location = new Point(780, 68);
            txtApartment.Name = "txtApartment";
            txtApartment.Padding = new Padding(10, 10, 10, 0);
            txtApartment.PlaceholderText = "Кв. / оф.";
            txtApartment.Rounding = new Padding(10);
            txtApartment.Size = new Size(150, 38);
            txtApartment.TabIndex = 6;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 8.5F);
            lblType.Location = new Point(30, 116);
            lblType.Name = "lblType";
            lblType.Size = new Size(111, 15);
            lblType.TabIndex = 7;
            lblType.Text = "Тип недвижимости:";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 9.5F);
            cmbType.Location = new Point(30, 134);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(160, 25);
            cmbType.TabIndex = 8;
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Font = new Font("Segoe UI", 8.5F);
            lblRooms.Location = new Point(200, 116);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(52, 15);
            lblRooms.TabIndex = 9;
            lblRooms.Text = "Комнат:";
            // 
            // cmbRooms
            // 
            cmbRooms.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRooms.Font = new Font("Segoe UI", 9.5F);
            cmbRooms.Location = new Point(200, 134);
            cmbRooms.Name = "cmbRooms";
            cmbRooms.Size = new Size(150, 25);
            cmbRooms.TabIndex = 10;
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Font = new Font("Segoe UI", 8.5F);
            lblFloor.Location = new Point(360, 116);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(39, 15);
            lblFloor.TabIndex = 11;
            lblFloor.Text = "Этаж:";
            // 
            // txtFloor
            // 
            txtFloor.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtFloor.Content = "";
            txtFloor.Font = new Font("Segoe UI", 9.5F);
            txtFloor.Location = new Point(360, 132);
            txtFloor.Name = "txtFloor";
            txtFloor.Padding = new Padding(8, 8, 8, 0);
            txtFloor.PlaceholderText = "5";
            txtFloor.Rounding = new Padding(8);
            txtFloor.Size = new Size(80, 34);
            txtFloor.TabIndex = 12;
            // 
            // lblTotalFloors
            // 
            lblTotalFloors.AutoSize = true;
            lblTotalFloors.Font = new Font("Segoe UI", 8.5F);
            lblTotalFloors.Location = new Point(450, 116);
            lblTotalFloors.Name = "lblTotalFloors";
            lblTotalFloors.Size = new Size(79, 15);
            lblTotalFloors.TabIndex = 13;
            lblTotalFloors.Text = "Этажность:";
            // 
            // txtTotalFloors
            // 
            txtTotalFloors.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtTotalFloors.Content = "";
            txtTotalFloors.Font = new Font("Segoe UI", 9.5F);
            txtTotalFloors.Location = new Point(450, 132);
            txtTotalFloors.Name = "txtTotalFloors";
            txtTotalFloors.Padding = new Padding(8, 8, 8, 0);
            txtTotalFloors.PlaceholderText = "9";
            txtTotalFloors.Rounding = new Padding(8);
            txtTotalFloors.Size = new Size(95, 34);
            txtTotalFloors.TabIndex = 14;
            // 
            // lblYearBuilt
            // 
            lblYearBuilt.AutoSize = true;
            lblYearBuilt.Font = new Font("Segoe UI", 8.5F);
            lblYearBuilt.Location = new Point(555, 116);
            lblYearBuilt.Name = "lblYearBuilt";
            lblYearBuilt.Size = new Size(89, 15);
            lblYearBuilt.TabIndex = 15;
            lblYearBuilt.Text = "Год постройки:";
            // 
            // txtYearBuilt
            // 
            txtYearBuilt.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtYearBuilt.Content = "";
            txtYearBuilt.Font = new Font("Segoe UI", 9.5F);
            txtYearBuilt.Location = new Point(555, 132);
            txtYearBuilt.Name = "txtYearBuilt";
            txtYearBuilt.Padding = new Padding(8, 8, 8, 0);
            txtYearBuilt.PlaceholderText = "2021";
            txtYearBuilt.Rounding = new Padding(8);
            txtYearBuilt.Size = new Size(100, 34);
            txtYearBuilt.TabIndex = 16;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 8.5F);
            lblStatus.Location = new Point(665, 116);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 15);
            lblStatus.TabIndex = 17;
            lblStatus.Text = "Статус:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "Свободен", "Забронирован", "Продан" });
            cmbStatus.Location = new Point(665, 134);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(125, 25);
            cmbStatus.TabIndex = 18;
            // 
            // lblAgent
            // 
            lblAgent.AutoSize = true;
            lblAgent.Font = new Font("Segoe UI", 8.5F);
            lblAgent.Location = new Point(800, 116);
            lblAgent.Name = "lblAgent";
            lblAgent.Size = new Size(42, 15);
            lblAgent.TabIndex = 19;
            lblAgent.Text = "Агент:";
            // 
            // cmbAgent
            // 
            cmbAgent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAgent.Font = new Font("Segoe UI", 9.5F);
            cmbAgent.Location = new Point(800, 134);
            cmbAgent.Name = "cmbAgent";
            cmbAgent.Size = new Size(130, 25);
            cmbAgent.TabIndex = 20;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 8.5F);
            lblArea.Location = new Point(30, 178);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(101, 15);
            lblArea.TabIndex = 21;
            lblArea.Text = "Общая пл-дь (м²):";
            // 
            // txtArea
            // 
            txtArea.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtArea.Content = "";
            txtArea.Font = new Font("Segoe UI", 9.5F);
            txtArea.Location = new Point(30, 196);
            txtArea.Name = "txtArea";
            txtArea.Padding = new Padding(10, 10, 10, 0);
            txtArea.PlaceholderText = "58.4";
            txtArea.Rounding = new Padding(8);
            txtArea.Size = new Size(160, 36);
            txtArea.TabIndex = 22;
            // 
            // lblLivingArea
            // 
            lblLivingArea.AutoSize = true;
            lblLivingArea.Font = new Font("Segoe UI", 8.5F);
            lblLivingArea.Location = new Point(200, 178);
            lblLivingArea.Name = "lblLivingArea";
            lblLivingArea.Size = new Size(71, 15);
            lblLivingArea.TabIndex = 23;
            lblLivingArea.Text = "Жилая (м²):";
            // 
            // txtLivingArea
            // 
            txtLivingArea.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtLivingArea.Content = "";
            txtLivingArea.Font = new Font("Segoe UI", 9.5F);
            txtLivingArea.Location = new Point(200, 196);
            txtLivingArea.Name = "txtLivingArea";
            txtLivingArea.Padding = new Padding(10, 10, 10, 0);
            txtLivingArea.PlaceholderText = "34.0";
            txtLivingArea.Rounding = new Padding(8);
            txtLivingArea.Size = new Size(150, 36);
            txtLivingArea.TabIndex = 24;
            // 
            // lblKitchenArea
            // 
            lblKitchenArea.AutoSize = true;
            lblKitchenArea.Font = new Font("Segoe UI", 8.5F);
            lblKitchenArea.Location = new Point(360, 178);
            lblKitchenArea.Name = "lblKitchenArea";
            lblKitchenArea.Size = new Size(69, 15);
            lblKitchenArea.TabIndex = 25;
            lblKitchenArea.Text = "Кухня (м²):";
            // 
            // txtKitchenArea
            // 
            txtKitchenArea.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtKitchenArea.Content = "";
            txtKitchenArea.Font = new Font("Segoe UI", 9.5F);
            txtKitchenArea.Location = new Point(360, 196);
            txtKitchenArea.Name = "txtKitchenArea";
            txtKitchenArea.Padding = new Padding(10, 10, 10, 0);
            txtKitchenArea.PlaceholderText = "11.2";
            txtKitchenArea.Rounding = new Padding(8);
            txtKitchenArea.Size = new Size(140, 36);
            txtKitchenArea.TabIndex = 26;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 8.5F);
            lblPrice.Location = new Point(515, 178);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(86, 15);
            lblPrice.TabIndex = 27;
            lblPrice.Text = "Стоимость (₽):";
            // 
            // txtPrice
            // 
            txtPrice.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtPrice.Content = "";
            txtPrice.Font = new Font("Segoe UI", 9.5F);
            txtPrice.Location = new Point(515, 196);
            txtPrice.Name = "txtPrice";
            txtPrice.Padding = new Padding(10, 10, 10, 0);
            txtPrice.PlaceholderText = "8 900 000";
            txtPrice.Rounding = new Padding(8);
            txtPrice.Size = new Size(220, 36);
            txtPrice.TabIndex = 28;
            // 
            // lblPriceHint
            // 
            lblPriceHint.AutoSize = true;
            lblPriceHint.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            lblPriceHint.ForeColor = Color.FromArgb(70, 70, 70);
            lblPriceHint.Location = new Point(517, 235);
            lblPriceHint.Name = "lblPriceHint";
            lblPriceHint.Size = new Size(130, 13);
            lblPriceHint.TabIndex = 29;
            lblPriceHint.Text = "Например: 8 900 000 ₽";
            // 
            // lblPhoto
            // 
            lblPhoto.AutoSize = true;
            lblPhoto.Font = new Font("Segoe UI", 8.5F);
            lblPhoto.Location = new Point(750, 178);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new Size(76, 15);
            lblPhoto.TabIndex = 30;
            lblPhoto.Text = "Фотография:";
            // 
            // cmbPhoto
            // 
            cmbPhoto.DropDownStyle = ComboBoxStyle.DropDown;
            cmbPhoto.Font = new Font("Segoe UI", 9F);
            cmbPhoto.Location = new Point(750, 199);
            cmbPhoto.Name = "cmbPhoto";
            cmbPhoto.Size = new Size(115, 23);
            cmbPhoto.TabIndex = 31;
            // 
            // btnBrowsePhoto
            // 
            btnBrowsePhoto.CheckButton = false;
            btnBrowsePhoto.Checked = false;
            btnBrowsePhoto.Content = "Обзор...";
            btnBrowsePhoto.Cursor = Cursors.Hand;
            btnBrowsePhoto.Font = new Font("Segoe UI", 8.5F);
            btnBrowsePhoto.ForeColor = Color.Black;
            btnBrowsePhoto.Location = new Point(870, 197);
            btnBrowsePhoto.Name = "btnBrowsePhoto";
            btnBrowsePhoto.NormalBackground = Color.White;
            btnBrowsePhoto.NormalForeColor = Color.Black;
            btnBrowsePhoto.NormalOutline = Color.FromArgb(120, 120, 120);
            btnBrowsePhoto.OutlineThickness = 1F;
            btnBrowsePhoto.Padding = new Padding(4);
            btnBrowsePhoto.Rounding = new Padding(12);
            btnBrowsePhoto.Size = new Size(60, 32);
            btnBrowsePhoto.TabIndex = 32;
            btnBrowsePhoto.TextAlignment = StringAlignment.Center;
            btnBrowsePhoto.Click += btnBrowsePhoto_Click;
            // 
            // picPhotoPreview
            // 
            picPhotoPreview.BorderStyle = BorderStyle.FixedSingle;
            picPhotoPreview.Location = new Point(710, 255);
            picPhotoPreview.Name = "picPhotoPreview";
            picPhotoPreview.Size = new Size(220, 190);
            picPhotoPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPhotoPreview.TabIndex = 33;
            picPhotoPreview.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtDescription.Content = "";
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.Location = new Point(30, 255);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Padding = new Padding(12, 12, 12, 0);
            txtDescription.PlaceholderText = "Описание объекта: вид из окна, состояние, ремонт, инфраструктура, мебель, техника...";
            txtDescription.Rounding = new Padding(12);
            txtDescription.Size = new Size(665, 190);
            txtDescription.TabIndex = 34;
            // 
            // btnSave
            // 
            btnSave.CheckButton = false;
            btnSave.Checked = false;
            btnSave.Content = "Сохранить";
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(270, 465);
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
            btnCancel.CheckButton = false;
            btnCancel.Checked = false;
            btnCancel.Content = "Отмена";
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(490, 465);
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
            ClientSize = new Size(960, 530);
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
