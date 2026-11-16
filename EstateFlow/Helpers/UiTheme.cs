using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using EstateFlow.Controls;
using HartUI.Controls;

namespace EstateFlow.Helpers
{
    public static class UiTheme
    {
        public static bool IsDark { get; private set; } = false;

        public static event Action ThemeChanged;

        public static Color Accent => IsDark ? Color.FromArgb(99, 102, 241) : Color.FromArgb(79, 70, 229);
        public static Color AccentHover => IsDark ? Color.FromArgb(129, 140, 248) : Color.FromArgb(67, 56, 202);
        public static Color AccentPressed => IsDark ? Color.FromArgb(79, 70, 229) : Color.FromArgb(55, 48, 163);

        public static Color Primary => Accent;
        public static Color Secondary => IsDark ? Color.FromArgb(148, 163, 184) : Color.FromArgb(71, 85, 105);
        public static Color Background => IsDark ? Color.FromArgb(15, 23, 42) : Color.FromArgb(248, 250, 252);
        public static Color CardBg => IsDark ? Color.FromArgb(30, 41, 59) : Color.White;
        public static Color Border => IsDark ? Color.FromArgb(51, 65, 85) : Color.FromArgb(226, 232, 240);
        public static Color DarkBorder => Accent;
        public static Color TextMain => IsDark ? Color.FromArgb(248, 250, 252) : Color.FromArgb(15, 23, 42);
        public static Color TextMuted => IsDark ? Color.FromArgb(148, 163, 184) : Color.FromArgb(100, 116, 139);
        public static Color ErrorText => IsDark ? Color.FromArgb(248, 113, 113) : Color.FromArgb(220, 38, 38);

        public static Color TextBoxBg => IsDark ? Color.FromArgb(30, 41, 59) : Color.FromArgb(241, 245, 249);
        public static Color TextBoxFocusBg => IsDark ? Color.FromArgb(15, 23, 42) : Color.White;
        public static Color TextBoxDisabledBg => IsDark ? Color.FromArgb(23, 32, 51) : Color.FromArgb(226, 232, 240);
        public static Color TextBoxOutline => IsDark ? Color.FromArgb(71, 85, 105) : Color.FromArgb(203, 213, 225);
        public static Color TextBoxFocusOutline => Accent;
        public static Color TextBoxPlaceholder => IsDark ? Color.FromArgb(100, 116, 139) : Color.FromArgb(148, 163, 184);

        private sealed class TextBoxState
        {
            public bool IsReadOnly;
            public bool MaskAttached;
            public bool InternalUpdate;
            public bool JustOpenedWithPlus;
            public string LastText = "";
        }

        private static readonly ConditionalWeakTable<cuiTextBox, TextBoxState> TextBoxStates = new();

        private static TextBoxState GetState(cuiTextBox tb) => TextBoxStates.GetOrCreateValue(tb);

        private static TextBox GetInnerTextBox(cuiTextBox tb) =>
            tb?.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "contentTextField")
            ?? tb?.Controls.OfType<TextBox>().FirstOrDefault(t => !t.ReadOnly);

        private static TextBox GetPlaceholderTextBox(cuiTextBox tb) =>
            tb?.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "placeholderTextField")
            ?? tb?.Controls.OfType<TextBox>().FirstOrDefault(t => t.ReadOnly);

        private static Color EnsureOpaque(Color c) => c.A == 255 ? c : Background;

        private static bool SameColor(Color a, Color b) => a.ToArgb() == b.ToArgb();

        public static void SetTextBoxReadOnly(cuiTextBox tb, bool readOnly)
        {
            if (tb == null) return;
            GetState(tb).IsReadOnly = readOnly;
            var inner = GetInnerTextBox(tb);
            if (inner != null)
            {
                inner.ReadOnly = readOnly;
                inner.TabStop = !readOnly;
                inner.Cursor = readOnly ? Cursors.Default : Cursors.IBeam;
            }
            tb.TabStop = !readOnly;
            tb.Cursor = readOnly ? Cursors.Default : Cursors.IBeam;
            StyleTextBox(tb, tb.Parent?.BackColor ?? Background);
        }

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

        public static Image LogoLight { get; private set; }
        public static Image LogoDark { get; private set; }

        public static Image CurrentLogo => IsDark ? (LogoDark ?? LogoLight) : (LogoLight ?? LogoDark);

        public const string AppName = "EstateFlow";

        static UiTheme()
        {
            LoadLogos();
        }

        private static void LoadLogos()
        {
            try
            {
                string[] searchDirs = new[]
                {
                    Path.Combine(AppContext.BaseDirectory, "Resources"),
                    Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Resources"),
                    Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "assets", "logos"),
                    Path.Combine(Directory.GetCurrentDirectory(), "Resources"),
                    Path.Combine(Directory.GetCurrentDirectory(), "assets", "logos"),
                    Path.Combine(Directory.GetCurrentDirectory(), "EstateFlow", "Resources")
                };

                foreach (var dir in searchDirs)
                {
                    try
                    {
                        if (!Directory.Exists(dir)) continue;

                        string light = Path.Combine(dir, "logo_light.png");
                        string dark = Path.Combine(dir, "logo_dark.png");

                        if (LogoLight == null && File.Exists(light))
                        {
                            byte[] bytes = File.ReadAllBytes(light);
                            using var ms = new MemoryStream(bytes);
                            LogoLight = new Bitmap(ms);
                        }
                        if (LogoDark == null && File.Exists(dark))
                        {
                            byte[] bytes = File.ReadAllBytes(dark);
                            using var ms = new MemoryStream(bytes);
                            LogoDark = new Bitmap(ms);
                        }

                        if (LogoLight != null && LogoDark != null) break;
                    }
                    catch { }
                }
            }
            catch { }
        }

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
            Color parentBg = EnsureOpaque(parent.BackColor);
            foreach (Control c in parent.Controls)
            {
                if (c is cuiTextBox tb)
                {
                    StyleTextBox(tb, parentBg, forceRounding: true);
                }
                if (c.HasChildren && c is not cuiTextBox)
                {
                    StyleTextBoxes(c);
                }
            }
        }

        private static void StyleTextBox(cuiTextBox tb, Color parentBg, bool forceRounding = false)
        {
            bool isLocked = !tb.Enabled || GetState(tb).IsReadOnly;
            Color normalBg = isLocked ? TextBoxDisabledBg : TextBoxBg;
            Color focusBg = isLocked ? TextBoxDisabledBg : TextBoxFocusBg;
            Color fore = isLocked ? TextMuted : TextMain;

            tb.UnderlinedStyle = false;
            tb.BackColor = EnsureOpaque(parentBg);
            // Важно: FocusBackgroundColor задаётся ДО BackgroundColor из-за особенности HartUI.cuiTextBox
            tb.FocusBackgroundColor = focusBg;
            tb.BackgroundColor = normalBg;
            tb.OutlineColor = TextBoxOutline;
            tb.FocusOutlineColor = isLocked ? TextBoxOutline : TextBoxFocusOutline;
            tb.PlaceholderColor = TextBoxPlaceholder;
            tb.ForeColor = fore;
            if (forceRounding)
                tb.Rounding = new Padding(12);

            Color innerBg = (tb.ContainsFocus && !isLocked) ? focusBg : normalBg;
            var inner = GetInnerTextBox(tb);
            if (inner != null)
            {
                inner.BackColor = innerBg;
                inner.ForeColor = fore;
            }
            var placeholder = GetPlaceholderTextBox(tb);
            if (placeholder != null)
            {
                placeholder.BackColor = innerBg;
                placeholder.ForeColor = TextBoxPlaceholder;
            }

            tb.Invalidate();
        }

        private static string DigitsOnly(string s) =>
            string.IsNullOrEmpty(s) ? "" : new string(s.Where(char.IsDigit).ToArray());

        private static int CountDigitsInRange(string text, int start, int endExclusive)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            int from = Math.Clamp(start, 0, text.Length);
            int to = Math.Clamp(endExclusive, from, text.Length);
            int count = 0;
            for (int i = from; i < to; i++)
            {
                if (char.IsDigit(text[i])) count++;
            }
            return count;
        }

        private static string GroupDigitsWithSpaces(string digits)
        {
            if (string.IsNullOrEmpty(digits)) return "";
            var chars = new List<char>(digits.Length + digits.Length / 3);
            int group = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (group == 3)
                {
                    chars.Add(' ');
                    group = 0;
                }
                chars.Add(digits[i]);
                group++;
            }
            chars.Reverse();
            return new string(chars.ToArray());
        }

        private static int CaretPosForDigitOffset(string formatted, int digitOffset, int startIndex = 0)
        {
            if (string.IsNullOrEmpty(formatted)) return 0;
            if (digitOffset <= 0) return Math.Min(startIndex, formatted.Length);
            int seen = 0;
            for (int i = startIndex; i < formatted.Length; i++)
            {
                if (char.IsDigit(formatted[i]))
                {
                    seen++;
                    if (seen == digitOffset)
                        return i + 1;
                }
            }
            return formatted.Length;
        }

        private static void SetMaskedText(cuiTextBox tb, TextBox inner, TextBoxState state, string formatted, int caretPos)
        {
            state.LastText = formatted;
            if (inner != null)
            {
                if (inner.Text != formatted)
                {
                    state.InternalUpdate = true;
                    try
                    {
                        inner.Text = formatted;
                    }
                    finally
                    {
                        state.InternalUpdate = false;
                    }
                }
                int pos = Math.Clamp(caretPos, 0, formatted.Length);
                inner.SelectionStart = pos;
                inner.SelectionLength = 0;
            }
            else if (tb.Content != formatted)
            {
                state.InternalUpdate = true;
                try
                {
                    tb.Content = formatted;
                }
                finally
                {
                    state.InternalUpdate = false;
                }
            }
        }

        // авторазбивка суммы по разрядам (7 800 000) + живая подсказка в миллионах с сохранением курсора
        public static void AttachPriceFormatter(cuiTextBox tb, Label hintLabel = null)
        {
            if (tb == null) return;
            var state = GetState(tb);
            if (state.MaskAttached) return;
            state.MaskAttached = true;

            var inner = GetInnerTextBox(tb);
            const int maxDigits = 12;

            void UpdateHint(string digits)
            {
                if (hintLabel == null) return;
                if (long.TryParse(digits, out long val) && val > 0)
                    hintLabel.Text = FormatPriceReadable(val);
                else
                    hintLabel.Text = "Например: 7 800 000 (= 7,8 млн ₽)";
            }

            void ApplyPrice(string digits, int caretDigits)
            {
                if (digits.Length > maxDigits) digits = digits.Substring(0, maxDigits);
                string formatted = GroupDigitsWithSpaces(digits);
                UpdateHint(digits);
                int pos = CaretPosForDigitOffset(formatted, caretDigits);
                SetMaskedText(tb, inner, state, formatted, pos);
            }

            string NormalizePastedPrice(string raw, out int leadingZerosRemoved)
            {
                leadingZerosRemoved = 0;
                if (string.IsNullOrWhiteSpace(raw)) return "";
                string trimmed = raw.Trim();
                // Если вставлено число с копейками (например 8900000.00 или 8 900 000,50), берём целую часть
                var decMatch = Regex.Match(trimmed, @"^([\d\s\u00A0]+)[.,]\d{1,2}\s*(?:₽|руб\.?)?$", RegexOptions.IgnoreCase);
                string source = decMatch.Success ? decMatch.Groups[1].Value : trimmed;
                string digits = DigitsOnly(source);
                if (digits.Length > 0)
                {
                    string stripped = digits.TrimStart('0');
                    leadingZerosRemoved = digits.Length - stripped.Length;
                    digits = stripped;
                }
                if (digits.Length > maxDigits) digits = digits.Substring(0, maxDigits);
                return digits;
            }

            if (inner != null)
            {
                inner.KeyDown += (s, e) =>
                {
                    if (inner.ReadOnly || !tb.Enabled) return;
                    if (e.Modifiers != Keys.None) return;

                    if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                    {
                        e.SuppressKeyPress = true;
                        string txt = inner.Text ?? "";
                        string digits = DigitsOnly(txt);
                        int selStart = inner.SelectionStart;
                        int selLen = inner.SelectionLength;

                        if (selLen > 0)
                        {
                            int dStart = CountDigitsInRange(txt, 0, selStart);
                            int dEnd = CountDigitsInRange(txt, 0, selStart + selLen);
                            string newDigits = digits.Remove(dStart, dEnd - dStart);
                            ApplyPrice(newDigits, dStart);
                        }
                        else if (e.KeyCode == Keys.Back)
                        {
                            int k = CountDigitsInRange(txt, 0, selStart);
                            if (k <= 0) return;
                            string newDigits = digits.Remove(k - 1, 1);
                            ApplyPrice(newDigits, k - 1);
                        }
                        else
                        {
                            int k = CountDigitsInRange(txt, 0, selStart);
                            if (k >= digits.Length) return;
                            string newDigits = digits.Remove(k, 1);
                            ApplyPrice(newDigits, k);
                        }
                    }
                };

                inner.KeyPress += (s, e) =>
                {
                    if (char.IsControl(e.KeyChar)) return;
                    if (inner.ReadOnly || !tb.Enabled) return;
                    e.Handled = true;
                    if (!char.IsDigit(e.KeyChar)) return;

                    string txt = inner.Text ?? "";
                    string digits = DigitsOnly(txt);
                    int selStart = inner.SelectionStart;
                    int selLen = inner.SelectionLength;
                    int dStart = CountDigitsInRange(txt, 0, selStart);
                    int dEnd = CountDigitsInRange(txt, 0, selStart + selLen);

                    if (digits.Length - (dEnd - dStart) >= maxDigits) return;
                    string newDigits = digits.Substring(0, dStart) + e.KeyChar + digits.Substring(dEnd);
                    ApplyPrice(newDigits, dStart + 1);
                };

                inner.Leave += (s, e) =>
                {
                    string digits = DigitsOnly(tb.Content);
                    string trimmed = digits.TrimStart('0');
                    if (digits != trimmed)
                        ApplyPrice(trimmed, trimmed.Length);
                };
            }

            tb.ContentChanged += (s, e) =>
            {
                if (state.InternalUpdate) return;
                string raw = tb.Content ?? "";
                int rawCaret = inner?.SelectionStart ?? raw.Length;
                int rawDigitsBeforeCaret = CountDigitsInRange(raw, 0, rawCaret);
                string digits = NormalizePastedPrice(raw, out int leadingRemoved);
                int targetDigits = Math.Clamp(rawDigitsBeforeCaret - leadingRemoved, 0, digits.Length);
                ApplyPrice(digits, targetDigits);
            };

            string initial = NormalizePastedPrice(tb.Content ?? "", out _);
            ApplyPrice(initial, initial.Length);
        }

        // маска целых чисел (этажи, год постройки) с сохранением курсора
        public static void AttachIntMask(cuiTextBox tb, int maxDigits = 9)
        {
            if (tb == null) return;
            var state = GetState(tb);
            if (state.MaskAttached) return;
            state.MaskAttached = true;

            int limit = Math.Max(1, maxDigits);
            var inner = GetInnerTextBox(tb);

            if (inner != null)
            {
                inner.KeyPress += (s, e) =>
                {
                    if (char.IsControl(e.KeyChar)) return;
                    if (inner.ReadOnly || !tb.Enabled) return;
                    e.Handled = true;
                    if (!char.IsDigit(e.KeyChar)) return;

                    string txt = inner.Text ?? "";
                    int selStart = inner.SelectionStart;
                    int selLen = inner.SelectionLength;
                    int dStart = CountDigitsInRange(txt, 0, selStart);
                    int dEnd = CountDigitsInRange(txt, 0, selStart + selLen);
                    string digits = DigitsOnly(txt);

                    if (digits.Length - (dEnd - dStart) >= limit) return;
                    string newDigits = digits.Substring(0, dStart) + e.KeyChar + digits.Substring(dEnd);
                    SetMaskedText(tb, inner, state, newDigits, dStart + 1);
                };
            }

            tb.ContentChanged += (s, e) =>
            {
                if (state.InternalUpdate) return;
                string raw = tb.Content ?? "";
                int rawCaret = inner?.SelectionStart ?? raw.Length;
                int k = CountDigitsInRange(raw, 0, rawCaret);
                string digits = DigitsOnly(raw);
                if (digits.Length > limit) digits = digits.Substring(0, limit);
                int pos = Math.Clamp(k, 0, digits.Length);
                if (raw != digits || (inner != null && inner.SelectionStart != pos))
                    SetMaskedText(tb, inner, state, digits, pos);
            };

            string init = DigitsOnly(tb.Content ?? "");
            if (init.Length > limit) init = init.Substring(0, limit);
            if ((tb.Content ?? "") != init)
                SetMaskedText(tb, inner, state, init, init.Length);
        }

        // маска десятичных чисел (площадь) с нормализацией разделителя к '.' и сохранением курсора
        public static void AttachDecimalMask(cuiTextBox tb, int maxIntegerDigits = 8, int maxDecimalDigits = 2)
        {
            if (tb == null) return;
            var state = GetState(tb);
            if (state.MaskAttached) return;
            state.MaskAttached = true;

            int maxInt = Math.Max(1, maxIntegerDigits);
            int maxDec = Math.Max(0, maxDecimalDigits);
            var inner = GetInnerTextBox(tb);

            string NormalizeDecimal(string raw, int rawCaret, bool prependZeroOnLeadingDot, out int newCaret)
            {
                newCaret = 0;
                if (string.IsNullOrEmpty(raw)) return "";

                int clampedCaret = Math.Clamp(rawCaret, 0, raw.Length);
                var sb = new System.Text.StringBuilder(raw.Length);
                bool hasDot = false;
                int intCount = 0;
                int decCount = 0;

                for (int i = 0; i < raw.Length; i++)
                {
                    if (i == clampedCaret)
                        newCaret = sb.Length;

                    char ch = raw[i];
                    if (char.IsDigit(ch))
                    {
                        if (!hasDot)
                        {
                            if (intCount < maxInt)
                            {
                                sb.Append(ch);
                                intCount++;
                            }
                        }
                        else if (decCount < maxDec)
                        {
                            sb.Append(ch);
                            decCount++;
                        }
                    }
                    else if ((ch == '.' || ch == ',') && !hasDot && maxDec > 0)
                    {
                        if (sb.Length == 0 && prependZeroOnLeadingDot)
                        {
                            sb.Append("0.");
                            intCount = 1;
                            if (i < clampedCaret) newCaret = sb.Length;
                        }
                        else
                        {
                            sb.Append('.');
                        }
                        hasDot = true;
                    }
                }

                if (clampedCaret >= raw.Length)
                    newCaret = sb.Length;

                return sb.ToString();
            }

            if (inner != null)
            {
                inner.KeyPress += (s, e) =>
                {
                    if (char.IsControl(e.KeyChar)) return;
                    if (inner.ReadOnly || !tb.Enabled) return;
                    e.Handled = true;

                    char ch = e.KeyChar;
                    if (ch == ',') ch = '.';
                    if (!char.IsDigit(ch) && (ch != '.' || maxDec == 0)) return;

                    string txt = inner.Text ?? "";
                    int selStart = inner.SelectionStart;
                    int selLen = inner.SelectionLength;
                    bool emptyOrAllSelected = string.IsNullOrEmpty(txt) || (selStart == 0 && selLen >= txt.Length);
                    string candidate = txt.Substring(0, selStart) + ch + txt.Substring(selStart + selLen);
                    string normalized = NormalizeDecimal(candidate, selStart + 1, emptyOrAllSelected, out int caret);
                    SetMaskedText(tb, inner, state, normalized, caret);
                };

                inner.Leave += (s, e) =>
                {
                    string txt = tb.Content ?? "";
                    if (string.IsNullOrEmpty(txt)) return;
                    if (txt.StartsWith(".")) txt = "0" + txt;
                    if (txt.EndsWith(".")) txt = txt.TrimEnd('.');
                    if (txt != (tb.Content ?? ""))
                        SetMaskedText(tb, inner, state, txt, txt.Length);
                };
            }

            tb.ContentChanged += (s, e) =>
            {
                if (state.InternalUpdate) return;
                string raw = tb.Content ?? "";
                int rawCaret = inner?.SelectionStart ?? raw.Length;
                string normalized = NormalizeDecimal(raw, rawCaret, false, out int caret);
                if (raw != normalized || (inner != null && inner.SelectionStart != caret))
                    SetMaskedText(tb, inner, state, normalized, caret);
            };

            string init = NormalizeDecimal(tb.Content ?? "", (tb.Content ?? "").Length, true, out int initCaret);
            if ((tb.Content ?? "") != init)
                SetMaskedText(tb, inner, state, init, initCaret);
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

        // маска телефона +7(XXX)XXX-XX-XX для cuiTextBox с сохранением курсора и корректным Backspace/Delete/Paste
        public static void AttachPhoneMask(cuiTextBox tb)
        {
            if (tb == null) return;
            var state = GetState(tb);
            if (state.MaskAttached) return;
            state.MaskAttached = true;

            var inner = GetInnerTextBox(tb);

            string FormatFromSubscriberDigits(string sub, bool showEmptyPrefix)
            {
                if (string.IsNullOrEmpty(sub))
                    return showEmptyPrefix ? "+7(" : "";
                if (sub.Length > 10) sub = sub.Substring(0, 10);

                var sb = new System.Text.StringBuilder(16);
                sb.Append("+7(");
                sb.Append(sub, 0, Math.Min(3, sub.Length));
                if (sub.Length > 3)
                {
                    sb.Append(')');
                    sb.Append(sub, 3, Math.Min(3, sub.Length - 3));
                }
                if (sub.Length > 6)
                {
                    sb.Append('-');
                    sb.Append(sub, 6, Math.Min(2, sub.Length - 6));
                }
                if (sub.Length > 8)
                {
                    sb.Append('-');
                    sb.Append(sub, 8, Math.Min(2, sub.Length - 8));
                }
                return sb.ToString();
            }

            int CountSubDigitsBefore(string text, int pos)
            {
                if (string.IsNullOrEmpty(text)) return 0;
                int start = text.StartsWith("+7(") ? 3 : text.StartsWith("+7") ? 2 : 0;
                return CountDigitsInRange(text, start, Math.Clamp(pos, 0, text.Length));
            }

            string ExtractSubFromFormatted(string text)
            {
                if (string.IsNullOrEmpty(text)) return "";
                string rawDigits = text.StartsWith("+7(")
                    ? DigitsOnly(text.Substring(3))
                    : text.StartsWith("+7")
                        ? DigitsOnly(text.Substring(2))
                        : DigitsOnly(text);
                return rawDigits.Length > 10 ? rawDigits.Substring(0, 10) : rawDigits;
            }

            int CaretForSubIndex(string formatted, int subOffset)
            {
                if (string.IsNullOrEmpty(formatted)) return 0;
                if (subOffset <= 0) return Math.Min(3, formatted.Length);
                return CaretPosForDigitOffset(formatted, subOffset, 3);
            }

            void ApplyPhone(string sub, int caretSubOffset, bool showEmptyPrefix = false, bool openedWithPlus = false)
            {
                state.JustOpenedWithPlus = openedWithPlus;
                string formatted = FormatFromSubscriberDigits(sub, showEmptyPrefix);
                int caretPos = string.IsNullOrEmpty(formatted) ? 0 : CaretForSubIndex(formatted, caretSubOffset);
                SetMaskedText(tb, inner, state, formatted, caretPos);
            }

            void NormalizeExternalPhone(string raw, int rawCaret, out string sub, out int caretSubOffset, out bool showEmptyPrefix)
            {
                sub = "";
                caretSubOffset = 0;
                showEmptyPrefix = false;
                if (string.IsNullOrEmpty(raw)) return;

                if (raw == "+7(")
                {
                    // Если до этого были цифры или префикс, а пользователь удалил до "+7(", очищаем поле для Placeholder
                    if (state.LastText.Length > 3)
                        return;
                    showEmptyPrefix = true;
                    return;
                }

                if (raw == "+" || raw == "+7")
                {
                    if (state.LastText == "+7(")
                        return;
                    if (raw == "+")
                        showEmptyPrefix = true;
                    return;
                }

                if (raw.StartsWith("+7("))
                {
                    string afterDigits = DigitsOnly(raw.Substring(3));
                    if (afterDigits.Length == 11 && (afterDigits[0] == '7' || afterDigits[0] == '8') && ExtractSubFromFormatted(state.LastText).Length == 0)
                    {
                        sub = afterDigits.Substring(1, 10);
                        caretSubOffset = sub.Length;
                        return;
                    }
                    if (afterDigits.Length == 0)
                    {
                        showEmptyPrefix = string.IsNullOrEmpty(state.LastText);
                        return;
                    }
                    sub = afterDigits.Length > 10 ? afterDigits.Substring(0, 10) : afterDigits;
                    caretSubOffset = Math.Min(sub.Length, CountDigitsInRange(raw, 3, Math.Max(3, rawCaret)));
                    return;
                }

                if (raw.StartsWith("+7"))
                {
                    string afterDigits = DigitsOnly(raw.Substring(2));
                    if (afterDigits.Length == 0) return;
                    sub = afterDigits.Length > 10 ? afterDigits.Substring(0, 10) : afterDigits;
                    caretSubOffset = Math.Min(sub.Length, CountDigitsInRange(raw, 2, Math.Max(2, rawCaret)));
                    return;
                }

                string allDigits = DigitsOnly(raw);
                if (raw.TrimStart().StartsWith("("))
                {
                    sub = allDigits.Length > 10 ? allDigits.Substring(0, 10) : allDigits;
                    caretSubOffset = Math.Min(sub.Length, CountDigitsInRange(raw, 0, rawCaret));
                    return;
                }

                if (allDigits.Length == 0) return;

                if (allDigits[0] == '7' || allDigits[0] == '8')
                {
                    if (allDigits.Length == 1)
                    {
                        showEmptyPrefix = true;
                        return;
                    }
                    sub = allDigits.Substring(1, Math.Min(10, allDigits.Length - 1));
                    caretSubOffset = Math.Min(sub.Length, Math.Max(0, CountDigitsInRange(raw, 0, rawCaret) - 1));
                }
                else
                {
                    sub = allDigits.Length > 10 ? allDigits.Substring(0, 10) : allDigits;
                    caretSubOffset = Math.Min(sub.Length, CountDigitsInRange(raw, 0, rawCaret));
                }
            }

            if (inner != null)
            {
                inner.KeyDown += (s, e) =>
                {
                    if (inner.ReadOnly || !tb.Enabled) return;
                    if (e.Modifiers != Keys.None) return;

                    if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                    {
                        e.SuppressKeyPress = true;
                        string txt = inner.Text ?? "";
                        string sub = ExtractSubFromFormatted(txt);
                        int selStart = inner.SelectionStart;
                        int selLen = inner.SelectionLength;

                        if (selLen > 0)
                        {
                            if (selStart == 0 && selLen >= txt.Length)
                            {
                                ApplyPhone("", 0);
                                return;
                            }
                            int kStart = CountSubDigitsBefore(txt, selStart);
                            int kEnd = CountSubDigitsBefore(txt, selStart + selLen);
                            string newSub = kEnd > kStart ? sub.Remove(kStart, kEnd - kStart) : sub;
                            ApplyPhone(newSub, kStart);
                            return;
                        }

                        if (sub.Length == 0)
                        {
                            ApplyPhone("", 0);
                            return;
                        }

                        int k = CountSubDigitsBefore(txt, selStart);
                        if (e.KeyCode == Keys.Back)
                        {
                            if (k <= 0) return;
                            string newSub = sub.Remove(k - 1, 1);
                            ApplyPhone(newSub, k - 1);
                        }
                        else
                        {
                            if (k >= sub.Length) return;
                            string newSub = sub.Remove(k, 1);
                            ApplyPhone(newSub, k);
                        }
                    }
                };

                inner.KeyPress += (s, e) =>
                {
                    if (char.IsControl(e.KeyChar)) return;
                    if (inner.ReadOnly || !tb.Enabled) return;
                    e.Handled = true;

                    string txt = inner.Text ?? "";
                    int selStart = inner.SelectionStart;
                    int selLen = inner.SelectionLength;
                    bool emptyOrAllSelected = string.IsNullOrEmpty(txt) || (selStart == 0 && selLen >= txt.Length);

                    if (e.KeyChar == '+')
                    {
                        if (emptyOrAllSelected)
                            ApplyPhone("", 0, showEmptyPrefix: true, openedWithPlus: true);
                        return;
                    }

                    if (!char.IsDigit(e.KeyChar)) return;

                    if (emptyOrAllSelected)
                    {
                        if (e.KeyChar == '7' || e.KeyChar == '8')
                            ApplyPhone("", 0, showEmptyPrefix: true);
                        else
                            ApplyPhone(e.KeyChar.ToString(), 1);
                        return;
                    }

                    if (txt == "+7(" && state.JustOpenedWithPlus && e.KeyChar == '7')
                    {
                        state.JustOpenedWithPlus = false;
                        inner.SelectionStart = 3;
                        inner.SelectionLength = 0;
                        return;
                    }

                    state.JustOpenedWithPlus = false;
                    string sub = ExtractSubFromFormatted(txt);
                    int kStart = CountSubDigitsBefore(txt, selStart);
                    int kEnd = CountSubDigitsBefore(txt, selStart + selLen);

                    if (sub.Length - (kEnd - kStart) >= 10) return;
                    string newSub = sub.Substring(0, kStart) + e.KeyChar + sub.Substring(kEnd);
                    ApplyPhone(newSub, kStart + 1);
                };

                inner.Leave += (s, e) =>
                {
                    if ((tb.Content ?? "") == "+7(")
                        ApplyPhone("", 0);
                };
            }

            tb.ContentChanged += (s, e) =>
            {
                if (state.InternalUpdate) return;
                string raw = tb.Content ?? "";
                int rawCaret = inner?.SelectionStart ?? raw.Length;
                NormalizeExternalPhone(raw, rawCaret, out string sub, out int caretSubOffset, out bool showEmptyPrefix);
                string expected = FormatFromSubscriberDigits(sub, showEmptyPrefix);
                int expectedCaret = string.IsNullOrEmpty(expected) ? 0 : CaretForSubIndex(expected, caretSubOffset);
                if (raw != expected || (inner != null && inner.SelectionStart != expectedCaret))
                    ApplyPhone(sub, caretSubOffset, showEmptyPrefix, openedWithPlus: raw == "+");
                else
                    state.LastText = expected;
            };

            string initialRaw = tb.Content ?? "";
            if (!string.IsNullOrEmpty(initialRaw))
            {
                NormalizeExternalPhone(initialRaw, initialRaw.Length, out string initSub, out int initCaret, out bool initPrefix);
                ApplyPhone(initSub, initCaret, initPrefix);
            }
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

            grid.ColumnHeadersDefaultCellStyle.BackColor = IsDark ? Color.FromArgb(30, 41, 59) : Color.FromArgb(30, 41, 59);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = IsDark ? Color.FromArgb(30, 41, 59) : Color.FromArgb(30, 41, 59);
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            grid.ColumnHeadersHeight = 36;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            grid.DefaultCellStyle.BackColor = CardBg;
            grid.DefaultCellStyle.ForeColor = TextMain;
            grid.DefaultCellStyle.SelectionBackColor = Accent;
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            grid.AlternatingRowsDefaultCellStyle.BackColor = IsDark ? Color.FromArgb(23, 32, 51) : Color.FromArgb(248, 250, 252);
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
                    e.CellStyle.ForeColor = IsDark ? Color.FromArgb(150, 154, 165) : Color.FromArgb(110, 110, 110);
                }
                else if (status == "Завершена" || status == "Подтверждена" || status == "Проведена")
                {
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
            }
        }

        private static bool IsErrorColor(Color c) =>
            SameColor(c, Color.DarkRed) || SameColor(c, Color.Red) || SameColor(c, Color.Crimson) ||
            SameColor(c, Color.FromArgb(185, 28, 28)) || SameColor(c, Color.FromArgb(255, 115, 115));

        private static bool IsMutedTextColor(Color c) =>
            SameColor(c, Color.DimGray) || SameColor(c, Color.Gray) ||
            SameColor(c, Color.FromArgb(70, 70, 70)) || SameColor(c, Color.FromArgb(50, 50, 50)) ||
            SameColor(c, Color.FromArgb(160, 162, 170)) || SameColor(c, Color.FromArgb(140, 142, 150));

        private static bool IsMainTextColor(Color c) =>
            SameColor(c, SystemColors.ControlText) || SameColor(c, Color.Black) ||
            SameColor(c, Color.White) || SameColor(c, Color.FromArgb(240, 240, 245));

        public static void ApplyTheme(Form form)
        {
            form.BackColor = Background;
            form.ForeColor = TextMain;

            void Recurse(Control parent, Color parentBg)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is cuiTextBox tb)
                    {
                        StyleTextBox(tb, parentBg);
                    }
                    else if (c is cuiButton btn)
                    {
                        if (btn.Name == "btnThemeToggle" || btn.Name.StartsWith("btnRoom") || btn.Name == "btnViewCards" || btn.Name == "btnViewTable") continue;
                        btn.BackColor = EnsureOpaque(parentBg);

                        string text = (btn.Content ?? "").ToLowerInvariant();
                        bool isSecondary = text.Contains("назад") || text.Contains("отмена") || text.Contains("сбросить") || text.Contains("удалить") || text.Contains("изменить");
                        bool isPrimaryAction = !isSecondary && (
                            SameColor(btn.NormalBackground, Color.Black) ||
                            SameColor(btn.NormalBackground, Color.FromArgb(240, 240, 245)) ||
                            SameColor(btn.NormalForeColor, Color.White) ||
                            text.Contains("войти") || text.Contains("регистрация") ||
                            text.Contains("сохранить") || text.Contains("добавить") || text.Contains("новая сделка"));

                        if (isPrimaryAction)
                        {
                            btn.NormalBackground = Accent;
                            btn.NormalForeColor = Color.White;
                            btn.NormalOutline = Accent;
                            btn.HoverBackground = AccentHover;
                            btn.HoverForeColor = Color.White;
                            btn.HoverOutline = AccentHover;
                            btn.PressedBackground = AccentPressed;
                            btn.PressedForeColor = Color.White;
                            btn.PressedOutline = AccentPressed;
                        }
                        else
                        {
                            btn.NormalBackground = CardBg;
                            btn.NormalForeColor = TextMain;
                            btn.NormalOutline = TextBoxOutline;
                            btn.HoverBackground = IsDark ? Color.FromArgb(51, 65, 85) : Color.FromArgb(241, 245, 249);
                            btn.HoverForeColor = TextMain;
                            btn.HoverOutline = Accent;
                            btn.PressedBackground = IsDark ? Color.FromArgb(71, 85, 105) : Color.FromArgb(226, 232, 240);
                            btn.PressedForeColor = TextMain;
                            btn.PressedOutline = Accent;
                        }
                        btn.ForeColor = btn.NormalForeColor;
                        btn.Invalidate();
                    }
                    else if (c is cuiCheckbox chk)
                    {
                        chk.BackColor = EnsureOpaque(parentBg);
                        chk.CheckedForeground = TextMain;
                        chk.CheckedOutlineColor = TextMain;
                        chk.CheckedSymbolColor = IsDark ? Color.Black : Color.White;
                        chk.UncheckedOutlineColor = TextMuted;
                        chk.ForeColor = TextMain;
                        chk.Invalidate();
                    }
                    else if (c is CheckBox cb)
                    {
                        cb.BackColor = EnsureOpaque(parentBg);
                        cb.ForeColor = TextMain;
                    }
                    else if (c is cuiLabel clbl)
                    {
                        clbl.BackColor = EnsureOpaque(parentBg);
                        if (IsErrorColor(clbl.ForeColor))
                            clbl.ForeColor = ErrorText;
                        else if (IsMutedTextColor(clbl.ForeColor))
                            clbl.ForeColor = TextMuted;
                        else
                            clbl.ForeColor = TextMain;
                        clbl.Invalidate();
                    }
                    else if (c is PictureBox pb && pb.Name == "picLogo")
                    {
                        pb.BackColor = Color.Transparent;
                        pb.Image = CurrentLogo;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Invalidate();
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
                        cmb.FlatStyle = FlatStyle.Flat;
                    }
                    else if (c is DateTimePicker dtp)
                    {
                        dtp.CalendarMonthBackground = IsDark ? Color.FromArgb(32, 33, 37) : Color.White;
                        dtp.CalendarTitleBackColor = IsDark ? Color.FromArgb(45, 47, 54) : Color.Black;
                        dtp.CalendarTitleForeColor = Color.White;
                        dtp.CalendarForeColor = TextMain;
                    }
                    else if (c is LinkLabel lnk)
                    {
                        lnk.BackColor = EnsureOpaque(parentBg);
                        lnk.LinkColor = IsDark ? Color.FromArgb(147, 197, 253) : Accent;
                        lnk.VisitedLinkColor = lnk.LinkColor;
                        lnk.ActiveLinkColor = IsDark ? Color.White : AccentHover;
                    }
                    else if (c is ListBox lst)
                    {
                        lst.BackColor = CardBg;
                        lst.ForeColor = TextMain;
                        lst.BorderStyle = BorderStyle.FixedSingle;
                    }
                    else if (c is RichTextBox rtb)
                    {
                        rtb.BackColor = CardBg;
                        rtb.ForeColor = TextMain;
                        rtb.BorderStyle = BorderStyle.FixedSingle;
                        if (rtb.TextLength > 0)
                        {
                            int selStart = rtb.SelectionStart;
                            int selLen = rtb.SelectionLength;
                            rtb.SelectAll();
                            rtb.SelectionColor = TextMain;
                            rtb.Select(selStart, selLen);
                        }
                    }
                    else if (c is TextBox txt)
                    {
                        txt.BackColor = CardBg;
                        txt.ForeColor = TextMain;
                    }
                    else if (c is PropertyCardControl card)
                    {
                        card.ApplyTheme();
                    }
                    else if (c is FlowLayoutPanel flp)
                    {
                        bool isCatalogSurface = flp.Name.Contains("Catalog", StringComparison.OrdinalIgnoreCase) || flp.AutoScroll;
                        flp.BackColor = isCatalogSurface
                            ? (IsDark ? Color.FromArgb(11, 17, 32) : Color.FromArgb(241, 245, 249))
                            : EnsureOpaque(parentBg);
                    }
                    else if (c is Panel pnl && pnl.Name != "pnlActions")
                    {
                        pnl.BackColor = EnsureOpaque(parentBg);
                    }
                    else if (c is Label lbl)
                    {
                        lbl.BackColor = EnsureOpaque(parentBg);
                        if (IsErrorColor(lbl.ForeColor))
                            lbl.ForeColor = ErrorText;
                        else if (IsMutedTextColor(lbl.ForeColor))
                            lbl.ForeColor = TextMuted;
                        else if (IsMainTextColor(lbl.ForeColor))
                            lbl.ForeColor = TextMain;
                    }

                    if (c.HasChildren && c is not cuiTextBox && c is not DataGridView && c is not PropertyCardControl)
                    {
                        Color childParentBg = (c is Panel || c is FlowLayoutPanel) ? EnsureOpaque(c.BackColor) : parentBg;
                        Recurse(c, childParentBg);
                    }
                }
            }

            Recurse(form, Background);
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
