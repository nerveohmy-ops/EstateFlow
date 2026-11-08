using HartUI.Controls;

namespace EstateFlow.Helpers
{
    public static class UiTheme
    {
        public static bool IsDark { get; private set; } = false;

        public static event Action ThemeChanged;

        public static Color Primary => IsDark ? Color.White : Color.Black;
        public static Color Secondary => IsDark ? Color.FromArgb(160, 160, 160) : Color.FromArgb(80, 80, 80);
        public static Color Background => IsDark ? Color.FromArgb(24, 25, 28) : Color.White;
        public static Color CardBg => IsDark ? Color.FromArgb(32, 33, 37) : Color.White;
        public static Color Border => IsDark ? Color.FromArgb(60, 62, 68) : Color.FromArgb(215, 215, 215);
        public static Color DarkBorder => IsDark ? Color.White : Color.Black;
        public static Color TextMain => IsDark ? Color.FromArgb(240, 240, 245) : Color.Black;
        public static Color TextMuted => IsDark ? Color.FromArgb(160, 162, 170) : Color.Gray;

        public static Color TextBoxBg => IsDark ? Color.FromArgb(38, 40, 45) : Color.FromArgb(245, 246, 248);
        public static Color TextBoxFocusBg => IsDark ? Color.FromArgb(48, 50, 56) : Color.White;
        public static Color TextBoxOutline => IsDark ? Color.FromArgb(85, 88, 98) : Color.FromArgb(95, 95, 95);
        public static Color TextBoxFocusOutline => IsDark ? Color.FromArgb(220, 220, 225) : Color.Black;
        public static Color TextBoxPlaceholder => IsDark ? Color.FromArgb(140, 142, 150) : Color.FromArgb(115, 115, 115);

        public static void SetDarkTheme(bool dark)
        {
            if (IsDark == dark) return;
            IsDark = dark;
            ThemeChanged?.Invoke();
        }

        public static void ToggleTheme()
        {
            SetDarkTheme(!IsDark);
        }

        public const string AppName = "EstateFlow";

        public static cuiTextBox CreateTextBox(string placeholder, int width = 266, bool isPassword = false)
        {
            var tb = new cuiTextBox
            {
                Anchor = AnchorStyles.None,
                BackColor = Color.White,
                BackgroundColor = Color.FromArgb(245, 246, 248),
                Content = "",
                FocusBackgroundColor = Color.White,
                FocusImageTint = Color.White,
                FocusOutlineColor = Color.Black,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 204),
                ForeColor = Color.Black,
                NormalImageTint = Color.White,
                OutlineColor = Color.FromArgb(95, 95, 95),
                Padding = new Padding(14, 12, 14, 0),
                PasswordChar = isPassword,
                PlaceholderColor = Color.FromArgb(115, 115, 115),
                PlaceholderText = placeholder,
                Rounding = new Padding(12),
                Size = new Size(width, 42),
                UnderlinedStyle = false
            };
            return tb;
        }

        // делает все cuiTextBox на форме контрастными и выразительными
        public static void StyleTextBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is cuiTextBox tb)
                {
                    tb.UnderlinedStyle = false;
                    tb.BackColor = Background;
                    tb.BackgroundColor = tb.Enabled ? TextBoxBg : (IsDark ? Color.FromArgb(30, 31, 35) : Color.FromArgb(232, 232, 235));
                    tb.FocusBackgroundColor = TextBoxFocusBg;
                    tb.OutlineColor = TextBoxOutline;
                    tb.FocusOutlineColor = TextBoxFocusOutline;
                    tb.PlaceholderColor = TextBoxPlaceholder;
                    tb.ForeColor = TextMain;
                    tb.Rounding = new Padding(12);
                    tb.Invalidate();
                }
                if (c.HasChildren && c is not cuiTextBox)
                {
                    StyleTextBoxes(c);
                }
            }
        }

        // авторазбивка суммы по разрядам (7 800 000) + живая подсказка в миллионах
        public static void AttachPriceFormatter(cuiTextBox tb, Label hintLabel = null)
        {
            bool formatting = false;
            void UpdatePrice()
            {
                if (formatting) return;
                formatting = true;

                string raw = tb.Content ?? "";
                string digits = new string(raw.Where(char.IsDigit).ToArray());
                if (digits.Length > 12) digits = digits.Substring(0, 12);

                if (long.TryParse(digits, out long val) && val > 0)
                {
                    string formatted = val.ToString("#,0", System.Globalization.CultureInfo.GetCultureInfo("ru-RU"))
                                          .Replace('\u00A0', ' ');
                    if (tb.Content != formatted)
                        tb.Content = formatted;

                    if (hintLabel != null)
                        hintLabel.Text = FormatPriceReadable(val);
                }
                else
                {
                    if (digits.Length == 0 && tb.Content != "")
                        tb.Content = "";
                    if (hintLabel != null)
                        hintLabel.Text = "Например: 7 800 000 (= 7,8 млн ₽)";
                }

                formatting = false;
            }

            tb.ContentChanged += (s, e) => UpdatePrice();
            UpdatePrice();
        }

        public static string FormatPriceReadable(decimal val)
        {
            if (val <= 0) return "";
            if (val >= 1_000_000_000m)
            {
                decimal mlrd = val / 1_000_000_000m;
                return $"≈ {mlrd:0.###} млрд ₽";
            }
            if (val >= 1_000_000m)
            {
                decimal mln = val / 1_000_000m;
                long wholeMln = (long)(val / 1_000_000m);
                long remTys = (long)((val % 1_000_000m) / 1_000m);
                if (remTys > 0)
                    return $"= {wholeMln} млн {remTys} тыс. ₽ ({mln:0.##} млн ₽)";
                return $"= {wholeMln} млн ₽";
            }
            if (val >= 1_000m)
            {
                decimal tys = val / 1_000m;
                return $"= {tys:0.##} тыс. ₽";
            }
            return $"= {val:N0} ₽".Replace('\u00A0', ' ');
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
            grid.BackgroundColor = CardBg;
            grid.GridColor = Border;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor = IsDark ? Color.FromArgb(45, 47, 54) : Color.Black;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = IsDark ? Color.FromArgb(45, 47, 54) : Color.Black;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            grid.ColumnHeadersHeight = 36;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            grid.DefaultCellStyle.BackColor = CardBg;
            grid.DefaultCellStyle.ForeColor = TextMain;
            grid.DefaultCellStyle.SelectionBackColor = IsDark ? Color.FromArgb(60, 65, 75) : Color.FromArgb(40, 40, 40);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            grid.AlternatingRowsDefaultCellStyle.BackColor = IsDark ? Color.FromArgb(28, 29, 33) : Color.FromArgb(247, 247, 249);
            grid.AlternatingRowsDefaultCellStyle.ForeColor = TextMain;
            grid.RowTemplate.Height = 32;

            grid.DataBindingComplete -= Grid_DataBindingComplete;
            grid.DataBindingComplete += Grid_DataBindingComplete;
            grid.CellFormatting -= Grid_CellFormatting;
            grid.CellFormatting += Grid_CellFormatting;
        }

        private static void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var colName = grid.Columns[e.ColumnIndex].Name;
            if (colName.Equals("Статус", StringComparison.OrdinalIgnoreCase) && e.Value is string status)
            {
                if (status == "Отменена" || status == "Продан")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(120, 120, 120);
                }
                else if (status == "Завершена" || status == "Подтверждена" || status == "Проведена")
                {
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
            }
        }

        public static void ApplyTheme(Form form)
        {
            form.BackColor = Background;

            void Recurse(Control parent)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is cuiTextBox tb)
                    {
                        tb.BackColor = Background;
                        tb.BackgroundColor = tb.Enabled ? TextBoxBg : (IsDark ? Color.FromArgb(30, 31, 35) : Color.FromArgb(232, 232, 235));
                        tb.FocusBackgroundColor = TextBoxFocusBg;
                        tb.OutlineColor = TextBoxOutline;
                        tb.FocusOutlineColor = TextBoxFocusOutline;
                        tb.PlaceholderColor = TextBoxPlaceholder;
                        tb.ForeColor = TextMain;
                        tb.Invalidate();
                    }
                    else if (c is cuiButton btn)
                    {
                        if (btn.Name == "btnThemeToggle") continue;
                        btn.BackColor = Background;
                        // проверяем темная кнопка или светлая
                        bool isActionDark = btn.NormalBackground == Color.Black || btn.NormalBackground == Color.FromArgb(240, 240, 245) || btn.NormalForeColor == Color.White;
                        if (isActionDark)
                        {
                            btn.NormalBackground = IsDark ? Color.FromArgb(240, 240, 245) : Color.Black;
                            btn.NormalForeColor = IsDark ? Color.Black : Color.White;
                            btn.NormalOutline = IsDark ? Color.White : Color.Black;
                            btn.HoverBackground = IsDark ? Color.White : Color.FromArgb(40, 40, 40);
                            btn.HoverForeColor = IsDark ? Color.Black : Color.White;
                        }
                        else
                        {
                            btn.NormalBackground = IsDark ? Color.FromArgb(32, 33, 37) : Color.White;
                            btn.NormalForeColor = IsDark ? Color.FromArgb(240, 240, 245) : Color.Black;
                            btn.NormalOutline = IsDark ? Color.FromArgb(85, 88, 98) : Color.Black;
                            btn.HoverBackground = IsDark ? Color.FromArgb(45, 47, 54) : Color.FromArgb(242, 242, 242);
                            btn.HoverForeColor = IsDark ? Color.White : Color.Black;
                        }
                        btn.Invalidate();
                    }
                    else if (c is cuiCheckbox chk)
                    {
                        chk.BackColor = Background;
                        chk.CheckedForeground = TextMain;
                        chk.CheckedOutlineColor = TextMain;
                        chk.CheckedSymbolColor = IsDark ? Color.Black : Color.White;
                        chk.UncheckedOutlineColor = TextMuted;
                        chk.ForeColor = TextMain;
                        chk.Invalidate();
                    }
                    else if (c is DataGridView g)
                    {
                        StyleGrid(g);
                        g.Invalidate();
                    }
                    else if (c is ComboBox cmb)
                    {
                        cmb.BackColor = IsDark ? Color.FromArgb(38, 40, 45) : Color.White;
                        cmb.ForeColor = TextMain;
                    }
                    else if (c is DateTimePicker dtp)
                    {
                        dtp.CalendarMonthBackground = IsDark ? Color.FromArgb(32, 33, 37) : Color.White;
                        dtp.CalendarForeColor = TextMain;
                    }
                    else if (c is LinkLabel lnk)
                    {
                        lnk.BackColor = Background;
                        lnk.LinkColor = IsDark ? Color.FromArgb(170, 190, 255) : Color.Black;
                    }
                    else if (c is Label lbl)
                    {
                        lbl.BackColor = Background;
                        if (lbl.ForeColor == Color.Black || lbl.ForeColor == Color.FromArgb(240, 240, 245))
                            lbl.ForeColor = TextMain;
                        else if (lbl.ForeColor == Color.DimGray || lbl.ForeColor == Color.Gray || lbl.ForeColor == Color.FromArgb(70, 70, 70))
                            lbl.ForeColor = TextMuted;
                    }

                    if (c.HasChildren && c is not cuiTextBox && c is not DataGridView)
                    {
                        Recurse(c);
                    }
                }
            }

            Recurse(form);
            form.Invalidate(true);
        }

        private static void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var grid = (DataGridView)sender;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (col.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
                {
                    col.Visible = false;
                    continue;
                }

                string name = col.Name;
                if (name == "Адрес" || name == "Объект")
                {
                    col.FillWeight = 165;
                    col.MinimumWidth = 135;
                }
                else if (name == "Описание" || name == "Комментарий")
                {
                    col.FillWeight = 135;
                    col.MinimumWidth = 100;
                }
                else if (name == "ФИО" || name == "Клиент" || name == "Агент")
                {
                    col.FillWeight = 125;
                    col.MinimumWidth = 110;
                }
                else if (name == "Email")
                {
                    col.FillWeight = 125;
                    col.MinimumWidth = 110;
                }
                else if (name == "Телефон" || name == "Телефон клиента")
                {
                    col.FillWeight = 95;
                    col.MinimumWidth = 100;
                }
                else if (name == "Дата и время" || name == "Дата" || name == "Создан")
                {
                    col.FillWeight = 90;
                    col.MinimumWidth = 92;
                }
                else if (name == "Статус")
                {
                    col.FillWeight = 92;
                    col.MinimumWidth = 92;
                }
                else if (name == "Цена, ₽" || name == "Сумма, ₽")
                {
                    col.FillWeight = 88;
                    col.MinimumWidth = 85;
                }
                else if (name == "Площадь, м²" || name == "Объектов" || name == "Сделок" || name == "Всего сделок" || name == "Завершено" || name == "Отменено")
                {
                    col.FillWeight = 62;
                    col.MinimumWidth = 58;
                }
                else if (name == "Тип" || name == "Тип недвижимости" || name == "Роль" || name == "Логин")
                {
                    col.FillWeight = 82;
                    col.MinimumWidth = 72;
                }

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
