namespace EstateFlow.Forms
{
    partial class ShowingEditForm
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
            lblProperty = new Label();
            cmbProperty = new ComboBox();
            lblClient = new Label();
            cmbClient = new ComboBox();
            lblAgent = new Label();
            cmbAgent = new ComboBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblTime = new Label();
            cmbTime = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            txtComment = new HartUI.Controls.cuiTextBox();
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
            lblTitle.Location = new Point(216, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(346, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Запись на просмотр объекта";
            // 
            // lblProperty
            // 
            lblProperty.Anchor = AnchorStyles.None;
            lblProperty.AutoSize = true;
            lblProperty.BackColor = Color.White;
            lblProperty.Font = new Font("Segoe UI", 9F);
            lblProperty.Location = new Point(220, 72);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(137, 15);
            lblProperty.TabIndex = 1;
            lblProperty.Text = "Объект недвижимости:";
            // 
            // cmbProperty
            // 
            cmbProperty.Anchor = AnchorStyles.None;
            cmbProperty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProperty.Font = new Font("Segoe UI", 9.5F);
            cmbProperty.Location = new Point(220, 94);
            cmbProperty.Name = "cmbProperty";
            cmbProperty.Size = new Size(546, 25);
            cmbProperty.TabIndex = 2;
            cmbProperty.SelectedIndexChanged += CmbProperty_SelectedIndexChanged;
            // 
            // lblClient
            // 
            lblClient.Anchor = AnchorStyles.None;
            lblClient.AutoSize = true;
            lblClient.BackColor = Color.White;
            lblClient.Font = new Font("Segoe UI", 9F);
            lblClient.Location = new Point(220, 132);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(49, 15);
            lblClient.TabIndex = 3;
            lblClient.Text = "Клиент:";
            // 
            // cmbClient
            // 
            cmbClient.Anchor = AnchorStyles.None;
            cmbClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClient.Font = new Font("Segoe UI", 9.5F);
            cmbClient.Location = new Point(220, 154);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(262, 25);
            cmbClient.TabIndex = 4;
            // 
            // lblAgent
            // 
            lblAgent.Anchor = AnchorStyles.None;
            lblAgent.AutoSize = true;
            lblAgent.BackColor = Color.White;
            lblAgent.Font = new Font("Segoe UI", 9F);
            lblAgent.Location = new Point(504, 132);
            lblAgent.Name = "lblAgent";
            lblAgent.Size = new Size(146, 15);
            lblAgent.TabIndex = 5;
            lblAgent.Text = "Ответственный риэлтор:";
            // 
            // cmbAgent
            // 
            cmbAgent.Anchor = AnchorStyles.None;
            cmbAgent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAgent.Font = new Font("Segoe UI", 9.5F);
            cmbAgent.Location = new Point(504, 154);
            cmbAgent.Name = "cmbAgent";
            cmbAgent.Size = new Size(262, 25);
            cmbAgent.TabIndex = 6;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.White;
            lblDate.Font = new Font("Segoe UI", 9F);
            lblDate.Location = new Point(220, 192);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(78, 15);
            lblDate.TabIndex = 7;
            lblDate.Text = "Дата показа:";
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.None;
            dtpDate.Font = new Font("Segoe UI", 9.5F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(220, 214);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(146, 24);
            dtpDate.TabIndex = 8;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.None;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.White;
            lblTime.Font = new Font("Segoe UI", 9F);
            lblTime.Location = new Point(376, 192);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(86, 15);
            lblTime.TabIndex = 9;
            lblTime.Text = "Время показа:";
            // 
            // cmbTime
            // 
            cmbTime.Anchor = AnchorStyles.None;
            cmbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTime.Font = new Font("Segoe UI", 9.5F);
            cmbTime.Items.AddRange(new object[]
            {
                "09:00", "09:30", "10:00", "10:30", "11:00", "11:30",
                "12:00", "12:30", "13:00", "13:30", "14:00", "14:30",
                "15:00", "15:30", "16:00", "16:30", "17:00", "17:30",
                "18:00", "18:30", "19:00", "19:30", "20:00"
            });
            cmbTime.Location = new Point(376, 214);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(106, 25);
            cmbTime.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.None;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.Location = new Point(504, 192);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(88, 15);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Статус заявки:";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.None;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "Новая", "Подтверждена", "Проведена", "Отменена" });
            cmbStatus.Location = new Point(504, 214);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(262, 25);
            cmbStatus.TabIndex = 12;
            // 
            // txtComment
            // 
            txtComment.Anchor = AnchorStyles.None;
            txtComment.BackColor = Color.White;
            txtComment.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtComment.Content = "";
            txtComment.FocusBackgroundColor = Color.White;
            txtComment.FocusImageTint = Color.White;
            txtComment.FocusOutlineColor = Color.Black;
            txtComment.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComment.ForeColor = Color.Black;
            txtComment.Location = new Point(216, 260);
            txtComment.Name = "txtComment";
            txtComment.NormalImageTint = Color.White;
            txtComment.OutlineColor = Color.FromArgb(95, 95, 95);
            txtComment.Padding = new Padding(14, 12, 14, 0);
            txtComment.PasswordChar = false;
            txtComment.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtComment.PlaceholderText = "Комментарий к заявке (пожелания, удобное время и т.д.)";
            txtComment.Rounding = new Padding(12);
            txtComment.Size = new Size(552, 45);
            txtComment.TabIndex = 13;
            txtComment.UnderlinedStyle = false;
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
            btnSave.Location = new Point(216, 345);
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
            btnSave.TabIndex = 14;
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
            btnCancel.Location = new Point(502, 345);
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
            btnCancel.TabIndex = 15;
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
            // 
            // ShowingEditForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtComment);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbTime);
            Controls.Add(lblTime);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(cmbAgent);
            Controls.Add(lblAgent);
            Controls.Add(cmbClient);
            Controls.Add(lblClient);
            Controls.Add(cmbProperty);
            Controls.Add(lblProperty);
            Controls.Add(lblTitle);
            DoubleBuffered = true;
            Name = "ShowingEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Запись на просмотр — EstateFlow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblProperty;
        private ComboBox cmbProperty;
        private Label lblClient;
        private ComboBox cmbClient;
        private Label lblAgent;
        private ComboBox cmbAgent;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblTime;
        private ComboBox cmbTime;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private HartUI.Controls.cuiTextBox txtComment;
        private HartUI.Controls.cuiButton btnSave;
        private HartUI.Controls.cuiButton btnCancel;
    }
}
