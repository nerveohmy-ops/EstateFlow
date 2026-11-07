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
            txtAddress = new HartUI.Controls.cuiTextBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            txtArea = new HartUI.Controls.cuiTextBox();
            txtPrice = new HartUI.Controls.cuiTextBox();
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
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F);
            lblTitle.Location = new Point(216, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(342, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Новый объект недвижимости";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.None;
            txtAddress.BackColor = Color.White;
            txtAddress.BackgroundColor = Color.White;
            txtAddress.Content = "";
            txtAddress.FocusBackgroundColor = Color.White;
            txtAddress.FocusImageTint = Color.White;
            txtAddress.FocusOutlineColor = Color.Black;
            txtAddress.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(216, 70);
            txtAddress.Name = "txtAddress";
            txtAddress.NormalImageTint = Color.White;
            txtAddress.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtAddress.Padding = new Padding(16, 14, 16, 0);
            txtAddress.PasswordChar = false;
            txtAddress.PlaceholderColor = Color.LightGray;
            txtAddress.PlaceholderText = "Адрес объекта (город, улица, дом, кв.)";
            txtAddress.Rounding = new Padding(20);
            txtAddress.Size = new Size(552, 45);
            txtAddress.TabIndex = 1;
            txtAddress.UnderlinedStyle = true;
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.None;
            lblType.AutoSize = true;
            lblType.BackColor = Color.White;
            lblType.Font = new Font("Segoe UI", 9F);
            lblType.Location = new Point(220, 125);
            lblType.Name = "lblType";
            lblType.Size = new Size(118, 15);
            lblType.TabIndex = 2;
            lblType.Text = "Тип недвижимости:";
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.None;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 9.5F);
            cmbType.Location = new Point(220, 146);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(262, 25);
            cmbType.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.None;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.Location = new Point(504, 125);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Статус объекта:";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.None;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "Свободен", "Забронирован", "Продан" });
            cmbStatus.Location = new Point(504, 146);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(262, 25);
            cmbStatus.TabIndex = 5;
            // 
            // txtArea
            // 
            txtArea.Anchor = AnchorStyles.None;
            txtArea.BackColor = Color.White;
            txtArea.BackgroundColor = Color.White;
            txtArea.Content = "";
            txtArea.FocusBackgroundColor = Color.White;
            txtArea.FocusImageTint = Color.White;
            txtArea.FocusOutlineColor = Color.Black;
            txtArea.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArea.ForeColor = Color.Black;
            txtArea.Location = new Point(216, 185);
            txtArea.Name = "txtArea";
            txtArea.NormalImageTint = Color.White;
            txtArea.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtArea.Padding = new Padding(16, 14, 16, 0);
            txtArea.PasswordChar = false;
            txtArea.PlaceholderColor = Color.LightGray;
            txtArea.PlaceholderText = "Площадь (м²)";
            txtArea.Rounding = new Padding(20);
            txtArea.Size = new Size(266, 45);
            txtArea.TabIndex = 6;
            txtArea.UnderlinedStyle = true;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.BackColor = Color.White;
            txtPrice.BackgroundColor = Color.White;
            txtPrice.Content = "";
            txtPrice.FocusBackgroundColor = Color.White;
            txtPrice.FocusImageTint = Color.White;
            txtPrice.FocusOutlineColor = Color.Black;
            txtPrice.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.ForeColor = Color.Black;
            txtPrice.Location = new Point(502, 185);
            txtPrice.Name = "txtPrice";
            txtPrice.NormalImageTint = Color.White;
            txtPrice.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtPrice.Padding = new Padding(16, 14, 16, 0);
            txtPrice.PasswordChar = false;
            txtPrice.PlaceholderColor = Color.LightGray;
            txtPrice.PlaceholderText = "Стоимость (₽)";
            txtPrice.Rounding = new Padding(20);
            txtPrice.Size = new Size(266, 45);
            txtPrice.TabIndex = 7;
            txtPrice.UnderlinedStyle = true;
            // 
            // lblAgent
            // 
            lblAgent.Anchor = AnchorStyles.None;
            lblAgent.AutoSize = true;
            lblAgent.BackColor = Color.White;
            lblAgent.Font = new Font("Segoe UI", 9F);
            lblAgent.Location = new Point(220, 240);
            lblAgent.Name = "lblAgent";
            lblAgent.Size = new Size(130, 15);
            lblAgent.TabIndex = 8;
            lblAgent.Text = "Ответственный агент:";
            // 
            // cmbAgent
            // 
            cmbAgent.Anchor = AnchorStyles.None;
            cmbAgent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAgent.Font = new Font("Segoe UI", 9.5F);
            cmbAgent.Location = new Point(220, 262);
            cmbAgent.Name = "cmbAgent";
            cmbAgent.Size = new Size(546, 25);
            cmbAgent.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.None;
            txtDescription.BackColor = Color.White;
            txtDescription.BackgroundColor = Color.White;
            txtDescription.Content = "";
            txtDescription.FocusBackgroundColor = Color.White;
            txtDescription.FocusImageTint = Color.White;
            txtDescription.FocusOutlineColor = Color.Black;
            txtDescription.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(216, 300);
            txtDescription.Name = "txtDescription";
            txtDescription.NormalImageTint = Color.White;
            txtDescription.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtDescription.Padding = new Padding(16, 14, 16, 0);
            txtDescription.PasswordChar = false;
            txtDescription.PlaceholderColor = Color.LightGray;
            txtDescription.PlaceholderText = "Описание (этаж, ремонт, особенности)";
            txtDescription.Rounding = new Padding(20);
            txtDescription.Size = new Size(552, 45);
            txtDescription.TabIndex = 10;
            txtDescription.UnderlinedStyle = true;
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
            btnSave.Location = new Point(216, 365);
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
            btnSave.Size = new Size(266, 45);
            btnSave.TabIndex = 11;
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
            btnCancel.HoverBackground = Color.White;
            btnCancel.HoverForeColor = Color.DimGray;
            btnCancel.HoverOutline = Color.Black;
            btnCancel.Location = new Point(502, 365);
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
            btnCancel.Size = new Size(266, 45);
            btnCancel.TabIndex = 12;
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
            Controls.Add(txtPrice);
            Controls.Add(txtArea);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(txtAddress);
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
        private HartUI.Controls.cuiTextBox txtAddress;
        private Label lblType;
        private ComboBox cmbType;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private HartUI.Controls.cuiTextBox txtArea;
        private HartUI.Controls.cuiTextBox txtPrice;
        private Label lblAgent;
        private ComboBox cmbAgent;
        private HartUI.Controls.cuiTextBox txtDescription;
        private HartUI.Controls.cuiButton btnSave;
        private HartUI.Controls.cuiButton btnCancel;
    }
}
