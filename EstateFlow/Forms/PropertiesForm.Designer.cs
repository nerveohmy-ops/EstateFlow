namespace EstateFlow.Forms
{
    partial class PropertiesForm
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
            lblHeader = new Label();
            lblCount = new Label();
            txtSearch = new HartUI.Controls.cuiTextBox();
            cmbType = new ComboBox();
            cmbStatus = new ComboBox();
            txtMinPrice = new HartUI.Controls.cuiTextBox();
            txtMaxPrice = new HartUI.Controls.cuiTextBox();
            btnReset = new HartUI.Controls.cuiButton();
            grid = new DataGridView();
            btnAdd = new HartUI.Controls.cuiButton();
            btnEdit = new HartUI.Controls.cuiButton();
            btnDelete = new HartUI.Controls.cuiButton();
            btnShowing = new HartUI.Controls.cuiButton();
            btnDeal = new HartUI.Controls.cuiButton();
            btnBack = new HartUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.None;
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.White;
            lblHeader.Font = new Font("Microsoft Sans Serif", 16F);
            lblHeader.Location = new Point(120, 14);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(254, 26);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Объекты недвижимости";
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.None;
            lblCount.AutoSize = true;
            lblCount.BackColor = Color.White;
            lblCount.Font = new Font("Segoe UI", 9.5F);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(400, 20);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(80, 17);
            lblCount.TabIndex = 1;
            lblCount.Text = "Найдено: 0";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.BackColor = Color.White;
            txtSearch.BackgroundColor = Color.White;
            txtSearch.Content = "";
            txtSearch.FocusBackgroundColor = Color.White;
            txtSearch.FocusImageTint = Color.White;
            txtSearch.FocusOutlineColor = Color.Black;
            txtSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(120, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.NormalImageTint = Color.White;
            txtSearch.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtSearch.Padding = new Padding(16, 14, 16, 0);
            txtSearch.PasswordChar = false;
            txtSearch.PlaceholderColor = Color.LightGray;
            txtSearch.PlaceholderText = "Поиск по адресу или описанию";
            txtSearch.Rounding = new Padding(20);
            txtSearch.Size = new Size(230, 45);
            txtSearch.TabIndex = 2;
            txtSearch.UnderlinedStyle = true;
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.None;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 9.5F);
            cmbType.Location = new Point(360, 58);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(135, 25);
            cmbType.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.None;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "Все статусы", "Свободен", "Забронирован", "Продан" });
            cmbStatus.Location = new Point(505, 58);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(125, 25);
            cmbStatus.TabIndex = 4;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Anchor = AnchorStyles.None;
            txtMinPrice.BackColor = Color.White;
            txtMinPrice.BackgroundColor = Color.White;
            txtMinPrice.Content = "";
            txtMinPrice.FocusBackgroundColor = Color.White;
            txtMinPrice.FocusImageTint = Color.White;
            txtMinPrice.FocusOutlineColor = Color.Black;
            txtMinPrice.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMinPrice.ForeColor = Color.Black;
            txtMinPrice.Location = new Point(640, 48);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.NormalImageTint = Color.White;
            txtMinPrice.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtMinPrice.Padding = new Padding(16, 14, 16, 0);
            txtMinPrice.PasswordChar = false;
            txtMinPrice.PlaceholderColor = Color.LightGray;
            txtMinPrice.PlaceholderText = "Цена от";
            txtMinPrice.Rounding = new Padding(20);
            txtMinPrice.Size = new Size(100, 45);
            txtMinPrice.TabIndex = 5;
            txtMinPrice.UnderlinedStyle = true;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Anchor = AnchorStyles.None;
            txtMaxPrice.BackColor = Color.White;
            txtMaxPrice.BackgroundColor = Color.White;
            txtMaxPrice.Content = "";
            txtMaxPrice.FocusBackgroundColor = Color.White;
            txtMaxPrice.FocusImageTint = Color.White;
            txtMaxPrice.FocusOutlineColor = Color.Black;
            txtMaxPrice.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaxPrice.ForeColor = Color.Black;
            txtMaxPrice.Location = new Point(745, 48);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.NormalImageTint = Color.White;
            txtMaxPrice.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtMaxPrice.Padding = new Padding(16, 14, 16, 0);
            txtMaxPrice.PasswordChar = false;
            txtMaxPrice.PlaceholderColor = Color.LightGray;
            txtMaxPrice.PlaceholderText = "Цена до";
            txtMaxPrice.Rounding = new Padding(20);
            txtMaxPrice.Size = new Size(100, 45);
            txtMaxPrice.TabIndex = 6;
            txtMaxPrice.UnderlinedStyle = true;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = Color.White;
            btnReset.CheckButton = false;
            btnReset.Checked = false;
            btnReset.Content = "Сбросить";
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 10.5F);
            btnReset.ForeColor = Color.Black;
            btnReset.HoverBackground = Color.White;
            btnReset.HoverForeColor = Color.DimGray;
            btnReset.HoverOutline = Color.Black;
            btnReset.Location = new Point(850, 50);
            btnReset.Name = "btnReset";
            btnReset.NormalBackground = Color.White;
            btnReset.NormalForeColor = Color.Black;
            btnReset.NormalOutline = Color.Black;
            btnReset.OutlineThickness = 1F;
            btnReset.Padding = new Padding(12);
            btnReset.PressedBackground = Color.WhiteSmoke;
            btnReset.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnReset.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnReset.Rounding = new Padding(20);
            btnReset.Size = new Size(95, 38);
            btnReset.TabIndex = 7;
            btnReset.TextAlignment = StringAlignment.Center;
            btnReset.Click += btnReset_Click;
            // 
            // grid
            // 
            grid.Anchor = AnchorStyles.None;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(120, 100);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.Size = new Size(825, 295);
            grid.TabIndex = 8;
            grid.DoubleClick += grid_DoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.White;
            btnAdd.CheckButton = false;
            btnAdd.Checked = false;
            btnAdd.Content = "Добавить";
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 10.5F);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverBackground = Color.FromArgb(40, 40, 40);
            btnAdd.HoverForeColor = Color.White;
            btnAdd.HoverOutline = Color.Black;
            btnAdd.Location = new Point(180, 405);
            btnAdd.Name = "btnAdd";
            btnAdd.NormalBackground = Color.Black;
            btnAdd.NormalForeColor = Color.White;
            btnAdd.NormalOutline = Color.Black;
            btnAdd.OutlineThickness = 1F;
            btnAdd.Padding = new Padding(12);
            btnAdd.PressedBackground = Color.WhiteSmoke;
            btnAdd.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnAdd.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnAdd.Rounding = new Padding(20);
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 9;
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.None;
            btnEdit.BackColor = Color.White;
            btnEdit.CheckButton = false;
            btnEdit.Checked = false;
            btnEdit.Content = "Изменить";
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 10.5F);
            btnEdit.ForeColor = Color.Black;
            btnEdit.HoverBackground = Color.White;
            btnEdit.HoverForeColor = Color.DimGray;
            btnEdit.HoverOutline = Color.Black;
            btnEdit.Location = new Point(308, 405);
            btnEdit.Name = "btnEdit";
            btnEdit.NormalBackground = Color.White;
            btnEdit.NormalForeColor = Color.Black;
            btnEdit.NormalOutline = Color.Black;
            btnEdit.OutlineThickness = 1F;
            btnEdit.Padding = new Padding(12);
            btnEdit.PressedBackground = Color.WhiteSmoke;
            btnEdit.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnEdit.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnEdit.Rounding = new Padding(20);
            btnEdit.Size = new Size(120, 40);
            btnEdit.TabIndex = 10;
            btnEdit.TextAlignment = StringAlignment.Center;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.White;
            btnDelete.CheckButton = false;
            btnDelete.Checked = false;
            btnDelete.Content = "Удалить";
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 10.5F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.HoverBackground = Color.White;
            btnDelete.HoverForeColor = Color.DimGray;
            btnDelete.HoverOutline = Color.Black;
            btnDelete.Location = new Point(436, 405);
            btnDelete.Name = "btnDelete";
            btnDelete.NormalBackground = Color.White;
            btnDelete.NormalForeColor = Color.Black;
            btnDelete.NormalOutline = Color.Black;
            btnDelete.OutlineThickness = 1F;
            btnDelete.Padding = new Padding(12);
            btnDelete.PressedBackground = Color.WhiteSmoke;
            btnDelete.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDelete.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDelete.Rounding = new Padding(20);
            btnDelete.Size = new Size(110, 40);
            btnDelete.TabIndex = 11;
            btnDelete.TextAlignment = StringAlignment.Center;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShowing
            // 
            btnShowing.Anchor = AnchorStyles.None;
            btnShowing.BackColor = Color.White;
            btnShowing.CheckButton = false;
            btnShowing.Checked = false;
            btnShowing.Content = "На просмотр";
            btnShowing.Cursor = Cursors.Hand;
            btnShowing.Font = new Font("Segoe UI", 10.5F);
            btnShowing.ForeColor = Color.Black;
            btnShowing.HoverBackground = Color.White;
            btnShowing.HoverForeColor = Color.DimGray;
            btnShowing.HoverOutline = Color.Black;
            btnShowing.Location = new Point(554, 405);
            btnShowing.Name = "btnShowing";
            btnShowing.NormalBackground = Color.White;
            btnShowing.NormalForeColor = Color.Black;
            btnShowing.NormalOutline = Color.Black;
            btnShowing.OutlineThickness = 1F;
            btnShowing.Padding = new Padding(12);
            btnShowing.PressedBackground = Color.WhiteSmoke;
            btnShowing.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnShowing.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowing.Rounding = new Padding(20);
            btnShowing.Size = new Size(135, 40);
            btnShowing.TabIndex = 12;
            btnShowing.TextAlignment = StringAlignment.Center;
            btnShowing.Click += btnShowing_Click;
            // 
            // btnDeal
            // 
            btnDeal.Anchor = AnchorStyles.None;
            btnDeal.BackColor = Color.White;
            btnDeal.CheckButton = false;
            btnDeal.Checked = false;
            btnDeal.Content = "Сделка";
            btnDeal.Cursor = Cursors.Hand;
            btnDeal.Font = new Font("Segoe UI", 10.5F);
            btnDeal.ForeColor = Color.Black;
            btnDeal.HoverBackground = Color.White;
            btnDeal.HoverForeColor = Color.DimGray;
            btnDeal.HoverOutline = Color.Black;
            btnDeal.Location = new Point(697, 405);
            btnDeal.Name = "btnDeal";
            btnDeal.NormalBackground = Color.White;
            btnDeal.NormalForeColor = Color.Black;
            btnDeal.NormalOutline = Color.Black;
            btnDeal.OutlineThickness = 1F;
            btnDeal.Padding = new Padding(12);
            btnDeal.PressedBackground = Color.WhiteSmoke;
            btnDeal.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDeal.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDeal.Rounding = new Padding(20);
            btnDeal.Size = new Size(115, 40);
            btnDeal.TabIndex = 13;
            btnDeal.TextAlignment = StringAlignment.Center;
            btnDeal.Click += btnDeal_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.White;
            btnBack.CheckButton = false;
            btnBack.Checked = false;
            btnBack.Content = "Назад";
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 10.5F);
            btnBack.ForeColor = Color.Black;
            btnBack.HoverBackground = Color.White;
            btnBack.HoverForeColor = Color.DimGray;
            btnBack.HoverOutline = Color.Black;
            btnBack.Location = new Point(830, 405);
            btnBack.Name = "btnBack";
            btnBack.NormalBackground = Color.White;
            btnBack.NormalForeColor = Color.Black;
            btnBack.NormalOutline = Color.Black;
            btnBack.OutlineThickness = 1F;
            btnBack.Padding = new Padding(12);
            btnBack.PressedBackground = Color.WhiteSmoke;
            btnBack.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnBack.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnBack.Rounding = new Padding(20);
            btnBack.Size = new Size(115, 40);
            btnBack.TabIndex = 14;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.Click += btnBack_Click;
            // 
            // PropertiesForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnBack);
            Controls.Add(btnDeal);
            Controls.Add(btnShowing);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(grid);
            Controls.Add(btnReset);
            Controls.Add(txtMaxPrice);
            Controls.Add(txtMinPrice);
            Controls.Add(cmbStatus);
            Controls.Add(cmbType);
            Controls.Add(txtSearch);
            Controls.Add(lblCount);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            Name = "PropertiesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Объекты недвижимости — EstateFlow";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblCount;
        private HartUI.Controls.cuiTextBox txtSearch;
        private ComboBox cmbType;
        private ComboBox cmbStatus;
        private HartUI.Controls.cuiTextBox txtMinPrice;
        private HartUI.Controls.cuiTextBox txtMaxPrice;
        private HartUI.Controls.cuiButton btnReset;
        private DataGridView grid;
        private HartUI.Controls.cuiButton btnAdd;
        private HartUI.Controls.cuiButton btnEdit;
        private HartUI.Controls.cuiButton btnDelete;
        private HartUI.Controls.cuiButton btnShowing;
        private HartUI.Controls.cuiButton btnDeal;
        private HartUI.Controls.cuiButton btnBack;
    }
}
