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
            txtStreet = new HartUI.Controls.cuiTextBox();
            txtHouse = new HartUI.Controls.cuiTextBox();
            txtApartment = new HartUI.Controls.cuiTextBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblArea = new Label();
            txtArea = new HartUI.Controls.cuiTextBox();
            lblPrice = new Label();
            txtPrice = new HartUI.Controls.cuiTextBox();
            lblPriceHint = new Label();
            lblAgent = new Label();
            cmbAgent = new ComboBox();
            txtDescription = new HartUI.Controls.cuiTextBox();
            btnSave = new HartUI.Controls.cuiButton();
            btnCancel = new HartUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.5F, FontStyle.Bold);
            lblTitle.Location = new Point(200, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Новый объект недвижимости";
            // 
            // lblAddrHeader
            // 
            lblAddrHeader.Anchor = AnchorStyles.None;
            lblAddrHeader.AutoSize = true;
            lblAddrHeader.BackColor = Color.White;
            lblAddrHeader.Font = new Font("Segoe UI", 9F);
            lblAddrHeader.ForeColor = Color.FromArgb(60, 60, 60);
            lblAddrHeader.Location = new Point(200, 52);
            lblAddrHeader.Name = "lblAddrHeader";
            lblAddrHeader.Size = new Size(340, 15);
            lblAddrHeader.TabIndex = 1;
            lblAddrHeader.Text = "Адрес объекта (город, улица, дом, квартира/офис):";
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.None;
            txtCity.BackColor = Color.White;
            txtCity.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtCity.Content = "";
            txtCity.FocusBackgroundColor = Color.White;
            txtCity.FocusImageTint = Color.White;
            txtCity.FocusOutlineColor = Color.Black;
            txtCity.Font = new Font("Segoe UI", 9.5F);
            txtCity.ForeColor = Color.Black;
            txtCity.Location = new Point(200, 71);
            txtCity.Name = "txtCity";
            txtCity.NormalImageTint = Color.White;
            txtCity.OutlineColor = Color.FromArgb(95, 95, 95);
            txtCity.Padding = new Padding(12, 12, 12, 0);
            txtCity.PasswordChar = false;
            txtCity.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtCity.PlaceholderText = "Город (напр. Самара)";
            txtCity.Rounding = new Padding(12);
            txtCity.Size = new Size(178, 42);
            txtCity.TabIndex = 2;
            txtCity.UnderlinedStyle = false;
            // 
            // txtStreet
            // 
            txtStreet.Anchor = AnchorStyles.None;
            txtStreet.BackColor = Color.White;
            txtStreet.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtStreet.Content = "";
            txtStreet.FocusBackgroundColor = Color.White;
            txtStreet.FocusImageTint = Color.White;
            txtStreet.FocusOutlineColor = Color.Black;
            txtStreet.Font = new Font("Segoe UI", 9.5F);
            txtStreet.ForeColor = Color.Black;
            txtStreet.Location = new Point(386, 71);
            txtStreet.Name = "txtStreet";
            txtStreet.NormalImageTint = Color.White;
            txtStreet.OutlineColor = Color.FromArgb(95, 95, 95);
            txtStreet.Padding = new Padding(12, 12, 12, 0);
            txtStreet.PasswordChar = false;
            txtStreet.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtStreet.PlaceholderText = "Улица / проспект";
            txtStreet.Rounding = new Padding(12);
            txtStreet.Size = new Size(194, 42);
            txtStreet.TabIndex = 3;
            txtStreet.UnderlinedStyle = false;
            // 
            // txtHouse
            // 
            txtHouse.Anchor = AnchorStyles.None;
            txtHouse.BackColor = Color.White;
            txtHouse.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtHouse.Content = "";
            txtHouse.FocusBackgroundColor = Color.White;
            txtHouse.FocusImageTint = Color.White;
            txtHouse.FocusOutlineColor = Color.Black;
            txtHouse.Font = new Font("Segoe UI", 9.5F);
            txtHouse.ForeColor = Color.Black;
            txtHouse.Location = new Point(588, 71);
            txtHouse.Name = "txtHouse";
            txtHouse.NormalImageTint = Color.White;
            txtHouse.OutlineColor = Color.FromArgb(95, 95, 95);
            txtHouse.Padding = new Padding(12, 12, 12, 0);
            txtHouse.PasswordChar = false;
            txtHouse.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtHouse.PlaceholderText = "Дом / уч.";
            txtHouse.Rounding = new Padding(12);
            txtHouse.Size = new Size(94, 42);
            txtHouse.TabIndex = 4;
            txtHouse.UnderlinedStyle = false;
            // 
            // txtApartment
            // 
            txtApartment.Anchor = AnchorStyles.None;
            txtApartment.BackColor = Color.White;
            txtApartment.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtApartment.Content = "";
            txtApartment.FocusBackgroundColor = Color.White;
            txtApartment.FocusImageTint = Color.White;
            txtApartment.FocusOutlineColor = Color.Black;
            txtApartment.Font = new Font("Segoe UI", 9.5F);
            txtApartment.ForeColor = Color.Black;
            txtApartment.Location = new Point(690, 71);
            txtApartment.Name = "txtApartment";
            txtApartment.NormalImageTint = Color.White;
            txtApartment.OutlineColor = Color.FromArgb(95, 95, 95);
            txtApartment.Padding = new Padding(12, 12, 12, 0);
            txtApartment.PasswordChar = false;
            txtApartment.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtApartment.PlaceholderText = "Кв. / оф.";
            txtApartment.Rounding = new Padding(12);
            txtApartment.Size = new Size(94, 42);
            txtApartment.TabIndex = 5;
            txtApartment.UnderlinedStyle = false;
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.None;
            lblType.AutoSize = true;
            lblType.BackColor = Color.White;
            lblType.Font = new Font("Segoe UI", 9F);
            lblType.ForeColor = Color.FromArgb(60, 60, 60);
            lblType.Location = new Point(200, 120);
            lblType.Name = "lblType";
            lblType.Size = new Size(118, 15);
            lblType.TabIndex = 6;
            lblType.Text = "Тип недвижимости:";
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.None;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 9.5F);
            cmbType.Location = new Point(200, 139);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(284, 25);
            cmbType.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.None;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.FromArgb(60, 60, 60);
            lblStatus.Location = new Point(500, 120);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Статус объекта:";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.None;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "Свободен", "Забронирован", "Продан" });
            cmbStatus.Location = new Point(500, 139);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(284, 25);
            cmbStatus.TabIndex = 9;
            // 
            // lblArea
            // 
            lblArea.Anchor = AnchorStyles.None;
            lblArea.AutoSize = true;
            lblArea.BackColor = Color.White;
            lblArea.Font = new Font("Segoe UI", 9F);
            lblArea.ForeColor = Color.FromArgb(60, 60, 60);
            lblArea.Location = new Point(200, 171);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(95, 15);
            lblArea.TabIndex = 10;
            lblArea.Text = "Площадь (м²):";
            // 
            // txtArea
            // 
            txtArea.Anchor = AnchorStyles.None;
            txtArea.BackColor = Color.White;
            txtArea.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtArea.Content = "";
            txtArea.FocusBackgroundColor = Color.White;
            txtArea.FocusImageTint = Color.White;
            txtArea.FocusOutlineColor = Color.Black;
            txtArea.Font = new Font("Segoe UI", 9.5F);
            txtArea.ForeColor = Color.Black;
            txtArea.Location = new Point(200, 190);
            txtArea.Name = "txtArea";
            txtArea.NormalImageTint = Color.White;
            txtArea.OutlineColor = Color.FromArgb(95, 95, 95);
            txtArea.Padding = new Padding(12, 12, 12, 0);
            txtArea.PasswordChar = false;
            txtArea.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtArea.PlaceholderText = "Например: 64,5";
            txtArea.Rounding = new Padding(12);
            txtArea.Size = new Size(284, 42);
            txtArea.TabIndex = 11;
            txtArea.UnderlinedStyle = false;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.None;
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.White;
            lblPrice.Font = new Font("Segoe UI", 9F);
            lblPrice.ForeColor = Color.FromArgb(60, 60, 60);
            lblPrice.Location = new Point(500, 171);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(105, 15);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "Стоимость (₽):";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.BackColor = Color.White;
            txtPrice.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtPrice.Content = "";
            txtPrice.FocusBackgroundColor = Color.White;
            txtPrice.FocusImageTint = Color.White;
            txtPrice.FocusOutlineColor = Color.Black;
            txtPrice.Font = new Font("Segoe UI", 9.5F);
            txtPrice.ForeColor = Color.Black;
            txtPrice.Location = new Point(500, 190);
            txtPrice.Name = "txtPrice";
            txtPrice.NormalImageTint = Color.White;
            txtPrice.OutlineColor = Color.FromArgb(95, 95, 95);
            txtPrice.Padding = new Padding(12, 12, 12, 0);
            txtPrice.PasswordChar = false;
            txtPrice.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtPrice.PlaceholderText = "Сумма в рублях (напр. 7 800 000)";
            txtPrice.Rounding = new Padding(12);
            txtPrice.Size = new Size(284, 42);
            txtPrice.TabIndex = 13;
            txtPrice.UnderlinedStyle = false;
            // 
            // lblPriceHint
            // 
            lblPriceHint.Anchor = AnchorStyles.None;
            lblPriceHint.AutoSize = true;
            lblPriceHint.BackColor = Color.White;
            lblPriceHint.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblPriceHint.ForeColor = Color.FromArgb(50, 50, 50);
            lblPriceHint.Location = new Point(502, 234);
            lblPriceHint.Name = "lblPriceHint";
            lblPriceHint.Size = new Size(210, 15);
            lblPriceHint.TabIndex = 14;
            lblPriceHint.Text = "Например: 7 800 000 (= 7,8 млн ₽)";
            // 
            // lblAgent
            // 
            lblAgent.Anchor = AnchorStyles.None;
            lblAgent.AutoSize = true;
            lblAgent.BackColor = Color.White;
            lblAgent.Font = new Font("Segoe UI", 9F);
            lblAgent.ForeColor = Color.FromArgb(60, 60, 60);
            lblAgent.Location = new Point(200, 252);
            lblAgent.Name = "lblAgent";
            lblAgent.Size = new Size(130, 15);
            lblAgent.TabIndex = 15;
            lblAgent.Text = "Ответственный агент:";
            // 
            // cmbAgent
            // 
            cmbAgent.Anchor = AnchorStyles.None;
            cmbAgent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAgent.Font = new Font("Segoe UI", 9.5F);
            cmbAgent.Location = new Point(200, 271);
            cmbAgent.Name = "cmbAgent";
            cmbAgent.Size = new Size(584, 25);
            cmbAgent.TabIndex = 16;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.None;
            txtDescription.BackColor = Color.White;
            txtDescription.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtDescription.Content = "";
            txtDescription.FocusBackgroundColor = Color.White;
            txtDescription.FocusImageTint = Color.White;
            txtDescription.FocusOutlineColor = Color.Black;
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(200, 308);
            txtDescription.Name = "txtDescription";
            txtDescription.NormalImageTint = Color.White;
            txtDescription.OutlineColor = Color.FromArgb(95, 95, 95);
            txtDescription.Padding = new Padding(12, 12, 12, 0);
            txtDescription.PasswordChar = false;
            txtDescription.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtDescription.PlaceholderText = "Описание (количество комнат, этаж, ремонт, особенности)";
            txtDescription.Rounding = new Padding(12);
            txtDescription.Size = new Size(584, 42);
            txtDescription.TabIndex = 17;
            txtDescription.UnderlinedStyle = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.White;
            btnSave.CheckButton = false;
            btnSave.Checked = false;
            btnSave.Content = "Сохранить";
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 10.5F);
            btnSave.ForeColor = Color.White;
            btnSave.HoverBackground = Color.FromArgb(40, 40, 40);
            btnSave.HoverForeColor = Color.White;
            btnSave.HoverOutline = Color.Black;
            btnSave.Location = new Point(200, 368);
            btnSave.Name = "btnSave";
            btnSave.NormalBackground = Color.Black;
            btnSave.NormalForeColor = Color.White;
            btnSave.NormalOutline = Color.Black;
            btnSave.OutlineThickness = 1F;
            btnSave.Padding = new Padding(12);
            btnSave.PressedBackground = Color.WhiteSmoke;
            btnSave.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSave.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSave.Rounding = new Padding(20);
            btnSave.Size = new Size(284, 44);
            btnSave.TabIndex = 18;
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.White;
            btnCancel.CheckButton = false;
            btnCancel.Checked = false;
            btnCancel.Content = "Назад";
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10.5F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.HoverBackground = Color.FromArgb(242, 242, 242);
            btnCancel.HoverForeColor = Color.Black;
            btnCancel.HoverOutline = Color.Black;
            btnCancel.Location = new Point(500, 368);
            btnCancel.Name = "btnCancel";
            btnCancel.NormalBackground = Color.White;
            btnCancel.NormalForeColor = Color.Black;
            btnCancel.NormalOutline = Color.Black;
            btnCancel.OutlineThickness = 1F;
            btnCancel.Padding = new Padding(12);
            btnCancel.PressedBackground = Color.WhiteSmoke;
            btnCancel.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCancel.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancel.Rounding = new Padding(20);
            btnCancel.Size = new Size(284, 44);
            btnCancel.TabIndex = 19;
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
            // 
            // PropertyEditForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(cmbAgent);
            Controls.Add(lblAgent);
            Controls.Add(lblPriceHint);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtArea);
            Controls.Add(lblArea);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(txtApartment);
            Controls.Add(txtHouse);
            Controls.Add(txtStreet);
            Controls.Add(txtCity);
            Controls.Add(lblAddrHeader);
            Controls.Add(lblTitle);
            DoubleBuffered = true;
            Name = "PropertyEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Объект недвижимости — EstateFlow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAddrHeader;
        private HartUI.Controls.cuiTextBox txtCity;
        private HartUI.Controls.cuiTextBox txtStreet;
        private HartUI.Controls.cuiTextBox txtHouse;
        private HartUI.Controls.cuiTextBox txtApartment;
        private Label lblType;
        private ComboBox cmbType;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblArea;
        private HartUI.Controls.cuiTextBox txtArea;
        private Label lblPrice;
        private HartUI.Controls.cuiTextBox txtPrice;
        private Label lblPriceHint;
        private Label lblAgent;
        private ComboBox cmbAgent;
        private HartUI.Controls.cuiTextBox txtDescription;
        private HartUI.Controls.cuiButton btnSave;
        private HartUI.Controls.cuiButton btnCancel;
    }
}
