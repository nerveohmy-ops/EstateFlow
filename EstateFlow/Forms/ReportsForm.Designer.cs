namespace EstateFlow.Forms
{
    partial class ReportsForm
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
            lblReportSummary = new Label();
            cmbReportType = new ComboBox();
            lblPeriod = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnBuild = new HartUI.Controls.cuiButton();
            grid = new DataGridView();
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
            lblHeader.Size = new Size(243, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Аналитические отчёты";
            // 
            // lblReportSummary
            // 
            lblReportSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblReportSummary.AutoSize = true;
            lblReportSummary.BackColor = Color.White;
            lblReportSummary.Font = new Font("Segoe UI", 9.5F);
            lblReportSummary.ForeColor = Color.DimGray;
            lblReportSummary.Location = new Point(365, 19);
            lblReportSummary.Name = "lblReportSummary";
            lblReportSummary.Size = new Size(135, 17);
            lblReportSummary.TabIndex = 1;
            lblReportSummary.Text = "Отчёт сформирован";
            // 
            // cmbReportType
            // 
            cmbReportType.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Font = new Font("Segoe UI", 9.5F);
            cmbReportType.Location = new Point(102, 56);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(250, 25);
            cmbReportType.TabIndex = 2;
            // 
            // lblPeriod
            // 
            lblPeriod.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblPeriod.AutoSize = true;
            lblPeriod.BackColor = Color.White;
            lblPeriod.Font = new Font("Segoe UI", 9.5F);
            lblPeriod.Location = new Point(365, 59);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(57, 17);
            lblPeriod.TabIndex = 3;
            lblPeriod.Text = "Период:";
            // 
            // dtpFrom
            // 
            dtpFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(428, 56);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(115, 23);
            dtpFrom.TabIndex = 4;
            dtpFrom.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // dtpTo
            // 
            dtpTo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(551, 56);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(115, 23);
            dtpTo.TabIndex = 5;
            // 
            // btnBuild
            // 
            btnBuild.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnBuild.BackColor = Color.White;
            btnBuild.CheckButton = false;
            btnBuild.Checked = false;
            btnBuild.Content = "Сформировать";
            btnBuild.Cursor = Cursors.Hand;
            btnBuild.Font = new Font("Segoe UI", 10F);
            btnBuild.ForeColor = Color.White;
            btnBuild.HoverBackground = Color.FromArgb(40, 40, 40);
            btnBuild.HoverForeColor = Color.White;
            btnBuild.HoverOutline = Color.Black;
            btnBuild.Location = new Point(682, 49);
            btnBuild.Name = "btnBuild";
            btnBuild.NormalBackground = Color.Black;
            btnBuild.NormalForeColor = Color.White;
            btnBuild.NormalOutline = Color.Black;
            btnBuild.OutlineThickness = 1F;
            btnBuild.Padding = new Padding(12);
            btnBuild.PressedBackground = Color.WhiteSmoke;
            btnBuild.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnBuild.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnBuild.Rounding = new Padding(20);
            btnBuild.Size = new Size(145, 38);
            btnBuild.TabIndex = 6;
            btnBuild.TextAlignment = StringAlignment.Center;
            btnBuild.Click += btnBuild_Click;
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
            grid.TabIndex = 7;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExport.BackColor = Color.White;
            btnExport.CheckButton = false;
            btnExport.Checked = false;
            btnExport.Content = "Экспорт в CSV";
            btnExport.Cursor = Cursors.Hand;
            btnExport.Font = new Font("Segoe UI", 10F);
            btnExport.ForeColor = Color.Black;
            btnExport.HoverBackground = Color.FromArgb(242, 242, 242);
            btnExport.HoverForeColor = Color.Black;
            btnExport.HoverOutline = Color.Black;
            btnExport.Location = new Point(148, 404);
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
            btnExport.Size = new Size(155, 40);
            btnExport.TabIndex = 8;
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
            btnBack.TabIndex = 9;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.Click += btnBack_Click;
            // 
            // ReportsForm
            // 
            ClientSize = new Size(984, 461);
            Controls.Add(btnBack);
            Controls.Add(btnExport);
            Controls.Add(grid);
            Controls.Add(btnBuild);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblPeriod);
            Controls.Add(cmbReportType);
            Controls.Add(lblReportSummary);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отчёты — EstateFlow";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblReportSummary;
        private ComboBox cmbReportType;
        private Label lblPeriod;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private HartUI.Controls.cuiButton btnBuild;
        private DataGridView grid;
        private HartUI.Controls.cuiButton btnExport;
        private HartUI.Controls.cuiButton btnBack;
    }
}
