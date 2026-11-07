namespace EstateFlow.Forms
{
    partial class HelpForm
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
            lstTopics = new ListBox();
            rtbContent = new RichTextBox();
            btnClose = new HartUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.White;
            lblHeader.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblHeader.Location = new Point(102, 16);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(286, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Руководство пользователя";
            // 
            // lstTopics
            // 
            lstTopics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstTopics.BackColor = Color.White;
            lstTopics.BorderStyle = BorderStyle.FixedSingle;
            lstTopics.Font = new Font("Segoe UI", 9.5F);
            lstTopics.ForeColor = Color.Black;
            lstTopics.ItemHeight = 17;
            lstTopics.Items.AddRange(new object[]
            {
                "1. Назначение программы",
                "2. Вход и регистрация",
                "3. Восстановление пароля",
                "4. Роли пользователей",
                "5. Объекты недвижимости",
                "6. Учёт сделок",
                "7. Заявки на просмотр",
                "8. Личный кабинет",
                "9. Отчёты и выгрузка"
            });
            lstTopics.Location = new Point(102, 56);
            lstTopics.Name = "lstTopics";
            lstTopics.Size = new Size(235, 334);
            lstTopics.TabIndex = 1;
            lstTopics.SelectedIndexChanged += LstTopics_SelectedIndexChanged;
            // 
            // rtbContent
            // 
            rtbContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbContent.BackColor = Color.White;
            rtbContent.BorderStyle = BorderStyle.FixedSingle;
            rtbContent.Font = new Font("Segoe UI", 10F);
            rtbContent.ForeColor = Color.Black;
            rtbContent.Location = new Point(352, 56);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(530, 334);
            rtbContent.TabIndex = 2;
            rtbContent.Text = "";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.White;
            btnClose.CheckButton = false;
            btnClose.Checked = false;
            btnClose.Content = "Назад";
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.ForeColor = Color.White;
            btnClose.HoverBackground = Color.FromArgb(40, 40, 40);
            btnClose.HoverForeColor = Color.White;
            btnClose.HoverOutline = Color.Black;
            btnClose.Location = new Point(742, 404);
            btnClose.Name = "btnClose";
            btnClose.NormalBackground = Color.Black;
            btnClose.NormalForeColor = Color.White;
            btnClose.NormalOutline = Color.Black;
            btnClose.OutlineThickness = 1F;
            btnClose.Padding = new Padding(12);
            btnClose.PressedBackground = Color.WhiteSmoke;
            btnClose.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnClose.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnClose.Rounding = new Padding(20);
            btnClose.Size = new Size(140, 40);
            btnClose.TabIndex = 3;
            btnClose.TextAlignment = StringAlignment.Center;
            btnClose.Click += btnClose_Click;
            // 
            // HelpForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnClose);
            Controls.Add(rtbContent);
            Controls.Add(lstTopics);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            Name = "HelpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство пользователя — EstateFlow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private ListBox lstTopics;
        private RichTextBox rtbContent;
        private HartUI.Controls.cuiButton btnClose;
    }
}
