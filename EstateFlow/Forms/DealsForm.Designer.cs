namespace EstateFlow.Forms
{
    partial class DealsForm
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
            lblTotalSummary = new Label();
            txtSearch = new HartUI.Controls.cuiTextBox();
            cmbStatus = new ComboBox();
            chkUseDate = new HartUI.Controls.cuiCheckbox();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnReset = new HartUI.Controls.cuiButton();
            grid = new DataGridView();
            btnAdd = new HartUI.Controls.cuiButton();
            btnEdit = new HartUI.Controls.cuiButton();
            btnDelete = new HartUI.Controls.cuiButton();
            btnExport = new HartUI.Controls.cuiButton();
            btnBack = new HartUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.White;
            lblHeader.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblHeader.Location = new Point(102, 12);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(236, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Сделки купли-продажи";
            // 
            // lblTotalSummary
            // 
            lblTotalSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblTotalSummary.AutoSize = true;
            lblTotalSummary.BackColor = Color.White;
            lblTotalSummary.Font = new Font("Segoe UI", 9.5F);
            lblTotalSummary.ForeColor = Color.DimGray;
            lblTotalSummary.Location = new Point(365, 19);
            lblTotalSummary.Name = "lblTotalSummary";
            lblTotalSummary.Size = new Size(146, 17);
            lblTotalSummary.TabIndex = 1;
            lblTotalSummary.Text = "Сделок: 0 | Сумма: 0 ₽";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtSearch.BackColor = Color.White;
            txtSearch.BackgroundColor = Color.White;
            txtSearch.Content = "";
            txtSearch.FocusBackgroundColor = Color.White;
            txtSearch.FocusImageTint = Color.White;
            txtSearch.FocusOutlineColor = Color.Black;
            txtSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(102, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.NormalImageTint = Color.White;
            txtSearch.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtSearch.Padding = new Padding(16, 14, 16, 0);
            txtSearch.PasswordChar = false;
            txtSearch.PlaceholderColor = Color.LightGray;
            txtSearch.PlaceholderText = "Поиск (объект, клиент, агент)";
            txtSearch.Rounding = new Padding(20);
            txtSearch.Size = new Size(220, 45);
            txtSearch.TabIndex = 2;
            txtSearch.UnderlinedStyle = true;
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "Все статусы", "В процессе", "Завершена", "Отменена" });
            cmbStatus.Location = new Point(330, 56);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(122, 25);
            cmbStatus.TabIndex = 3;
            // 
            // chkUseDate
            // 
            chkUseDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            chkUseDate.BackColor = Color.White;
            chkUseDate.Checked = false;
            chkUseDate.CheckedForeground = Color.Black;
            chkUseDate.CheckedOutlineColor = Color.Black;
            chkUseDate.CheckedSymbolColor = Color.White;
            chkUseDate.Content = "Период:";
            chkUseDate.Cursor = Cursors.Hand;
            chkUseDate.Font = new Font("Segoe UI", 9.5F);
            chkUseDate.Location = new Point(460, 59);
            chkUseDate.Name = "chkUseDate";
            chkUseDate.OutlineThickness = 1F;
            chkUseDate.Rounding = 4;
            chkUseDate.ShowSymbols = true;
            chkUseDate.Size = new Size(80, 20);
            chkUseDate.TabIndex = 4;
            chkUseDate.UncheckedForeground = Color.Empty;
            chkUseDate.UncheckedOutlineColor = Color.Gray;
            chkUseDate.UncheckedSymbolColor = Color.Empty;
            // 
            // dtpFrom
            // 
            dtpFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            dtpFrom.Enabled = false;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(544, 56);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(112, 23);
            dtpFrom.TabIndex = 5;
            dtpFrom.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // dtpTo
            // 
            dtpTo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            dtpTo.Enabled = false;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(662, 56);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(112, 23);
            dtpTo.TabIndex = 6;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.BackColor = Color.White;
            btnReset.CheckButton = false;
            btnReset.Checked = false;
            btnReset.Content = "Сбросить";
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 10F);
            btnReset.ForeColor = Color.Black;
            btnReset.HoverBackground = Color.FromArgb(242, 242, 242);
            btnReset.HoverForeColor = Color.Black;
            btnReset.HoverOutline = Color.Black;
            btnReset.Location = new Point(782, 49);
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
            btnReset.Size = new Size(100, 38);
            btnReset.TabIndex = 7;
            btnReset.TextAlignment = StringAlignment.Center;
            btnReset.Click += btnReset_Click;
            // 
            // grid
            // 
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(102, 96);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.Size = new Size(780, 294);
            grid.TabIndex = 8;
            grid.DoubleClick += grid_DoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.White;
            btnAdd.CheckButton = false;
            btnAdd.Checked = false;
            btnAdd.Content = "Новая сделка";
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 10F);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverBackground = Color.FromArgb(40, 40, 40);
            btnAdd.HoverForeColor = Color.White;
            btnAdd.HoverOutline = Color.Black;
            btnAdd.Location = new Point(148, 404);
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
            btnAdd.Size = new Size(140, 40);
            btnAdd.TabIndex = 9;
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.BackColor = Color.White;
            btnEdit.CheckButton = false;
            btnEdit.Checked = false;
            btnEdit.Content = "Изменить";
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 10F);
            btnEdit.ForeColor = Color.Black;
            btnEdit.HoverBackground = Color.FromArgb(242, 242, 242);
            btnEdit.HoverForeColor = Color.Black;
            btnEdit.HoverOutline = Color.Black;
            btnEdit.Location = new Point(296, 404);
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
            btnEdit.Size = new Size(125, 40);
            btnEdit.TabIndex = 10;
            btnEdit.TextAlignment = StringAlignment.Center;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.White;
            btnDelete.CheckButton = false;
            btnDelete.Checked = false;
            btnDelete.Content = "Удалить";
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.HoverBackground = Color.FromArgb(242, 242, 242);
            btnDelete.HoverForeColor = Color.Black;
            btnDelete.HoverOutline = Color.Black;
            btnDelete.Location = new Point(429, 404);
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
            btnDelete.Size = new Size(115, 40);
            btnDelete.TabIndex = 11;
            btnDelete.TextAlignment = StringAlignment.Center;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExport.BackColor = Color.White;
            btnExport.CheckButton = false;
            btnExport.Checked = false;
            btnExport.Content = "Экспорт CSV";
            btnExport.Cursor = Cursors.Hand;
            btnExport.Font = new Font("Segoe UI", 10F);
            btnExport.ForeColor = Color.Black;
            btnExport.HoverBackground = Color.FromArgb(242, 242, 242);
            btnExport.HoverForeColor = Color.Black;
            btnExport.HoverOutline = Color.Black;
            btnExport.Location = new Point(552, 404);
            btnExport.Name = "btnExport";
            btnExport.NormalBackground = Color.White;
            btnExport.NormalForeColor = Color.Black;
            btnExport.NormalOutline = Color.Black;
            btnExport.OutlineThickness = 1F;
            btnExport.Padding = new Padding(12);
            btnExport.PressedBackground = Color.WhiteSmoke;
            btnExport.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnExport.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnExport.Rounding = new Padding(20);
            btnExport.Size = new Size(135, 40);
            btnExport.TabIndex = 12;
            btnExport.TextAlignment = StringAlignment.Center;
            btnExport.Click += btnExport_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.White;
            btnBack.CheckButton = false;
            btnBack.Checked = false;
            btnBack.Content = "Назад";
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.HoverBackground = Color.FromArgb(242, 242, 242);
            btnBack.HoverForeColor = Color.Black;
            btnBack.HoverOutline = Color.Black;
            btnBack.Location = new Point(770, 404);
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
            btnBack.Size = new Size(112, 40);
            btnBack.TabIndex = 13;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.Click += btnBack_Click;
            // 
            // DealsForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnBack);
            Controls.Add(btnExport);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(grid);
            Controls.Add(btnReset);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(chkUseDate);
            Controls.Add(cmbStatus);
            Controls.Add(txtSearch);
            Controls.Add(lblTotalSummary);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            Name = "DealsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сделки — EstateFlow";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblTotalSummary;
        private HartUI.Controls.cuiTextBox txtSearch;
        private ComboBox cmbStatus;
        private HartUI.Controls.cuiCheckbox chkUseDate;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private HartUI.Controls.cuiButton btnReset;
        private DataGridView grid;
        private HartUI.Controls.cuiButton btnAdd;
        private HartUI.Controls.cuiButton btnEdit;
        private HartUI.Controls.cuiButton btnDelete;
        private HartUI.Controls.cuiButton btnExport;
        private HartUI.Controls.cuiButton btnBack;
    }
}
