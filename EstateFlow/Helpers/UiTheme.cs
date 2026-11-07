using HartUI.Controls;

namespace EstateFlow.Helpers
{
    public static class UiTheme
    {
        public static readonly Color Primary = Color.Black;
        public static readonly Color Secondary = Color.FromArgb(80, 80, 80);
        public static readonly Color LightBg = Color.FromArgb(248, 248, 248);
        public static readonly Color Background = Color.White;
        public static readonly Color CardBg = Color.White;
        public static readonly Color Border = Color.FromArgb(215, 215, 215);
        public static readonly Color DarkBorder = Color.Black;
        public static readonly Color TextMain = Color.Black;
        public static readonly Color TextMuted = Color.Gray;

        public const string AppName = "EstateFlow";

        public static cuiTextBox CreateTextBox(string placeholder, int width = 266, bool isPassword = false)
        {
            var tb = new cuiTextBox
            {
                Anchor = AnchorStyles.None,
                BackColor = Color.White,
                BackgroundColor = Color.White,
                Content = "",
                FocusBackgroundColor = Color.White,
                FocusImageTint = Color.White,
                FocusOutlineColor = Color.Black,
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                NormalImageTint = Color.White,
                OutlineColor = Color.FromArgb(128, 128, 128, 128),
                Padding = new Padding(16, 14, 16, 0),
                PasswordChar = isPassword,
                PlaceholderColor = Color.LightGray,
                PlaceholderText = placeholder,
                Rounding = new Padding(20),
                Size = new Size(width, 45),
                UnderlinedStyle = true
            };
            return tb;
        }

        public static cuiButton CreateButton(string text, bool isBlack = false, int width = 125, int height = 45)
        {
            var btn = new cuiButton
            {
                Anchor = AnchorStyles.None,
                BackColor = Color.White,
                CheckButton = false,
                Checked = false,
                Content = text,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 10.5F),
                ForeColor = isBlack ? Color.White : Color.Black,
                HoverBackground = isBlack ? Color.FromArgb(40, 40, 40) : Color.White,
                HoverForeColor = isBlack ? Color.White : Color.DimGray,
                HoverOutline = Color.Black,
                NormalBackground = isBlack ? Color.Black : Color.White,
                NormalForeColor = isBlack ? Color.White : Color.Black,
                NormalOutline = Color.Black,
                OutlineThickness = 1F,
                Padding = new Padding(12),
                PressedBackground = Color.WhiteSmoke,
                PressedForeColor = Color.FromArgb(32, 32, 32),
                PressedOutline = Color.FromArgb(64, 128, 128, 128),
                Rounding = new Padding(20),
                Size = new Size(width, height),
                TextAlignment = StringAlignment.Center
            };
            return btn;
        }

        public static cuiCheckbox CreateCheckBox(string text)
        {
            return new cuiCheckbox
            {
                Anchor = AnchorStyles.None,
                BackColor = Color.White,
                Checked = false,
                CheckedForeground = Color.Black,
                CheckedOutlineColor = Color.Black,
                CheckedSymbolColor = Color.White,
                Content = text,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 10F),
                OutlineThickness = 1F,
                Rounding = 4,
                ShowSymbols = true,
                Size = new Size(145, 20),
                UncheckedForeground = Color.Empty,
                UncheckedOutlineColor = Color.Gray,
                UncheckedSymbolColor = Color.Empty
            };
        }

        // маска телефона +7(XXX)XXX-XX-XX для cuiTextBox
        public static void AttachPhoneMask(cuiTextBox tb)
        {
            bool formatting = false;
            tb.ContentChanged += (s, e) =>
            {
                if (formatting) return;
                formatting = true;
                string digits = new string((tb.Content ?? "").Where(char.IsDigit).ToArray());
                if (digits.StartsWith("8")) digits = "7" + digits.Substring(1);
                if (digits.Length > 0 && !digits.StartsWith("7")) digits = "7" + digits;
                if (digits.Length > 11) digits = digits.Substring(0, 11);

                string formatted = "";
                if (digits.Length > 0)
                {
                    formatted = "+7";
                    if (digits.Length > 1)
                        formatted += "(" + digits.Substring(1, Math.Min(3, digits.Length - 1));
                    if (digits.Length >= 4)
                        formatted += ")";
                    if (digits.Length > 4)
                        formatted += digits.Substring(4, Math.Min(3, digits.Length - 4));
                    if (digits.Length > 7)
                        formatted += "-" + digits.Substring(7, Math.Min(2, digits.Length - 7));
                    if (digits.Length > 9)
                        formatted += "-" + digits.Substring(9, Math.Min(2, digits.Length - 9));
                }
                if (tb.Content != formatted)
                    tb.Content = formatted;
                formatting = false;
            };
        }

        public static void StyleGrid(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;
            grid.BackgroundColor = Color.White;
            grid.GridColor = Border;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            grid.ColumnHeadersHeight = 36;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 40, 40);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 246, 248);
            grid.RowTemplate.Height = 30;

            grid.DataBindingComplete -= Grid_DataBindingComplete;
            grid.DataBindingComplete += Grid_DataBindingComplete;
        }

        private static void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var grid = (DataGridView)sender;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (col.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
                    col.Visible = false;

                if (col.ValueType == typeof(decimal))
                {
                    col.DefaultCellStyle.Format = "N2";
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (col.ValueType == typeof(DateTime))
                {
                    col.DefaultCellStyle.Format = col.Name.Contains("время", StringComparison.OrdinalIgnoreCase)
                        ? "dd.MM.yyyy HH:mm" : "dd.MM.yyyy";
                }
            }
        }

        public static void StylePrimaryButton(Button btn)
        {
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9.5F);
        }

        public static void StyleSecondaryButton(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.Black;
            btn.FlatAppearance.BorderSize = 1;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9.5F);
        }

        public static int? SelectedId(DataGridView grid)
        {
            if (grid.CurrentRow == null || !grid.Columns.Contains("Id")) return null;
            return grid.CurrentRow.Cells["Id"].Value as int?;
        }

        public static void Info(string text) =>
            MessageBox.Show(text, AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void Error(string text) =>
            MessageBox.Show(text, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void Warning(string text) =>
            MessageBox.Show(text, AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static bool Confirm(string text) =>
            MessageBox.Show(text, AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        public static void ExitApplication()
        {
            if (Confirm("Завершить работу с программой?"))
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }

        public static bool Try(Action action)
        {
            try
            {
                action();
                return true;
            }
            catch (InvalidOperationException ex)
            {
                Warning(ex.Message);
            }
            catch (Exception ex)
            {
                Error("Ошибка при работе с БД:\n" + ex.Message);
            }
            return false;
        }

        public static void SelectById(ComboBox combo, int? id)
        {
            combo.SelectedItem = combo.Items.Cast<Models.LookupItem>().FirstOrDefault(i => i.Id == id);
        }

        public static int? SelectedLookupId(ComboBox combo) => (combo.SelectedItem as Models.LookupItem)?.Id;
    }
}
