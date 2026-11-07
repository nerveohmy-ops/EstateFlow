namespace EstateFlow.Forms
{
    partial class DealEditForm
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
            lblAmount = new Label();
            txtAmount = new HartUI.Controls.cuiTextBox();
            lblAmountHint = new Label();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
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
            lblTitle.Size = new Size(255, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Оформление сделки";
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
            lblClient.Size = new Size(125, 15);
            lblClient.TabIndex = 3;
            lblClient.Text = "Клиент (покупатель):";
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
            lblAgent.Size = new Size(130, 15);
            lblAgent.TabIndex = 5;
            lblAgent.Text = "Ответственный агент:";
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
            lblDate.Location = new Point(220, 195);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(109, 15);
            lblDate.TabIndex = 7;
            lblDate.Text = "Дата заключения:";
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.None;
            dtpDate.Font = new Font("Segoe UI", 9.5F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(220, 217);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(262, 24);
            dtpDate.TabIndex = 8;
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.None;
            lblAmount.AutoSize = true;
            lblAmount.BackColor = Color.White;
            lblAmount.Font = new Font("Segoe UI", 9F);
            lblAmount.Location = new Point(504, 190);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(115, 15);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Сумма сделки (₽):";
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.None;
            txtAmount.BackColor = Color.White;
            txtAmount.BackgroundColor = Color.FromArgb(245, 246, 248);
            txtAmount.Content = "";
            txtAmount.FocusBackgroundColor = Color.White;
            txtAmount.FocusImageTint = Color.White;
            txtAmount.FocusOutlineColor = Color.Black;
            txtAmount.Font = new Font("Segoe UI", 9.5F);
            txtAmount.ForeColor = Color.Black;
            txtAmount.Location = new Point(502, 209);
            txtAmount.Name = "txtAmount";
            txtAmount.NormalImageTint = Color.White;
            txtAmount.OutlineColor = Color.FromArgb(95, 95, 95);
            txtAmount.Padding = new Padding(14, 12, 14, 0);
            txtAmount.PasswordChar = false;
            txtAmount.PlaceholderColor = Color.FromArgb(115, 115, 115);
            txtAmount.PlaceholderText = "Сумма сделки (₽)";
            txtAmount.Rounding = new Padding(12);
            txtAmount.Size = new Size(266, 42);
            txtAmount.TabIndex = 9;
            txtAmount.UnderlinedStyle = false;
            // 
            // lblAmountHint
            // 
            lblAmountHint.Anchor = AnchorStyles.None;
            lblAmountHint.AutoSize = true;
            lblAmountHint.BackColor = Color.White;
            lblAmountHint.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblAmountHint.ForeColor = Color.FromArgb(50, 50, 50);
            lblAmountHint.Location = new Point(504, 253);
            lblAmountHint.Name = "lblAmountHint";
            lblAmountHint.Size = new Size(210, 15);
            lblAmountHint.TabIndex = 10;
            lblAmountHint.Text = "Например: 7 800 000 (= 7,8 млн ₽)";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.None;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.Location = new Point(220, 265);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(88, 15);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Статус сделки:";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.None;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "В процессе", "Завершена", "Отменена" });
            cmbStatus.Location = new Point(220, 287);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(546, 25);
            cmbStatus.TabIndex = 11;
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
            btnSave.Location = new Point(216, 355);
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
            btnSave.TabIndex = 12;
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
            btnCancel.Location = new Point(502, 355);
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
            btnCancel.TabIndex = 13;
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
            // 
            // DealEditForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblAmountHint);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
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
            Name = "DealEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сделка — EstateFlow";
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
        private Label lblAmount;
        private HartUI.Controls.cuiTextBox txtAmount;
        private Label lblAmountHint;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private HartUI.Controls.cuiButton btnSave;
        private HartUI.Controls.cuiButton btnCancel;
    }
}
