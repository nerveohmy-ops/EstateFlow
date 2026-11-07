namespace EstateFlow.Forms
{
    partial class UsersForm
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
            lblRole = new Label();
            cmbRole = new ComboBox();
            grid = new DataGridView();
            btnAdd = new HartUI.Controls.cuiButton();
            btnEdit = new HartUI.Controls.cuiButton();
            btnResetPassword = new HartUI.Controls.cuiButton();
            btnDelete = new HartUI.Controls.cuiButton();
            btnResetDb = new HartUI.Controls.cuiButton();
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
            lblHeader.Size = new Size(158, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Пользователи";
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblCount.AutoSize = true;
            lblCount.BackColor = Color.White;
            lblCount.Font = new Font("Segoe UI", 9.5F);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(280, 19);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(118, 17);
            lblCount.TabIndex = 1;
            lblCount.Text = "Пользователей: 0";
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
            txtSearch.PlaceholderText = "Поиск по ФИО, логину, email, телефону";
            txtSearch.Rounding = new Padding(20);
            txtSearch.Size = new Size(310, 45);
            txtSearch.TabIndex = 2;
            txtSearch.UnderlinedStyle = true;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.White;
            lblRole.Font = new Font("Segoe UI", 9.5F);
            lblRole.Location = new Point(428, 59);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(40, 17);
            lblRole.TabIndex = 3;
            lblRole.Text = "Роль:";
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 9.5F);
            cmbRole.Location = new Point(472, 56);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(165, 25);
            cmbRole.TabIndex = 4;
            // 
            // btnResetDb
            // 
            btnResetDb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResetDb.BackColor = Color.White;
            btnResetDb.CheckButton = false;
            btnResetDb.Checked = false;
            btnResetDb.Content = "Сброс тестовых данных";
            btnResetDb.Cursor = Cursors.Hand;
            btnResetDb.Font = new Font("Segoe UI", 9.5F);
            btnResetDb.ForeColor = Color.Black;
            btnResetDb.HoverBackground = Color.FromArgb(242, 242, 242);
            btnResetDb.HoverForeColor = Color.Black;
            btnResetDb.HoverOutline = Color.Black;
            btnResetDb.Location = new Point(692, 49);
            btnResetDb.Name = "btnResetDb";
            btnResetDb.NormalBackground = Color.White;
            btnResetDb.NormalForeColor = Color.Black;
            btnResetDb.NormalOutline = Color.Black;
            btnResetDb.OutlineThickness = 1F;
            btnResetDb.Padding = new Padding(10);
            btnResetDb.PressedBackground = Color.WhiteSmoke;
            btnResetDb.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnResetDb.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnResetDb.Rounding = new Padding(20);
            btnResetDb.Size = new Size(190, 38);
            btnResetDb.TabIndex = 5;
            btnResetDb.TextAlignment = StringAlignment.Center;
            btnResetDb.Click += btnResetDb_Click;
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
            grid.TabIndex = 6;
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
            btnAdd.Size = new Size(125, 40);
            btnAdd.TabIndex = 7;
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
            btnEdit.Location = new Point(281, 404);
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
            btnEdit.Size = new Size(122, 40);
            btnEdit.TabIndex = 8;
            btnEdit.TextAlignment = StringAlignment.Center;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResetPassword.BackColor = Color.White;
            btnResetPassword.CheckButton = false;
            btnResetPassword.Checked = false;
            btnResetPassword.Content = "Сбросить пароль";
            btnResetPassword.Cursor = Cursors.Hand;
            btnResetPassword.Font = new Font("Segoe UI", 10F);
            btnResetPassword.ForeColor = Color.Black;
            btnResetPassword.HoverBackground = Color.FromArgb(242, 242, 242);
            btnResetPassword.HoverForeColor = Color.Black;
            btnResetPassword.HoverOutline = Color.Black;
            btnResetPassword.Location = new Point(411, 404);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.NormalBackground = Color.White;
            btnResetPassword.NormalForeColor = Color.Black;
            btnResetPassword.NormalOutline = Color.Black;
            btnResetPassword.OutlineThickness = 1F;
            btnResetPassword.Padding = new Padding(12);
            btnResetPassword.PressedBackground = Color.WhiteSmoke;
            btnResetPassword.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnResetPassword.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnResetPassword.Rounding = new Padding(20);
            btnResetPassword.Size = new Size(155, 40);
            btnResetPassword.TabIndex = 9;
            btnResetPassword.TextAlignment = StringAlignment.Center;
            btnResetPassword.Click += btnResetPassword_Click;
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
            btnDelete.Location = new Point(574, 404);
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
            btnDelete.TabIndex = 10;
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
            btnBack.TabIndex = 11;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.Click += btnBack_Click;
            // 
            // UsersForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnResetPassword);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(grid);
            Controls.Add(btnResetDb);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(txtSearch);
            Controls.Add(lblCount);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пользователи — EstateFlow";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblCount;
        private HartUI.Controls.cuiTextBox txtSearch;
        private Label lblRole;
        private ComboBox cmbRole;
        private DataGridView grid;
        private HartUI.Controls.cuiButton btnAdd;
        private HartUI.Controls.cuiButton btnEdit;
        private HartUI.Controls.cuiButton btnResetPassword;
        private HartUI.Controls.cuiButton btnDelete;
        private HartUI.Controls.cuiButton btnResetDb;
        private HartUI.Controls.cuiButton btnBack;
    }
}
