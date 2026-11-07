namespace EstateFlow.Forms
{
    partial class ShowingsForm
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
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            grid = new DataGridView();
            btnAdd = new HartUI.Controls.cuiButton();
            btnConfirm = new HartUI.Controls.cuiButton();
            btnDone = new HartUI.Controls.cuiButton();
            btnCancel = new HartUI.Controls.cuiButton();
            btnDelete = new HartUI.Controls.cuiButton();
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
            lblHeader.Size = new Size(216, 26);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Заявки на просмотр";
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.None;
            lblCount.AutoSize = true;
            lblCount.BackColor = Color.White;
            lblCount.Font = new Font("Segoe UI", 9.5F);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(355, 20);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(65, 17);
            lblCount.TabIndex = 1;
            lblCount.Text = "Заявок: 0";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.None;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.Font = new Font("Segoe UI", 9.5F);
            lblStatus.Location = new Point(120, 60);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 17);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Статус заявки:";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.None;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "Все статусы", "Новая", "Подтверждена", "Проведена", "Отменена" });
            cmbStatus.Location = new Point(225, 57);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(190, 25);
            cmbStatus.TabIndex = 3;
            // 
            // grid
            // 
            grid.Anchor = AnchorStyles.None;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(120, 95);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.Size = new Size(825, 300);
            grid.TabIndex = 4;
            grid.DoubleClick += grid_DoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.White;
            btnAdd.CheckButton = false;
            btnAdd.Checked = false;
            btnAdd.Content = "Записаться";
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
            btnAdd.Size = new Size(130, 40);
            btnAdd.TabIndex = 5;
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.None;
            btnConfirm.BackColor = Color.White;
            btnConfirm.CheckButton = false;
            btnConfirm.Checked = false;
            btnConfirm.Content = "Подтвердить";
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Font = new Font("Segoe UI", 10.5F);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.HoverBackground = Color.White;
            btnConfirm.HoverForeColor = Color.DimGray;
            btnConfirm.HoverOutline = Color.Black;
            btnConfirm.Location = new Point(318, 405);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.NormalBackground = Color.White;
            btnConfirm.NormalForeColor = Color.Black;
            btnConfirm.NormalOutline = Color.Black;
            btnConfirm.OutlineThickness = 1F;
            btnConfirm.Padding = new Padding(12);
            btnConfirm.PressedBackground = Color.WhiteSmoke;
            btnConfirm.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnConfirm.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnConfirm.Rounding = new Padding(20);
            btnConfirm.Size = new Size(130, 40);
            btnConfirm.TabIndex = 6;
            btnConfirm.TextAlignment = StringAlignment.Center;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.None;
            btnDone.BackColor = Color.White;
            btnDone.CheckButton = false;
            btnDone.Checked = false;
            btnDone.Content = "Проведён";
            btnDone.Cursor = Cursors.Hand;
            btnDone.Font = new Font("Segoe UI", 10.5F);
            btnDone.ForeColor = Color.Black;
            btnDone.HoverBackground = Color.White;
            btnDone.HoverForeColor = Color.DimGray;
            btnDone.HoverOutline = Color.Black;
            btnDone.Location = new Point(456, 405);
            btnDone.Name = "btnDone";
            btnDone.NormalBackground = Color.White;
            btnDone.NormalForeColor = Color.Black;
            btnDone.NormalOutline = Color.Black;
            btnDone.OutlineThickness = 1F;
            btnDone.Padding = new Padding(12);
            btnDone.PressedBackground = Color.WhiteSmoke;
            btnDone.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDone.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDone.Rounding = new Padding(20);
            btnDone.Size = new Size(120, 40);
            btnDone.TabIndex = 7;
            btnDone.TextAlignment = StringAlignment.Center;
            btnDone.Click += btnDone_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.White;
            btnCancel.CheckButton = false;
            btnCancel.Checked = false;
            btnCancel.Content = "Отменить";
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10.5F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.HoverBackground = Color.White;
            btnCancel.HoverForeColor = Color.DimGray;
            btnCancel.HoverOutline = Color.Black;
            btnCancel.Location = new Point(584, 405);
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
            btnCancel.Size = new Size(115, 40);
            btnCancel.TabIndex = 8;
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
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
            btnDelete.Location = new Point(707, 405);
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
            btnDelete.TabIndex = 9;
            btnDelete.TextAlignment = StringAlignment.Center;
            btnDelete.Click += btnDelete_Click;
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
            btnBack.TabIndex = 10;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.Click += btnBack_Click;
            // 
            // ShowingsForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnDone);
            Controls.Add(btnConfirm);
            Controls.Add(btnAdd);
            Controls.Add(grid);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblCount);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            Name = "ShowingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заявки на просмотр — EstateFlow";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblCount;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private DataGridView grid;
        private HartUI.Controls.cuiButton btnAdd;
        private HartUI.Controls.cuiButton btnConfirm;
        private HartUI.Controls.cuiButton btnDone;
        private HartUI.Controls.cuiButton btnCancel;
        private HartUI.Controls.cuiButton btnDelete;
        private HartUI.Controls.cuiButton btnBack;
    }
}
