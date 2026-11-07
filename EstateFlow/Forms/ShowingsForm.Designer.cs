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
            lblHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.White;
            lblHeader.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblHeader.Location = new Point(102, 14);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(216, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Заявки на просмотр";
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblCount.AutoSize = true;
            lblCount.BackColor = Color.White;
            lblCount.Font = new Font("Segoe UI", 9.5F);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(340, 21);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(65, 17);
            lblCount.TabIndex = 1;
            lblCount.Text = "Заявок: 0";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.Font = new Font("Segoe UI", 9.5F);
            lblStatus.Location = new Point(102, 59);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 17);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Статус заявки:";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "Все статусы", "Новая", "Подтверждена", "Проведена", "Отменена" });
            cmbStatus.Location = new Point(205, 56);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 25);
            cmbStatus.TabIndex = 3;
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
            grid.TabIndex = 4;
            grid.DoubleClick += grid_DoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.White;
            btnAdd.CheckButton = false;
            btnAdd.Checked = false;
            btnAdd.Content = "Записаться";
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
            btnAdd.Size = new Size(122, 40);
            btnAdd.TabIndex = 5;
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConfirm.BackColor = Color.White;
            btnConfirm.CheckButton = false;
            btnConfirm.Checked = false;
            btnConfirm.Content = "Подтвердить";
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Font = new Font("Segoe UI", 10F);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.HoverBackground = Color.FromArgb(242, 242, 242);
            btnConfirm.HoverForeColor = Color.Black;
            btnConfirm.HoverOutline = Color.Black;
            btnConfirm.Location = new Point(278, 404);
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
            btnConfirm.Size = new Size(125, 40);
            btnConfirm.TabIndex = 6;
            btnConfirm.TextAlignment = StringAlignment.Center;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDone.BackColor = Color.White;
            btnDone.CheckButton = false;
            btnDone.Checked = false;
            btnDone.Content = "Проведён";
            btnDone.Cursor = Cursors.Hand;
            btnDone.Font = new Font("Segoe UI", 10F);
            btnDone.ForeColor = Color.Black;
            btnDone.HoverBackground = Color.FromArgb(242, 242, 242);
            btnDone.HoverForeColor = Color.Black;
            btnDone.HoverOutline = Color.Black;
            btnDone.Location = new Point(411, 404);
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
            btnDone.Size = new Size(115, 40);
            btnDone.TabIndex = 7;
            btnDone.TextAlignment = StringAlignment.Center;
            btnDone.Click += btnDone_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.BackColor = Color.White;
            btnCancel.CheckButton = false;
            btnCancel.Checked = false;
            btnCancel.Content = "Отменить";
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.HoverBackground = Color.FromArgb(242, 242, 242);
            btnCancel.HoverForeColor = Color.Black;
            btnCancel.HoverOutline = Color.Black;
            btnCancel.Location = new Point(534, 404);
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
            btnCancel.Size = new Size(112, 40);
            btnCancel.TabIndex = 8;
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
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
            btnDelete.Location = new Point(654, 404);
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
            btnDelete.Size = new Size(108, 40);
            btnDelete.TabIndex = 9;
            btnDelete.TextAlignment = StringAlignment.Center;
            btnDelete.Click += btnDelete_Click;
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
