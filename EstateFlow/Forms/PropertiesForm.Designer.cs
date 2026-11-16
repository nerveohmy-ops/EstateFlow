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
            lblHeader.ForeColor = Color.Black;
            lblHeader.Location = new Point(16, 10);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(233, 28);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Каталог недвижимости";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9.5F);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(270, 17);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(159, 17);
            lblCount.TabIndex = 1;
            lblCount.Text = "Найдено предложений: 0";
            // 
            // btnViewCards
            // 
            btnViewCards.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewCards.CheckButton = false;
            btnViewCards.Checked = false;
            btnViewCards.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnViewCards.CheckedForeColor = Color.White;
            btnViewCards.CheckedImageTint = Color.White;
            btnViewCards.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnViewCards.Content = "▦ Витрина";
            btnViewCards.Cursor = Cursors.Hand;
            btnViewCards.DialogResult = DialogResult.None;
            btnViewCards.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewCards.ForeColor = Color.White;
            btnViewCards.HoverBackground = Color.FromArgb(40, 40, 40);
            btnViewCards.HoverForeColor = Color.White;
            btnViewCards.HoverImageTint = Color.White;
            btnViewCards.HoverOutline = Color.Black;
            btnViewCards.Image = null;
            btnViewCards.ImageExpand = new Point(0, 0);
            btnViewCards.Location = new Point(846, 8);
            btnViewCards.Name = "btnViewCards";
            btnViewCards.NormalBackground = Color.Black;
            btnViewCards.NormalForeColor = Color.White;
            btnViewCards.NormalImageTint = Color.Black;
            btnViewCards.NormalOutline = Color.Black;
            btnViewCards.OutlineThickness = 1F;
            btnViewCards.Padding = new Padding(4);
            btnViewCards.PressedBackground = Color.FromArgb(60, 60, 60);
            btnViewCards.PressedForeColor = Color.White;
            btnViewCards.PressedImageTint = Color.White;
            btnViewCards.PressedOutline = Color.Black;
            btnViewCards.Rounding = new Padding(14);
            btnViewCards.Size = new Size(112, 32);
            btnViewCards.TabIndex = 2;
            btnViewCards.TextAlignment = StringAlignment.Center;
            btnViewCards.TextPadding = 4;
            btnViewCards.TextSpacing = 2;
            btnViewCards.Click += btnViewCards_Click;
            // 
            // btnViewTable
            // 
            btnViewTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewTable.CheckButton = false;
            btnViewTable.Checked = false;
            btnViewTable.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnViewTable.CheckedForeColor = Color.White;
            btnViewTable.CheckedImageTint = Color.White;
            btnViewTable.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnViewTable.Content = "☵ Таблица";
            btnViewTable.Cursor = Cursors.Hand;
            btnViewTable.DialogResult = DialogResult.None;
            btnViewTable.Font = new Font("Segoe UI", 9F);
            btnViewTable.ForeColor = Color.Black;
            btnViewTable.HoverBackground = Color.FromArgb(242, 242, 242);
            btnViewTable.HoverForeColor = Color.Black;
            btnViewTable.HoverImageTint = Color.Black;
            btnViewTable.HoverOutline = Color.Black;
            btnViewTable.Image = null;
            btnViewTable.ImageExpand = new Point(0, 0);
            btnViewTable.Location = new Point(966, 8);
            btnViewTable.Name = "btnViewTable";
            btnViewTable.NormalBackground = Color.White;
            btnViewTable.NormalForeColor = Color.Black;
            btnViewTable.NormalImageTint = Color.Black;
            btnViewTable.NormalOutline = Color.FromArgb(160, 160, 160);
            btnViewTable.OutlineThickness = 1F;
            btnViewTable.Padding = new Padding(4);
            btnViewTable.PressedBackground = Color.WhiteSmoke;
            btnViewTable.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnViewTable.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnViewTable.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnViewTable.Rounding = new Padding(14);
            btnViewTable.Size = new Size(112, 32);
            btnViewTable.TabIndex = 3;
            btnViewTable.TextAlignment = StringAlignment.Center;
            btnViewTable.TextPadding = 4;
            btnViewTable.TextSpacing = 2;
            btnViewTable.Click += btnViewTable_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtSearch.Content = "";
            txtSearch.FocusBackgroundColor = Color.White;
            txtSearch.FocusImageTint = Color.White;
            txtSearch.FocusOutlineColor = Color.Black;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Image = null;
            txtSearch.ImageExpand = new Point(0, 0);
            txtSearch.ImageOffset = new Point(0, 0);
            txtSearch.ImageTextSpacing = 8;
            txtSearch.Location = new Point(16, 46);
            txtSearch.Margin = new Padding(4);
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.NormalImageTint = Color.White;
            txtSearch.OutlineColor = Color.FromArgb(95, 95, 95);
            txtSearch.Padding = new Padding(12, 10, 12, 0);
            txtSearch.PasswordChar = false;
            txtSearch.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtSearch.PlaceholderText = "Поиск по адресу, району, ЖК...";
            txtSearch.Rounding = new Padding(12);
            txtSearch.Size = new Size(240, 38);
            txtSearch.TabIndex = 4;
            txtSearch.TextOffset = new Size(0, 0);
            txtSearch.UnderlinedStyle = false;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(btnRoomAll);
            pnlRooms.Controls.Add(btnRoom0);
            pnlRooms.Controls.Add(btnRoom1);
            pnlRooms.Controls.Add(btnRoom2);
            pnlRooms.Controls.Add(btnRoom3);
            pnlRooms.Controls.Add(btnRoom4);
            pnlRooms.Location = new Point(266, 48);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new Size(252, 36);
            pnlRooms.TabIndex = 5;
            pnlRooms.WrapContents = false;
            // 
            // btnRoomAll
            // 
            btnRoomAll.CheckButton = false;
            btnRoomAll.Checked = false;
            btnRoomAll.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnRoomAll.CheckedForeColor = Color.White;
            btnRoomAll.CheckedImageTint = Color.White;
            btnRoomAll.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnRoomAll.Content = "Все";
            btnRoomAll.Cursor = Cursors.Hand;
            btnRoomAll.DialogResult = DialogResult.None;
            btnRoomAll.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnRoomAll.ForeColor = Color.White;
            btnRoomAll.HoverBackground = Color.White;
            btnRoomAll.HoverForeColor = Color.DimGray;
            btnRoomAll.HoverImageTint = Color.DimGray;
            btnRoomAll.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRoomAll.Image = null;
            btnRoomAll.ImageExpand = new Point(0, 0);
            btnRoomAll.Location = new Point(1, 0);
            btnRoomAll.Margin = new Padding(1, 0, 1, 0);
            btnRoomAll.Name = "btnRoomAll";
            btnRoomAll.NormalBackground = Color.Black;
            btnRoomAll.NormalForeColor = Color.White;
            btnRoomAll.NormalImageTint = Color.Black;
            btnRoomAll.NormalOutline = Color.Black;
            btnRoomAll.OutlineThickness = 1F;
            btnRoomAll.Padding = new Padding(2);
            btnRoomAll.PressedBackground = Color.WhiteSmoke;
            btnRoomAll.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRoomAll.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRoomAll.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRoomAll.Rounding = new Padding(12);
            btnRoomAll.Size = new Size(46, 34);
            btnRoomAll.TabIndex = 0;
            btnRoomAll.TextAlignment = StringAlignment.Center;
            btnRoomAll.TextPadding = 2;
            btnRoomAll.TextSpacing = 2;
            // 
            // btnRoom0
            // 
            btnRoom0.CheckButton = false;
            btnRoom0.Checked = false;
            btnRoom0.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnRoom0.CheckedForeColor = Color.White;
            btnRoom0.CheckedImageTint = Color.White;
            btnRoom0.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnRoom0.Content = "Ст";
            btnRoom0.Cursor = Cursors.Hand;
            btnRoom0.DialogResult = DialogResult.None;
            btnRoom0.Font = new Font("Segoe UI", 8.5F);
            btnRoom0.ForeColor = Color.Black;
            btnRoom0.HoverBackground = Color.White;
            btnRoom0.HoverForeColor = Color.DimGray;
            btnRoom0.HoverImageTint = Color.DimGray;
            btnRoom0.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRoom0.Image = null;
            btnRoom0.ImageExpand = new Point(0, 0);
            btnRoom0.Location = new Point(49, 0);
            btnRoom0.Margin = new Padding(1, 0, 1, 0);
            btnRoom0.Name = "btnRoom0";
            btnRoom0.NormalBackground = Color.White;
            btnRoom0.NormalForeColor = Color.Black;
            btnRoom0.NormalImageTint = Color.Black;
            btnRoom0.NormalOutline = Color.FromArgb(170, 170, 170);
            btnRoom0.OutlineThickness = 1F;
            btnRoom0.Padding = new Padding(2);
            btnRoom0.PressedBackground = Color.WhiteSmoke;
            btnRoom0.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRoom0.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRoom0.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRoom0.Rounding = new Padding(12);
            btnRoom0.Size = new Size(40, 34);
            btnRoom0.TabIndex = 1;
            btnRoom0.TextAlignment = StringAlignment.Center;
            btnRoom0.TextPadding = 2;
            btnRoom0.TextSpacing = 2;
            // 
            // btnRoom1
            // 
            btnRoom1.CheckButton = false;
            btnRoom1.Checked = false;
            btnRoom1.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnRoom1.CheckedForeColor = Color.White;
            btnRoom1.CheckedImageTint = Color.White;
            btnRoom1.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnRoom1.Content = "1";
            btnRoom1.Cursor = Cursors.Hand;
            btnRoom1.DialogResult = DialogResult.None;
            btnRoom1.Font = new Font("Segoe UI", 8.5F);
            btnRoom1.ForeColor = Color.Black;
            btnRoom1.HoverBackground = Color.White;
            btnRoom1.HoverForeColor = Color.DimGray;
            btnRoom1.HoverImageTint = Color.DimGray;
            btnRoom1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRoom1.Image = null;
            btnRoom1.ImageExpand = new Point(0, 0);
            btnRoom1.Location = new Point(91, 0);
            btnRoom1.Margin = new Padding(1, 0, 1, 0);
            btnRoom1.Name = "btnRoom1";
            btnRoom1.NormalBackground = Color.White;
            btnRoom1.NormalForeColor = Color.Black;
            btnRoom1.NormalImageTint = Color.Black;
            btnRoom1.NormalOutline = Color.FromArgb(170, 170, 170);
            btnRoom1.OutlineThickness = 1F;
            btnRoom1.Padding = new Padding(2);
            btnRoom1.PressedBackground = Color.WhiteSmoke;
            btnRoom1.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRoom1.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRoom1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRoom1.Rounding = new Padding(12);
            btnRoom1.Size = new Size(36, 34);
            btnRoom1.TabIndex = 2;
            btnRoom1.TextAlignment = StringAlignment.Center;
            btnRoom1.TextPadding = 2;
            btnRoom1.TextSpacing = 2;
            // 
            // btnRoom2
            // 
            btnRoom2.CheckButton = false;
            btnRoom2.Checked = false;
            btnRoom2.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnRoom2.CheckedForeColor = Color.White;
            btnRoom2.CheckedImageTint = Color.White;
            btnRoom2.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnRoom2.Content = "2";
            btnRoom2.Cursor = Cursors.Hand;
            btnRoom2.DialogResult = DialogResult.None;
            btnRoom2.Font = new Font("Segoe UI", 8.5F);
            btnRoom2.ForeColor = Color.Black;
            btnRoom2.HoverBackground = Color.White;
            btnRoom2.HoverForeColor = Color.DimGray;
            btnRoom2.HoverImageTint = Color.DimGray;
            btnRoom2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRoom2.Image = null;
            btnRoom2.ImageExpand = new Point(0, 0);
            btnRoom2.Location = new Point(129, 0);
            btnRoom2.Margin = new Padding(1, 0, 1, 0);
            btnRoom2.Name = "btnRoom2";
            btnRoom2.NormalBackground = Color.White;
            btnRoom2.NormalForeColor = Color.Black;
            btnRoom2.NormalImageTint = Color.Black;
            btnRoom2.NormalOutline = Color.FromArgb(170, 170, 170);
            btnRoom2.OutlineThickness = 1F;
            btnRoom2.Padding = new Padding(2);
            btnRoom2.PressedBackground = Color.WhiteSmoke;
            btnRoom2.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRoom2.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRoom2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRoom2.Rounding = new Padding(12);
            btnRoom2.Size = new Size(36, 34);
            btnRoom2.TabIndex = 3;
            btnRoom2.TextAlignment = StringAlignment.Center;
            btnRoom2.TextPadding = 2;
            btnRoom2.TextSpacing = 2;
            // 
            // btnRoom3
            // 
            btnRoom3.CheckButton = false;
            btnRoom3.Checked = false;
            btnRoom3.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnRoom3.CheckedForeColor = Color.White;
            btnRoom3.CheckedImageTint = Color.White;
            btnRoom3.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnRoom3.Content = "3";
            btnRoom3.Cursor = Cursors.Hand;
            btnRoom3.DialogResult = DialogResult.None;
            btnRoom3.Font = new Font("Segoe UI", 8.5F);
            btnRoom3.ForeColor = Color.Black;
            btnRoom3.HoverBackground = Color.White;
            btnRoom3.HoverForeColor = Color.DimGray;
            btnRoom3.HoverImageTint = Color.DimGray;
            btnRoom3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRoom3.Image = null;
            btnRoom3.ImageExpand = new Point(0, 0);
            btnRoom3.Location = new Point(167, 0);
            btnRoom3.Margin = new Padding(1, 0, 1, 0);
            btnRoom3.Name = "btnRoom3";
            btnRoom3.NormalBackground = Color.White;
            btnRoom3.NormalForeColor = Color.Black;
            btnRoom3.NormalImageTint = Color.Black;
            btnRoom3.NormalOutline = Color.FromArgb(170, 170, 170);
            btnRoom3.OutlineThickness = 1F;
            btnRoom3.Padding = new Padding(2);
            btnRoom3.PressedBackground = Color.WhiteSmoke;
            btnRoom3.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRoom3.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRoom3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRoom3.Rounding = new Padding(12);
            btnRoom3.Size = new Size(36, 34);
            btnRoom3.TabIndex = 4;
            btnRoom3.TextAlignment = StringAlignment.Center;
            btnRoom3.TextPadding = 2;
            btnRoom3.TextSpacing = 2;
            // 
            // btnRoom4
            // 
            btnRoom4.CheckButton = false;
            btnRoom4.Checked = false;
            btnRoom4.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnRoom4.CheckedForeColor = Color.White;
            btnRoom4.CheckedImageTint = Color.White;
            btnRoom4.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnRoom4.Content = "4+";
            btnRoom4.Cursor = Cursors.Hand;
            btnRoom4.DialogResult = DialogResult.None;
            btnRoom4.Font = new Font("Segoe UI", 8.5F);
            btnRoom4.ForeColor = Color.Black;
            btnRoom4.HoverBackground = Color.White;
            btnRoom4.HoverForeColor = Color.DimGray;
            btnRoom4.HoverImageTint = Color.DimGray;
            btnRoom4.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRoom4.Image = null;
            btnRoom4.ImageExpand = new Point(0, 0);
            btnRoom4.Location = new Point(205, 0);
            btnRoom4.Margin = new Padding(1, 0, 1, 0);
            btnRoom4.Name = "btnRoom4";
            btnRoom4.NormalBackground = Color.White;
            btnRoom4.NormalForeColor = Color.Black;
            btnRoom4.NormalImageTint = Color.Black;
            btnRoom4.NormalOutline = Color.FromArgb(170, 170, 170);
            btnRoom4.OutlineThickness = 1F;
            btnRoom4.Padding = new Padding(2);
            btnRoom4.PressedBackground = Color.WhiteSmoke;
            btnRoom4.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRoom4.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRoom4.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRoom4.Rounding = new Padding(12);
            btnRoom4.Size = new Size(44, 34);
            btnRoom4.TabIndex = 5;
            btnRoom4.TextAlignment = StringAlignment.Center;
            btnRoom4.TextPadding = 2;
            btnRoom4.TextSpacing = 2;
            // 
            // cmbDistrict
            // 
            cmbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistrict.Font = new Font("Segoe UI", 9.5F);
            cmbDistrict.Location = new Point(526, 53);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Size = new Size(145, 25);
            cmbDistrict.TabIndex = 6;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 9.5F);
            cmbType.Location = new Point(679, 53);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(135, 25);
            cmbType.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.CheckButton = false;
            btnAdd.Checked = false;
            btnAdd.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnAdd.CheckedForeColor = Color.White;
            btnAdd.CheckedImageTint = Color.White;
            btnAdd.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnAdd.Content = "+ Добавить";
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.DialogResult = DialogResult.None;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverBackground = Color.White;
            btnAdd.HoverForeColor = Color.DimGray;
            btnAdd.HoverImageTint = Color.DimGray;
            btnAdd.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnAdd.Image = null;
            btnAdd.ImageExpand = new Point(0, 0);
            btnAdd.Location = new Point(942, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.NormalBackground = Color.Black;
            btnAdd.NormalForeColor = Color.White;
            btnAdd.NormalImageTint = Color.Black;
            btnAdd.NormalOutline = Color.Black;
            btnAdd.OutlineThickness = 1F;
            btnAdd.Padding = new Padding(6);
            btnAdd.PressedBackground = Color.WhiteSmoke;
            btnAdd.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnAdd.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnAdd.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnAdd.Rounding = new Padding(14);
            btnAdd.Size = new Size(136, 36);
            btnAdd.TabIndex = 8;
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.TextPadding = 6;
            btnAdd.TextSpacing = 2;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtMinPrice
            // 
            txtMinPrice.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtMinPrice.Content = "";
            txtMinPrice.FocusBackgroundColor = Color.White;
            txtMinPrice.FocusImageTint = Color.White;
            txtMinPrice.FocusOutlineColor = Color.Black;
            txtMinPrice.Font = new Font("Segoe UI", 9F);
            txtMinPrice.ForeColor = Color.Black;
            txtMinPrice.Image = null;
            txtMinPrice.ImageExpand = new Point(0, 0);
            txtMinPrice.ImageOffset = new Point(0, 0);
            txtMinPrice.ImageTextSpacing = 8;
            txtMinPrice.Location = new Point(16, 90);
            txtMinPrice.Margin = new Padding(4);
            txtMinPrice.Multiline = false;
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.NormalImageTint = Color.White;
            txtMinPrice.OutlineColor = Color.FromArgb(95, 95, 95);
            txtMinPrice.Padding = new Padding(12, 9, 12, 0);
            txtMinPrice.PasswordChar = false;
            txtMinPrice.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtMinPrice.PlaceholderText = "Цена от (₽)";
            txtMinPrice.Rounding = new Padding(12);
            txtMinPrice.Size = new Size(145, 36);
            txtMinPrice.TabIndex = 9;
            txtMinPrice.TextOffset = new Size(0, 0);
            txtMinPrice.UnderlinedStyle = false;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtMaxPrice.Content = "";
            txtMaxPrice.FocusBackgroundColor = Color.White;
            txtMaxPrice.FocusImageTint = Color.White;
            txtMaxPrice.FocusOutlineColor = Color.Black;
            txtMaxPrice.Font = new Font("Segoe UI", 9F);
            txtMaxPrice.ForeColor = Color.Black;
            txtMaxPrice.Image = null;
            txtMaxPrice.ImageExpand = new Point(0, 0);
            txtMaxPrice.ImageOffset = new Point(0, 0);
            txtMaxPrice.ImageTextSpacing = 8;
            txtMaxPrice.Location = new Point(169, 90);
            txtMaxPrice.Margin = new Padding(4);
            txtMaxPrice.Multiline = false;
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.NormalImageTint = Color.White;
            txtMaxPrice.OutlineColor = Color.FromArgb(95, 95, 95);
            txtMaxPrice.Padding = new Padding(12, 9, 12, 0);
            txtMaxPrice.PasswordChar = false;
            txtMaxPrice.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtMaxPrice.PlaceholderText = "Цена до (₽)";
            txtMaxPrice.Rounding = new Padding(12);
            txtMaxPrice.Size = new Size(145, 36);
            txtMaxPrice.TabIndex = 10;
            txtMaxPrice.TextOffset = new Size(0, 0);
            txtMaxPrice.UnderlinedStyle = false;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "Все статусы", "Свободен", "Забронирован", "Продан" });
            cmbStatus.Location = new Point(324, 96);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(135, 25);
            cmbStatus.TabIndex = 11;
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Font = new Font("Segoe UI", 9.5F);
            cmbSort.Items.AddRange(new object[] { "Сначала новые", "Сначала дешевле", "Сначала дороже", "По площади" });
            cmbSort.Location = new Point(467, 96);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(160, 25);
            cmbSort.TabIndex = 12;
            // 
            // btnReset
            // 
            btnReset.CheckButton = false;
            btnReset.Checked = false;
            btnReset.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnReset.CheckedForeColor = Color.White;
            btnReset.CheckedImageTint = Color.White;
            btnReset.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnReset.Content = "Сбросить";
            btnReset.Cursor = Cursors.Hand;
            btnReset.DialogResult = DialogResult.None;
            btnReset.Font = new Font("Segoe UI", 9F);
            btnReset.ForeColor = Color.Black;
            btnReset.HoverBackground = Color.White;
            btnReset.HoverForeColor = Color.DimGray;
            btnReset.HoverImageTint = Color.DimGray;
            btnReset.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnReset.Image = null;
            btnReset.ImageExpand = new Point(0, 0);
            btnReset.Location = new Point(637, 90);
            btnReset.Name = "btnReset";
            btnReset.NormalBackground = Color.White;
            btnReset.NormalForeColor = Color.Black;
            btnReset.NormalImageTint = Color.Black;
            btnReset.NormalOutline = Color.FromArgb(170, 170, 170);
            btnReset.OutlineThickness = 1F;
            btnReset.Padding = new Padding(4);
            btnReset.PressedBackground = Color.WhiteSmoke;
            btnReset.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnReset.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnReset.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnReset.Rounding = new Padding(14);
            btnReset.Size = new Size(108, 36);
            btnReset.TabIndex = 13;
            btnReset.TextAlignment = StringAlignment.Center;
            btnReset.TextPadding = 4;
            btnReset.TextSpacing = 2;
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
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.CheckButton = false;
            btnBack.Checked = false;
            btnBack.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnBack.CheckedForeColor = Color.White;
            btnBack.CheckedImageTint = Color.White;
            btnBack.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnBack.Content = "Назад";
            btnBack.Cursor = Cursors.Hand;
            btnBack.DialogResult = DialogResult.None;
            btnBack.Font = new Font("Segoe UI", 9.5F);
            btnBack.ForeColor = Color.Black;
            btnBack.HoverBackground = Color.White;
            btnBack.HoverForeColor = Color.DimGray;
            btnBack.HoverImageTint = Color.DimGray;
            btnBack.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnBack.Image = null;
            btnBack.ImageExpand = new Point(0, 0);
            btnBack.Location = new Point(968, 622);
            btnBack.Name = "btnBack";
            btnBack.NormalBackground = Color.White;
            btnBack.NormalForeColor = Color.Black;
            btnBack.NormalImageTint = Color.Black;
            btnBack.NormalOutline = Color.Black;
            btnBack.OutlineThickness = 1F;
            btnBack.Padding = new Padding(8);
            btnBack.PressedBackground = Color.WhiteSmoke;
            btnBack.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnBack.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnBack.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnBack.Rounding = new Padding(18);
            btnBack.Size = new Size(110, 38);
            btnBack.TabIndex = 20;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.TextPadding = 8;
            btnBack.TextSpacing = 2;
            btnBack.Click += btnBack_Click;
            // 
            // btnShowing
            // 
            btnShowing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnShowing.CheckButton = false;
            btnShowing.Checked = false;
            btnShowing.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnShowing.CheckedForeColor = Color.White;
            btnShowing.CheckedImageTint = Color.White;
            btnShowing.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnShowing.Content = "На просмотр";
            btnShowing.Cursor = Cursors.Hand;
            btnShowing.DialogResult = DialogResult.None;
            btnShowing.Font = new Font("Segoe UI", 9.5F);
            btnShowing.ForeColor = Color.Black;
            btnShowing.HoverBackground = Color.White;
            btnShowing.HoverForeColor = Color.DimGray;
            btnShowing.HoverImageTint = Color.DimGray;
            btnShowing.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnShowing.Image = null;
            btnShowing.ImageExpand = new Point(0, 0);
            btnShowing.Location = new Point(148, 622);
            btnShowing.Name = "btnShowing";
            btnShowing.NormalBackground = Color.White;
            btnShowing.NormalForeColor = Color.Black;
            btnShowing.NormalImageTint = Color.Black;
            btnShowing.NormalOutline = Color.Black;
            btnShowing.OutlineThickness = 1F;
            btnShowing.Padding = new Padding(8);
            btnShowing.PressedBackground = Color.WhiteSmoke;
            btnShowing.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnShowing.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnShowing.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowing.Rounding = new Padding(18);
            btnShowing.Size = new Size(135, 38);
            btnShowing.TabIndex = 16;
            btnShowing.TextAlignment = StringAlignment.Center;
            btnShowing.TextPadding = 8;
            btnShowing.TextSpacing = 2;
            btnShowing.Click += btnShowing_Click;
            // 
            // btnDeal
            // 
            btnDeal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeal.CheckButton = false;
            btnDeal.Checked = false;
            btnDeal.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnDeal.CheckedForeColor = Color.White;
            btnDeal.CheckedImageTint = Color.White;
            btnDeal.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnDeal.Content = "Сделка";
            btnDeal.Cursor = Cursors.Hand;
            btnDeal.DialogResult = DialogResult.None;
            btnDeal.Font = new Font("Segoe UI", 9.5F);
            btnDeal.ForeColor = Color.Black;
            btnDeal.HoverBackground = Color.White;
            btnDeal.HoverForeColor = Color.DimGray;
            btnDeal.HoverImageTint = Color.DimGray;
            btnDeal.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnDeal.Image = null;
            btnDeal.ImageExpand = new Point(0, 0);
            btnDeal.Location = new Point(293, 622);
            btnDeal.Name = "btnDeal";
            btnDeal.NormalBackground = Color.White;
            btnDeal.NormalForeColor = Color.Black;
            btnDeal.NormalImageTint = Color.Black;
            btnDeal.NormalOutline = Color.Black;
            btnDeal.OutlineThickness = 1F;
            btnDeal.Padding = new Padding(8);
            btnDeal.PressedBackground = Color.WhiteSmoke;
            btnDeal.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDeal.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnDeal.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDeal.Rounding = new Padding(18);
            btnDeal.Size = new Size(120, 38);
            btnDeal.TabIndex = 17;
            btnDeal.TextAlignment = StringAlignment.Center;
            btnDeal.TextPadding = 8;
            btnDeal.TextSpacing = 2;
            btnDeal.Click += btnDeal_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.CheckButton = false;
            btnEdit.Checked = false;
            btnEdit.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnEdit.CheckedForeColor = Color.White;
            btnEdit.CheckedImageTint = Color.White;
            btnEdit.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnEdit.Content = "Изменить";
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.DialogResult = DialogResult.None;
            btnEdit.Font = new Font("Segoe UI", 9.5F);
            btnEdit.ForeColor = Color.Black;
            btnEdit.HoverBackground = Color.White;
            btnEdit.HoverForeColor = Color.DimGray;
            btnEdit.HoverImageTint = Color.DimGray;
            btnEdit.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnEdit.Image = null;
            btnEdit.ImageExpand = new Point(0, 0);
            btnEdit.Location = new Point(423, 622);
            btnEdit.Name = "btnEdit";
            btnEdit.NormalBackground = Color.White;
            btnEdit.NormalForeColor = Color.Black;
            btnEdit.NormalImageTint = Color.Black;
            btnEdit.NormalOutline = Color.Black;
            btnEdit.OutlineThickness = 1F;
            btnEdit.Padding = new Padding(8);
            btnEdit.PressedBackground = Color.WhiteSmoke;
            btnEdit.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnEdit.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnEdit.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnEdit.Rounding = new Padding(18);
            btnEdit.Size = new Size(120, 38);
            btnEdit.TabIndex = 18;
            btnEdit.TextAlignment = StringAlignment.Center;
            btnEdit.TextPadding = 8;
            btnEdit.TextSpacing = 2;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.CheckButton = false;
            btnDelete.Checked = false;
            btnDelete.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnDelete.CheckedForeColor = Color.White;
            btnDelete.CheckedImageTint = Color.White;
            btnDelete.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnDelete.Content = "Удалить";
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.DialogResult = DialogResult.None;
            btnDelete.Font = new Font("Segoe UI", 9.5F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.HoverBackground = Color.White;
            btnDelete.HoverForeColor = Color.DimGray;
            btnDelete.HoverImageTint = Color.DimGray;
            btnDelete.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnDelete.Image = null;
            btnDelete.ImageExpand = new Point(0, 0);
            btnDelete.Location = new Point(553, 622);
            btnDelete.Name = "btnDelete";
            btnDelete.NormalBackground = Color.White;
            btnDelete.NormalForeColor = Color.Black;
            btnDelete.NormalImageTint = Color.Black;
            btnDelete.NormalOutline = Color.Black;
            btnDelete.OutlineThickness = 1F;
            btnDelete.Padding = new Padding(8);
            btnDelete.PressedBackground = Color.WhiteSmoke;
            btnDelete.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDelete.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnDelete.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDelete.Rounding = new Padding(18);
            btnDelete.Size = new Size(110, 38);
            btnDelete.TabIndex = 19;
            btnDelete.TextAlignment = StringAlignment.Center;
            btnDelete.TextPadding = 8;
            btnDelete.TextSpacing = 2;
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
            MinimumSize = new Size(1050, 620);
            Name = "PropertiesForm";
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
