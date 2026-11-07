namespace EstateFlow.Forms
{
    partial class PropertyTypesForm
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
            grid = new DataGridView();
            btnAdd = new HartUI.Controls.cuiButton();
            btnRename = new HartUI.Controls.cuiButton();
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
            lblHeader.Location = new Point(167, 16);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(346, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Справочник типов недвижимости";
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblCount.AutoSize = true;
            lblCount.BackColor = Color.White;
            lblCount.Font = new Font("Segoe UI", 9.5F);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(540, 23);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(86, 17);
            lblCount.TabIndex = 1;
            lblCount.Text = "Категорий: 0";
            // 
            // grid
            // 
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(167, 60);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.Size = new Size(650, 326);
            grid.TabIndex = 2;
            grid.DoubleClick += grid_DoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.White;
            btnAdd.CheckButton = false;
            btnAdd.Checked = false;
            btnAdd.Content = "Добавить";
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 10F);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverBackground = Color.FromArgb(40, 40, 40);
            btnAdd.HoverForeColor = Color.White;
            btnAdd.HoverOutline = Color.Black;
            btnAdd.Location = new Point(167, 402);
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
            btnAdd.TabIndex = 3;
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRename
            // 
            btnRename.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRename.BackColor = Color.White;
            btnRename.CheckButton = false;
            btnRename.Checked = false;
            btnRename.Content = "Переименовать";
            btnRename.Cursor = Cursors.Hand;
            btnRename.Font = new Font("Segoe UI", 10F);
            btnRename.ForeColor = Color.Black;
            btnRename.HoverBackground = Color.FromArgb(242, 242, 242);
            btnRename.HoverForeColor = Color.Black;
            btnRename.HoverOutline = Color.Black;
            btnRename.Location = new Point(317, 402);
            btnRename.Name = "btnRename";
            btnRename.NormalBackground = Color.White;
            btnRename.NormalForeColor = Color.Black;
            btnRename.NormalOutline = Color.Black;
            btnRename.OutlineThickness = 1F;
            btnRename.Padding = new Padding(12);
            btnRename.PressedBackground = Color.WhiteSmoke;
            btnRename.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRename.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRename.Rounding = new Padding(20);
            btnRename.Size = new Size(155, 40);
            btnRename.TabIndex = 4;
            btnRename.TextAlignment = StringAlignment.Center;
            btnRename.Click += btnRename_Click;
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
            btnDelete.Location = new Point(482, 402);
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
            btnDelete.Size = new Size(130, 40);
            btnDelete.TabIndex = 5;
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
            btnBack.Location = new Point(687, 402);
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
            btnBack.Size = new Size(130, 40);
            btnBack.TabIndex = 6;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.Click += btnBack_Click;
            // 
            // PropertyTypesForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnRename);
            Controls.Add(btnAdd);
            Controls.Add(grid);
            Controls.Add(lblCount);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            Name = "PropertyTypesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Типы недвижимости — EstateFlow";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblCount;
        private DataGridView grid;
        private HartUI.Controls.cuiButton btnAdd;
        private HartUI.Controls.cuiButton btnRename;
        private HartUI.Controls.cuiButton btnDelete;
        private HartUI.Controls.cuiButton btnBack;
    }
}
