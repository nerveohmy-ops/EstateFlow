namespace EstateFlow.Forms
{
    partial class AboutForm
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
            lblBrand = new Label();
            lblSub = new Label();
            txtDetails = new TextBox();
            btnClose = new HartUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // lblBrand
            // 
            lblBrand.Anchor = AnchorStyles.None;
            lblBrand.AutoSize = true;
            lblBrand.BackColor = Color.White;
            lblBrand.Font = new Font("Microsoft Sans Serif", 20.25F);
            lblBrand.Location = new Point(414, 30);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(150, 31);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "EstateFlow";
            // 
            // lblSub
            // 
            lblSub.Anchor = AnchorStyles.None;
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.White;
            lblSub.Font = new Font("Segoe UI", 11F);
            lblSub.Location = new Point(375, 68);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(215, 20);
            lblSub.TabIndex = 1;
            lblSub.Text = "Учёт риэлторских операций";
            // 
            // txtDetails
            // 
            txtDetails.Anchor = AnchorStyles.None;
            txtDetails.BackColor = Color.White;
            txtDetails.BorderStyle = BorderStyle.FixedSingle;
            txtDetails.Font = new Font("Segoe UI", 10F);
            txtDetails.ForeColor = Color.Black;
            txtDetails.Location = new Point(216, 108);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.Size = new Size(552, 250);
            txtDetails.TabIndex = 2;
            txtDetails.Text = "Информационная система агентства недвижимости EstateFlow\r\n\r\n" +
                "Назначение программы:\r\n" +
                "Автоматизация учёта объектов недвижимости, риэлторских сделок купли-продажи, заявок клиентов на просмотр и формирования отчётности.\r\n\r\n" +
                "Основные модули:\r\n" +
                "• Авторизация, регистрация и восстановление доступа\r\n" +
                "• Ролевое разграничение прав (Администратор, Агент, Клиент)\r\n" +
                "• Каталог объектов недвижимости и справочник типов\r\n" +
                "• Журнал сделок и расписание просмотров\r\n" +
                "• Аналитические отчёты и выгрузка данных в CSV\r\n\r\n" +
                "Платформа: Windows Forms (.NET 10), MS SQL Server LocalDB.";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = Color.White;
            btnClose.CheckButton = false;
            btnClose.Checked = false;
            btnClose.Content = "Назад";
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 10.5F);
            btnClose.ForeColor = Color.White;
            btnClose.HoverBackground = Color.FromArgb(40, 40, 40);
            btnClose.HoverForeColor = Color.White;
            btnClose.HoverOutline = Color.Black;
            btnClose.Location = new Point(359, 380);
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
            btnClose.Size = new Size(266, 45);
            btnClose.TabIndex = 3;
            btnClose.TextAlignment = StringAlignment.Center;
            btnClose.Click += btnClose_Click;
            // 
            // AboutForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnClose);
            Controls.Add(txtDetails);
            Controls.Add(lblSub);
            Controls.Add(lblBrand);
            DoubleBuffered = true;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе — EstateFlow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrand;
        private Label lblSub;
        private TextBox txtDetails;
        private HartUI.Controls.cuiButton btnClose;
    }
}
