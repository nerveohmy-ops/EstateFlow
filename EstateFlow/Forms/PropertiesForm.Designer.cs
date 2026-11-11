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
            btnViewCards = new HartUI.Controls.cuiButton();
            btnViewTable = new HartUI.Controls.cuiButton();
            txtSearch = new HartUI.Controls.cuiTextBox();
            pnlRooms = new FlowLayoutPanel();
            btnRoomAll = new HartUI.Controls.cuiButton();
            btnRoom0 = new HartUI.Controls.cuiButton();
            btnRoom1 = new HartUI.Controls.cuiButton();
            btnRoom2 = new HartUI.Controls.cuiButton();
            btnRoom3 = new HartUI.Controls.cuiButton();
            btnRoom4 = new HartUI.Controls.cuiButton();
            cmbDistrict = new ComboBox();
            cmbType = new ComboBox();
            btnAdd = new HartUI.Controls.cuiButton();
            txtMinPrice = new HartUI.Controls.cuiTextBox();
            txtMaxPrice = new HartUI.Controls.cuiTextBox();
            cmbStatus = new ComboBox();
            cmbSort = new ComboBox();
            btnReset = new HartUI.Controls.cuiButton();
            pnlCatalog = new FlowLayoutPanel();
            grid = new DataGridView();
            btnBack = new HartUI.Controls.cuiButton();
            btnShowing = new HartUI.Controls.cuiButton();
            btnDeal = new HartUI.Controls.cuiButton();
            btnEdit = new HartUI.Controls.cuiButton();
            btnDelete = new HartUI.Controls.cuiButton();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblHeader.Location = new Point(140, 10);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(330, 28);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Каталог недвижимости — Циан";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9.5F);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(480, 17);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(160, 17);
            lblCount.TabIndex = 1;
            lblCount.Text = "Найдено предложений: 0";
            // 
            // btnViewCards
            // 
            btnViewCards.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewCards.CheckButton = false;
            btnViewCards.Checked = false;
            btnViewCards.Content = "▦ Витрина";
            btnViewCards.Cursor = Cursors.Hand;
            btnViewCards.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewCards.ForeColor = Color.White;
            btnViewCards.Location = new Point(870, 8);
            btnViewCards.Name = "btnViewCards";
            btnViewCards.NormalBackground = Color.Black;
            btnViewCards.NormalForeColor = Color.White;
            btnViewCards.NormalOutline = Color.Black;
            btnViewCards.OutlineThickness = 1F;
            btnViewCards.Padding = new Padding(6);
            btnViewCards.Rounding = new Padding(14);
            btnViewCards.Size = new Size(100, 32);
            btnViewCards.TabIndex = 2;
            btnViewCards.TextAlignment = StringAlignment.Center;
            btnViewCards.Click += btnViewCards_Click;
            // 
            // btnViewTable
            // 
            btnViewTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewTable.CheckButton = false;
            btnViewTable.Checked = false;
            btnViewTable.Content = "☵ Таблица";
            btnViewTable.Cursor = Cursors.Hand;
            btnViewTable.Font = new Font("Segoe UI", 9F);
            btnViewTable.ForeColor = Color.Black;
            btnViewTable.Location = new Point(978, 8);
            btnViewTable.Name = "btnViewTable";
            btnViewTable.NormalBackground = Color.White;
            btnViewTable.NormalForeColor = Color.Black;
            btnViewTable.NormalOutline = Color.FromArgb(160, 160, 160);
            btnViewTable.OutlineThickness = 1F;
            btnViewTable.Padding = new Padding(6);
            btnViewTable.Rounding = new Padding(14);
            btnViewTable.Size = new Size(100, 32);
            btnViewTable.TabIndex = 3;
            btnViewTable.TextAlignment = StringAlignment.Center;
            btnViewTable.Click += btnViewTable_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtSearch.Content = "";
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(140, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(12, 10, 12, 0);
            txtSearch.PlaceholderText = "Поиск по адресу, району, ЖК...";
            txtSearch.Rounding = new Padding(12);
            txtSearch.Size = new Size(240, 38);
            txtSearch.TabIndex = 4;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(btnRoomAll);
            pnlRooms.Controls.Add(btnRoom0);
            pnlRooms.Controls.Add(btnRoom1);
            pnlRooms.Controls.Add(btnRoom2);
            pnlRooms.Controls.Add(btnRoom3);
            pnlRooms.Controls.Add(btnRoom4);
            pnlRooms.Location = new Point(386, 48);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new Size(260, 36);
            pnlRooms.TabIndex = 5;
            pnlRooms.WrapContents = false;
            // 
            // btnRoomAll
            // 
            btnRoomAll.CheckButton = false;
            btnRoomAll.Checked = false;
            btnRoomAll.Content = "Все";
            btnRoomAll.Cursor = Cursors.Hand;
            btnRoomAll.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnRoomAll.ForeColor = Color.White;
            btnRoomAll.Margin = new Padding(1, 0, 1, 0);
            btnRoomAll.Name = "btnRoomAll";
            btnRoomAll.NormalBackground = Color.Black;
            btnRoomAll.NormalForeColor = Color.White;
            btnRoomAll.NormalOutline = Color.Black;
            btnRoomAll.OutlineThickness = 1F;
            btnRoomAll.Rounding = new Padding(12);
            btnRoomAll.Size = new Size(38, 34);
            btnRoomAll.TabIndex = 0;
            btnRoomAll.TextAlignment = StringAlignment.Center;
            // 
            // btnRoom0
            // 
            btnRoom0.CheckButton = false;
            btnRoom0.Checked = false;
            btnRoom0.Content = "Ст";
            btnRoom0.Cursor = Cursors.Hand;
            btnRoom0.Font = new Font("Segoe UI", 8.5F);
            btnRoom0.ForeColor = Color.Black;
            btnRoom0.Margin = new Padding(1, 0, 1, 0);
            btnRoom0.Name = "btnRoom0";
            btnRoom0.NormalBackground = Color.White;
            btnRoom0.NormalForeColor = Color.Black;
            btnRoom0.NormalOutline = Color.FromArgb(170, 170, 170);
            btnRoom0.OutlineThickness = 1F;
            btnRoom0.Rounding = new Padding(12);
            btnRoom0.Size = new Size(38, 34);
            btnRoom0.TabIndex = 1;
            btnRoom0.TextAlignment = StringAlignment.Center;
            // 
            // btnRoom1
            // 
            btnRoom1.CheckButton = false;
            btnRoom1.Checked = false;
            btnRoom1.Content = "1";
            btnRoom1.Cursor = Cursors.Hand;
            btnRoom1.Font = new Font("Segoe UI", 8.5F);
            btnRoom1.ForeColor = Color.Black;
            btnRoom1.Margin = new Padding(1, 0, 1, 0);
            btnRoom1.Name = "btnRoom1";
            btnRoom1.NormalBackground = Color.White;
            btnRoom1.NormalForeColor = Color.Black;
            btnRoom1.NormalOutline = Color.FromArgb(170, 170, 170);
            btnRoom1.OutlineThickness = 1F;
            btnRoom1.Rounding = new Padding(12);
            btnRoom1.Size = new Size(34, 34);
            btnRoom1.TabIndex = 2;
            btnRoom1.TextAlignment = StringAlignment.Center;
            // 
            // btnRoom2
            // 
            btnRoom2.CheckButton = false;
            btnRoom2.Checked = false;
            btnRoom2.Content = "2";
            btnRoom2.Cursor = Cursors.Hand;
            btnRoom2.Font = new Font("Segoe UI", 8.5F);
            btnRoom2.ForeColor = Color.Black;
            btnRoom2.Margin = new Padding(1, 0, 1, 0);
            btnRoom2.Name = "btnRoom2";
            btnRoom2.NormalBackground = Color.White;
            btnRoom2.NormalForeColor = Color.Black;
            btnRoom2.NormalOutline = Color.FromArgb(170, 170, 170);
            btnRoom2.OutlineThickness = 1F;
            btnRoom2.Rounding = new Padding(12);
            btnRoom2.Size = new Size(34, 34);
            btnRoom2.TabIndex = 3;
            btnRoom2.TextAlignment = StringAlignment.Center;
            // 
            // btnRoom3
            // 
            btnRoom3.CheckButton = false;
            btnRoom3.Checked = false;
            btnRoom3.Content = "3";
            btnRoom3.Cursor = Cursors.Hand;
            btnRoom3.Font = new Font("Segoe UI", 8.5F);
            btnRoom3.ForeColor = Color.Black;
            btnRoom3.Margin = new Padding(1, 0, 1, 0);
            btnRoom3.Name = "btnRoom3";
            btnRoom3.NormalBackground = Color.White;
            btnRoom3.NormalForeColor = Color.Black;
            btnRoom3.NormalOutline = Color.FromArgb(170, 170, 170);
            btnRoom3.OutlineThickness = 1F;
            btnRoom3.Rounding = new Padding(12);
            btnRoom3.Size = new Size(34, 34);
            btnRoom3.TabIndex = 4;
            btnRoom3.TextAlignment = StringAlignment.Center;
            // 
            // btnRoom4
            // 
            btnRoom4.CheckButton = false;
            btnRoom4.Checked = false;
            btnRoom4.Content = "4+";
            btnRoom4.Cursor = Cursors.Hand;
            btnRoom4.Font = new Font("Segoe UI", 8.5F);
            btnRoom4.ForeColor = Color.Black;
            btnRoom4.Margin = new Padding(1, 0, 1, 0);
            btnRoom4.Name = "btnRoom4";
            btnRoom4.NormalBackground = Color.White;
            btnRoom4.NormalForeColor = Color.Black;
            btnRoom4.NormalOutline = Color.FromArgb(170, 170, 170);
            btnRoom4.OutlineThickness = 1F;
            btnRoom4.Rounding = new Padding(12);
            btnRoom4.Size = new Size(38, 34);
            btnRoom4.TabIndex = 5;
            btnRoom4.TextAlignment = StringAlignment.Center;
            // 
            // cmbDistrict
            // 
            cmbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistrict.Font = new Font("Segoe UI", 9.5F);
            cmbDistrict.Location = new Point(652, 53);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Size = new Size(140, 25);
            cmbDistrict.TabIndex = 6;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 9.5F);
            cmbType.Location = new Point(798, 53);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(130, 25);
            cmbType.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.CheckButton = false;
            btnAdd.Checked = false;
            btnAdd.Content = "+ Добавить";
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(948, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.NormalBackground = Color.Black;
            btnAdd.NormalForeColor = Color.White;
            btnAdd.NormalOutline = Color.Black;
            btnAdd.OutlineThickness = 1F;
            btnAdd.Padding = new Padding(6);
            btnAdd.Rounding = new Padding(14);
            btnAdd.Size = new Size(130, 36);
            btnAdd.TabIndex = 8;
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtMinPrice
            // 
            txtMinPrice.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtMinPrice.Content = "";
            txtMinPrice.Font = new Font("Segoe UI", 9F);
            txtMinPrice.Location = new Point(140, 90);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Padding = new Padding(10, 8, 10, 0);
            txtMinPrice.PlaceholderText = "Цена от (₽)";
            txtMinPrice.Rounding = new Padding(10);
            txtMinPrice.Size = new Size(130, 36);
            txtMinPrice.TabIndex = 9;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtMaxPrice.Content = "";
            txtMaxPrice.Font = new Font("Segoe UI", 9F);
            txtMaxPrice.Location = new Point(276, 90);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Padding = new Padding(10, 8, 10, 0);
            txtMaxPrice.PlaceholderText = "Цена до (₽)";
            txtMaxPrice.Rounding = new Padding(10);
            txtMaxPrice.Size = new Size(130, 36);
            txtMaxPrice.TabIndex = 10;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "Все статусы", "Свободен", "Забронирован", "Продан" });
            cmbStatus.Location = new Point(415, 96);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(130, 25);
            cmbStatus.TabIndex = 11;
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Font = new Font("Segoe UI", 9.5F);
            cmbSort.Items.AddRange(new object[] { "Сначала новые", "Сначала дешевле", "Сначала дороже", "По площади" });
            cmbSort.Location = new Point(555, 96);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(155, 25);
            cmbSort.TabIndex = 12;
            // 
            // btnReset
            // 
            btnReset.CheckButton = false;
            btnReset.Checked = false;
            btnReset.Content = "Сбросить";
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 9F);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(720, 92);
            btnReset.Name = "btnReset";
            btnReset.NormalBackground = Color.White;
            btnReset.NormalForeColor = Color.Black;
            btnReset.NormalOutline = Color.FromArgb(170, 170, 170);
            btnReset.OutlineThickness = 1F;
            btnReset.Padding = new Padding(6);
            btnReset.Rounding = new Padding(14);
            btnReset.Size = new Size(95, 34);
            btnReset.TabIndex = 13;
            btnReset.TextAlignment = StringAlignment.Center;
            btnReset.Click += btnReset_Click;
            // 
            // pnlCatalog
            // 
            pnlCatalog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCatalog.AutoScroll = true;
            pnlCatalog.BackColor = Color.FromArgb(248, 249, 251);
            pnlCatalog.FlowDirection = FlowDirection.TopDown;
            pnlCatalog.Location = new Point(16, 136);
            pnlCatalog.Name = "pnlCatalog";
            pnlCatalog.Padding = new Padding(8);
            pnlCatalog.Size = new Size(1062, 475);
            pnlCatalog.TabIndex = 14;
            pnlCatalog.WrapContents = false;
            // 
            // grid
            // 
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(16, 136);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.Size = new Size(1062, 475);
            grid.TabIndex = 15;
            grid.Visible = false;
            grid.DoubleClick += grid_DoubleClick;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.CheckButton = false;
            btnBack.Checked = false;
            btnBack.Content = "Назад";
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 9.5F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(16, 622);
            btnBack.Name = "btnBack";
            btnBack.NormalBackground = Color.White;
            btnBack.NormalForeColor = Color.Black;
            btnBack.NormalOutline = Color.Black;
            btnBack.OutlineThickness = 1F;
            btnBack.Padding = new Padding(8);
            btnBack.Rounding = new Padding(18);
            btnBack.Size = new Size(105, 38);
            btnBack.TabIndex = 16;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.Click += btnBack_Click;
            // 
            // btnShowing
            // 
            btnShowing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnShowing.CheckButton = false;
            btnShowing.Checked = false;
            btnShowing.Content = "На просмотр";
            btnShowing.Cursor = Cursors.Hand;
            btnShowing.Font = new Font("Segoe UI", 9.5F);
            btnShowing.ForeColor = Color.Black;
            btnShowing.Location = new Point(130, 622);
            btnShowing.Name = "btnShowing";
            btnShowing.NormalBackground = Color.White;
            btnShowing.NormalForeColor = Color.Black;
            btnShowing.NormalOutline = Color.Black;
            btnShowing.OutlineThickness = 1F;
            btnShowing.Padding = new Padding(8);
            btnShowing.Rounding = new Padding(18);
            btnShowing.Size = new Size(130, 38);
            btnShowing.TabIndex = 17;
            btnShowing.TextAlignment = StringAlignment.Center;
            btnShowing.Click += btnShowing_Click;
            // 
            // btnDeal
            // 
            btnDeal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeal.CheckButton = false;
            btnDeal.Checked = false;
            btnDeal.Content = "Сделка";
            btnDeal.Cursor = Cursors.Hand;
            btnDeal.Font = new Font("Segoe UI", 9.5F);
            btnDeal.ForeColor = Color.Black;
            btnDeal.Location = new Point(270, 622);
            btnDeal.Name = "btnDeal";
            btnDeal.NormalBackground = Color.White;
            btnDeal.NormalForeColor = Color.Black;
            btnDeal.NormalOutline = Color.Black;
            btnDeal.OutlineThickness = 1F;
            btnDeal.Padding = new Padding(8);
            btnDeal.Rounding = new Padding(18);
            btnDeal.Size = new Size(115, 38);
            btnDeal.TabIndex = 18;
            btnDeal.TextAlignment = StringAlignment.Center;
            btnDeal.Click += btnDeal_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.CheckButton = false;
            btnEdit.Checked = false;
            btnEdit.Content = "Изменить";
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 9.5F);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(395, 622);
            btnEdit.Name = "btnEdit";
            btnEdit.NormalBackground = Color.White;
            btnEdit.NormalForeColor = Color.Black;
            btnEdit.NormalOutline = Color.Black;
            btnEdit.OutlineThickness = 1F;
            btnEdit.Padding = new Padding(8);
            btnEdit.Rounding = new Padding(18);
            btnEdit.Size = new Size(115, 38);
            btnEdit.TabIndex = 19;
            btnEdit.TextAlignment = StringAlignment.Center;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.CheckButton = false;
            btnDelete.Checked = false;
            btnDelete.Content = "Удалить";
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 9.5F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(520, 622);
            btnDelete.Name = "btnDelete";
            btnDelete.NormalBackground = Color.White;
            btnDelete.NormalForeColor = Color.Black;
            btnDelete.NormalOutline = Color.Black;
            btnDelete.OutlineThickness = 1F;
            btnDelete.Padding = new Padding(8);
            btnDelete.Rounding = new Padding(18);
            btnDelete.Size = new Size(105, 38);
            btnDelete.TabIndex = 20;
            btnDelete.TextAlignment = StringAlignment.Center;
            btnDelete.Click += btnDelete_Click;
            // 
            // PropertiesForm
            // 
            ClientSize = new Size(1094, 672);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnDeal);
            Controls.Add(btnShowing);
            Controls.Add(btnBack);
            Controls.Add(pnlCatalog);
            Controls.Add(grid);
            Controls.Add(btnReset);
            Controls.Add(cmbSort);
            Controls.Add(cmbStatus);
            Controls.Add(txtMaxPrice);
            Controls.Add(txtMinPrice);
            Controls.Add(btnAdd);
            Controls.Add(cmbType);
            Controls.Add(cmbDistrict);
            Controls.Add(pnlRooms);
            Controls.Add(txtSearch);
            Controls.Add(btnViewTable);
            Controls.Add(btnViewCards);
            Controls.Add(lblCount);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            MinimumSize = new Size(1050, 620);
            Name = "PropertiesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каталог недвижимости — EstateFlow";
            pnlRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblCount;
        private HartUI.Controls.cuiButton btnViewCards;
        private HartUI.Controls.cuiButton btnViewTable;
        private HartUI.Controls.cuiTextBox txtSearch;
        private FlowLayoutPanel pnlRooms;
        private HartUI.Controls.cuiButton btnRoomAll;
        private HartUI.Controls.cuiButton btnRoom0;
        private HartUI.Controls.cuiButton btnRoom1;
        private HartUI.Controls.cuiButton btnRoom2;
        private HartUI.Controls.cuiButton btnRoom3;
        private HartUI.Controls.cuiButton btnRoom4;
        private ComboBox cmbDistrict;
        private ComboBox cmbType;
        private HartUI.Controls.cuiButton btnAdd;
        private HartUI.Controls.cuiTextBox txtMinPrice;
        private HartUI.Controls.cuiTextBox txtMaxPrice;
        private ComboBox cmbStatus;
        private ComboBox cmbSort;
        private HartUI.Controls.cuiButton btnReset;
        private FlowLayoutPanel pnlCatalog;
        private DataGridView grid;
        private HartUI.Controls.cuiButton btnBack;
        private HartUI.Controls.cuiButton btnShowing;
        private HartUI.Controls.cuiButton btnDeal;
        private HartUI.Controls.cuiButton btnEdit;
        private HartUI.Controls.cuiButton btnDelete;
    }
}
