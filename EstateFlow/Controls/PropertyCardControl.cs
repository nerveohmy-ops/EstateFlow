using System.Drawing.Drawing2D;
using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;
using HartUI.Controls;

namespace EstateFlow.Controls
{
    public class PropertyCardControl : UserControl
    {
        public Property PropertyData { get; private set; }

        public event EventHandler<Property> CardClicked;
        public event EventHandler<Property> ShowingRequested;
        public event EventHandler<Property> EditRequested;
        public event EventHandler<Property> DealRequested;
        public event EventHandler<Property> DeleteRequested;

        private PictureBox picPhoto;
        private Label lblStatusBadge;
        private Label lblTypeBadge;
        private Label lblPrice;
        private Label lblPricePerMeter;
        private Label lblTitle;
        private Label lblAddress;
        private Label lblSpecs;
        private Label lblDescription;
        private Panel pnlActions;
        private cuiButton btnPrimary;
        private cuiButton btnSecondary;
        private cuiButton btnDeal;
        private Button btnDelete;
        private readonly ToolTip toolTip = new();

        private bool isHovered = false;

        public PropertyCardControl()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            InitializeCardComponents();
            ApplyTheme();
        }

        private void InitializeCardComponents()
        {
            Height = 175;
            Width = 920;
            Anchor = AnchorStyles.None;
            Cursor = Cursors.Hand;
            Padding = new Padding(8);

            // Фотография
            picPhoto = new PictureBox
            {
                Location = new Point(10, 10),
                Size = new Size(240, 155),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(240, 242, 245),
                Cursor = Cursors.Hand
            };
            picPhoto.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Бейдж статуса внутри фото
            lblStatusBadge = new Label
            {
                AutoSize = true,
                BackColor = Color.FromArgb(16, 185, 129),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold),
                Padding = new Padding(6, 3, 6, 3),
                Location = new Point(8, 8),
                Text = "Свободен",
                Cursor = Cursors.Hand
            };
            lblStatusBadge.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);
            picPhoto.Controls.Add(lblStatusBadge);

            // Бейдж типа недвижимости внутри фото
            lblTypeBadge = new Label
            {
                AutoSize = true,
                BackColor = Color.FromArgb(30, 32, 38),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 8F),
                Padding = new Padding(5, 2, 5, 2),
                Location = new Point(8, 128),
                Text = "Квартира",
                Cursor = Cursors.Hand
            };
            lblTypeBadge.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);
            picPhoto.Controls.Add(lblTypeBadge);

            // Блок цены
            lblPrice = new Label
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Location = new Point(262, 10),
                Text = "8 900 000 ₽",
                Cursor = Cursors.Hand
            };
            lblPrice.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);
            lblPrice.SizeChanged += (s, e) => UpdateContentLayout();

            lblPricePerMeter = new Label
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.Gray,
                Location = new Point(440, 16),
                Text = "152 397 ₽/м²",
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };
            lblPricePerMeter.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Заголовок объекта
            lblTitle = new Label
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold),
                Location = new Point(262, 40),
                Size = new Size(440, 25),
                Text = "2-комн. квартира, 58.4 м², 5/9 эт.",
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };
            lblTitle.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Адрес
            lblAddress = new Label
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(70, 70, 70),
                Location = new Point(262, 66),
                Size = new Size(440, 21),
                Text = "📍 г. Благовещенск, р-н Центр, ул. Ленина, д. 148, кв. 24",
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };
            lblAddress.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Спецификации
            lblSpecs = new Label
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.DimGray,
                Location = new Point(262, 90),
                Size = new Size(440, 20),
                Text = "Кухня 11.2 м²  •  Жилая 34 м²  •  2018 г.  •  Агент: Петров П. П.",
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };
            lblSpecs.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Краткое описание
            lblDescription = new Label
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                Location = new Point(262, 114),
                Size = new Size(440, 50),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.Gray,
                Text = "Светлая квартира с ремонтом...",
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };
            lblDescription.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Кнопка быстрого удаления в правом верхнем углу (для админов)
            btnDelete = new Button
            {
                Location = new Point(Width - 34, 8),
                Size = new Size(24, 24),
                Text = "✕",
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                ForeColor = Color.Gray,
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                TabStop = false,
                Visible = false
            };
            btnDelete.Click += (s, e) => DeleteRequested?.Invoke(this, PropertyData);
            toolTip.SetToolTip(btnDelete, "Удалить объект");

            // Панель действий справа
            pnlActions = new Panel
            {
                Location = new Point(Width - 210, 34),
                Size = new Size(196, 130),
                BackColor = Color.Transparent
            };

            btnPrimary = new cuiButton
            {
                Location = new Point(5, 2),
                Size = new Size(186, 36),
                Content = "На просмотр",
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                NormalBackground = Color.Black,
                NormalForeColor = Color.White,
                NormalOutline = Color.Black,
                HoverBackground = Color.FromArgb(40, 40, 40),
                HoverForeColor = Color.White,
                HoverOutline = Color.Black,
                PressedBackground = Color.FromArgb(60, 60, 60),
                PressedForeColor = Color.White,
                PressedOutline = Color.Black,
                Rounding = new Padding(16),
                OutlineThickness = 1F,
                TextAlignment = StringAlignment.Center
            };
            btnPrimary.Click += (s, e) =>
            {
                if (Session.CurrentUser != null && Session.CurrentUser.IsClient)
                    ShowingRequested?.Invoke(this, PropertyData);
                else
                    EditRequested?.Invoke(this, PropertyData);
            };

            btnSecondary = new cuiButton
            {
                Location = new Point(5, 44),
                Size = new Size(186, 34),
                Content = "Подробнее",
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                NormalBackground = Color.White,
                NormalForeColor = Color.Black,
                NormalOutline = Color.FromArgb(160, 160, 160),
                HoverBackground = Color.FromArgb(240, 240, 240),
                HoverForeColor = Color.Black,
                HoverOutline = Color.Black,
                PressedBackground = Color.FromArgb(228, 228, 228),
                PressedForeColor = Color.Black,
                PressedOutline = Color.Black,
                Rounding = new Padding(16),
                OutlineThickness = 1F,
                TextAlignment = StringAlignment.Center
            };
            btnSecondary.Click += (s, e) =>
            {
                if (Session.CurrentUser != null && Session.CurrentUser.IsClient)
                    CardClicked?.Invoke(this, PropertyData);
                else
                    ShowingRequested?.Invoke(this, PropertyData);
            };

            btnDeal = new cuiButton
            {
                Location = new Point(5, 84),
                Size = new Size(186, 34),
                Content = "Оформить сделку",
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                NormalBackground = Color.White,
                NormalForeColor = Color.Black,
                NormalOutline = Color.FromArgb(160, 160, 160),
                HoverBackground = Color.FromArgb(240, 240, 240),
                HoverForeColor = Color.Black,
                HoverOutline = Color.Black,
                PressedBackground = Color.FromArgb(228, 228, 228),
                PressedForeColor = Color.Black,
                PressedOutline = Color.Black,
                Rounding = new Padding(16),
                OutlineThickness = 1F,
                TextAlignment = StringAlignment.Center
            };
            btnDeal.Click += (s, e) => DealRequested?.Invoke(this, PropertyData);

            pnlActions.Controls.Add(btnPrimary);
            pnlActions.Controls.Add(btnSecondary);
            pnlActions.Controls.Add(btnDeal);

            Controls.Add(picPhoto);
            Controls.Add(lblPrice);
            Controls.Add(lblPricePerMeter);
            Controls.Add(lblTitle);
            Controls.Add(lblAddress);
            Controls.Add(lblSpecs);
            Controls.Add(lblDescription);
            Controls.Add(pnlActions);
            Controls.Add(btnDelete);

            // Поддержка прокрутки колесиком мыши и hover над любым элементом карточки
            Click += (s, e) => CardClicked?.Invoke(this, PropertyData);
            WireMouseEvents(this);
            UpdateContentLayout();
        }

        private void WireMouseEvents(Control parent)
        {
            parent.MouseWheel += (s, e) => BubbleMouseWheel(e);
            parent.MouseEnter += (s, e) => SetHover(true);
            parent.MouseLeave += (s, e) =>
            {
                if (!ClientRectangle.Contains(PointToClient(Cursor.Position)))
                    SetHover(false);
            };
            foreach (Control child in parent.Controls)
            {
                WireMouseEvents(child);
            }
        }

        private void BubbleMouseWheel(MouseEventArgs e)
        {
            if (Parent is FlowLayoutPanel flp)
            {
                // Прокручиваем родительский FlowLayoutPanel
                int delta = e.Delta;
                var cur = flp.AutoScrollPosition;
                flp.AutoScrollPosition = new Point(-cur.X, -cur.Y - delta);
            }
        }

        private void SetHover(bool hover)
        {
            if (isHovered == hover) return;
            isHovered = hover;
            Invalidate();
        }

        public void Bind(Property p)
        {
            PropertyData = p;
            if (p == null) return;

            // Фото
            picPhoto.Image = PropertyImageHelper.GetImage(p.Photo);

            // Статус
            string st = p.Status ?? PropertyStatus.Free;
            lblStatusBadge.Text = st;
            if (st == PropertyStatus.Free)
            {
                lblStatusBadge.BackColor = Color.FromArgb(16, 185, 129); // emerald
                lblStatusBadge.ForeColor = Color.White;
            }
            else if (st == PropertyStatus.Reserved)
            {
                lblStatusBadge.BackColor = Color.FromArgb(245, 158, 11); // amber
                lblStatusBadge.ForeColor = Color.Black;
            }
            else
            {
                lblStatusBadge.BackColor = Color.FromArgb(107, 114, 128); // gray
                lblStatusBadge.ForeColor = Color.White;
            }

            // Тип недвижимости
            lblTypeBadge.Text = string.IsNullOrWhiteSpace(p.TypeName) ? "Объект" : p.TypeName;
            lblTypeBadge.Location = new Point(8, picPhoto.Height - Math.Max(lblTypeBadge.Height, lblTypeBadge.PreferredHeight) - 8);

            // Цена
            lblPrice.Text = $"{p.Price:N0} ₽".Replace('\u00A0', ' ');

            // Цена за квадратный метр
            decimal ppm = p.PricePerMeter;
            lblPricePerMeter.Text = ppm > 0 ? $"({ppm:N0} ₽/м²)" : "";

            // Заголовок
            lblTitle.Text = p.FullTitle;

            // Район и адрес
            string dist = string.IsNullOrWhiteSpace(p.District) ? "" : $"р-н {p.District}, ";
            lblAddress.Text = $"📍 {dist}{p.Address}";

            // Спецификации
            var specs = new List<string>();
            if (p.Rooms > 0) specs.Add($"{p.RoomsDisplay}");
            else if (p.Rooms == 0) specs.Add("Студия");

            if (!string.IsNullOrEmpty(p.FloorDisplay)) specs.Add(p.FloorDisplay);
            if (p.Area > 0) specs.Add($"{p.Area:0.##} м²");
            if (p.KitchenArea.HasValue && p.KitchenArea.Value > 0) specs.Add($"кухня {p.KitchenArea.Value:0.#} м²");
            if (p.LivingArea.HasValue && p.LivingArea.Value > 0) specs.Add($"жилая {p.LivingArea.Value:0.#} м²");
            if (p.YearBuilt.HasValue && p.YearBuilt.Value > 0) specs.Add($"{p.YearBuilt.Value} г.");
            if (!string.IsNullOrWhiteSpace(p.AgentName)) specs.Add($"Агент: {p.AgentName}");

            lblSpecs.Text = string.Join("  •  ", specs);

            // Описание
            lblDescription.Text = string.IsNullOrWhiteSpace(p.Description)
                ? "Уютный объект недвижимости в г. Благовещенск. Отличное предложение по соотношению цена-качество."
                : p.Description.Trim();

            // Роли
            var user = Session.CurrentUser;
            bool isClient = user == null || user.IsClient;
            bool isAdmin = user != null && user.IsAdmin;

            btnDelete.Visible = isAdmin;

            if (isClient)
            {
                btnPrimary.Content = "Записаться на просмотр";
                btnSecondary.Content = "Подробнее";
                btnDeal.Visible = false;

                btnPrimary.Location = new Point(5, 16);
                btnSecondary.Location = new Point(5, 62);
            }
            else
            {
                btnPrimary.Content = "Редактировать";
                btnSecondary.Content = "На просмотр";
                btnDeal.Visible = true;
                btnDeal.Content = "Сделка";

                btnPrimary.Location = new Point(5, 2);
                btnSecondary.Location = new Point(5, 44);
                btnDeal.Location = new Point(5, 84);
            }

            if (p.Status == PropertyStatus.Sold)
            {
                btnPrimary.Enabled = !isClient;
                btnSecondary.Enabled = isClient;
                btnDeal.Enabled = false;
            }
            else
            {
                btnPrimary.Enabled = true;
                btnSecondary.Enabled = true;
                btnDeal.Enabled = true;
            }

            UpdateContentLayout();
            ApplyTheme();
        }

        private static void StyleCardButton(cuiButton btn, bool isPrimary, bool isDark)
        {
            btn.BackColor = Color.Transparent;

            if (!btn.Enabled)
            {
                btn.NormalBackground = isDark ? Color.FromArgb(40, 42, 48) : Color.FromArgb(242, 243, 246);
                btn.NormalForeColor = isDark ? Color.FromArgb(115, 118, 128) : Color.FromArgb(160, 164, 172);
                btn.NormalOutline = isDark ? Color.FromArgb(62, 65, 74) : Color.FromArgb(215, 218, 224);
                btn.HoverBackground = btn.NormalBackground;
                btn.HoverForeColor = btn.NormalForeColor;
                btn.HoverOutline = btn.NormalOutline;
                btn.PressedBackground = btn.NormalBackground;
                btn.PressedForeColor = btn.NormalForeColor;
                btn.PressedOutline = btn.NormalOutline;
                btn.Invalidate();
                return;
            }

            if (isPrimary)
            {
                if (isDark)
                {
                    btn.NormalBackground = Color.FromArgb(240, 240, 245);
                    btn.NormalForeColor = Color.Black;
                    btn.NormalOutline = Color.White;
                    btn.HoverBackground = Color.White;
                    btn.HoverForeColor = Color.Black;
                    btn.HoverOutline = Color.White;
                    btn.PressedBackground = Color.FromArgb(210, 210, 218);
                    btn.PressedForeColor = Color.Black;
                    btn.PressedOutline = Color.White;
                }
                else
                {
                    btn.NormalBackground = Color.Black;
                    btn.NormalForeColor = Color.White;
                    btn.NormalOutline = Color.Black;
                    btn.HoverBackground = Color.FromArgb(40, 40, 40);
                    btn.HoverForeColor = Color.White;
                    btn.HoverOutline = Color.Black;
                    btn.PressedBackground = Color.FromArgb(65, 65, 65);
                    btn.PressedForeColor = Color.White;
                    btn.PressedOutline = Color.Black;
                }
            }
            else
            {
                if (isDark)
                {
                    btn.NormalBackground = Color.FromArgb(38, 40, 45);
                    btn.NormalForeColor = Color.FromArgb(240, 240, 245);
                    btn.NormalOutline = Color.FromArgb(85, 88, 98);
                    btn.HoverBackground = Color.FromArgb(50, 53, 60);
                    btn.HoverForeColor = Color.White;
                    btn.HoverOutline = Color.FromArgb(160, 164, 175);
                    btn.PressedBackground = Color.FromArgb(62, 65, 74);
                    btn.PressedForeColor = Color.White;
                    btn.PressedOutline = Color.White;
                }
                else
                {
                    btn.NormalBackground = Color.White;
                    btn.NormalForeColor = Color.Black;
                    btn.NormalOutline = Color.FromArgb(180, 180, 180);
                    btn.HoverBackground = Color.FromArgb(242, 242, 242);
                    btn.HoverForeColor = Color.Black;
                    btn.HoverOutline = Color.Black;
                    btn.PressedBackground = Color.FromArgb(228, 228, 228);
                    btn.PressedForeColor = Color.Black;
                    btn.PressedOutline = Color.Black;
                }
            }

            btn.Invalidate();
        }

        public void ApplyTheme()
        {
            bool isDark = UiTheme.IsDark;

            BackColor = isDark ? Color.FromArgb(30, 31, 35) : Color.White;
            lblPrice.ForeColor = UiTheme.TextMain;
            lblPricePerMeter.ForeColor = UiTheme.TextMuted;
            lblTitle.ForeColor = UiTheme.TextMain;
            lblAddress.ForeColor = isDark ? Color.FromArgb(180, 200, 240) : Color.FromArgb(40, 50, 70);
            lblSpecs.ForeColor = UiTheme.TextMuted;
            lblDescription.ForeColor = isDark ? Color.FromArgb(160, 162, 170) : Color.FromArgb(100, 105, 115);
            picPhoto.BackColor = isDark ? Color.FromArgb(20, 21, 24) : Color.FromArgb(240, 242, 245);

            StyleCardButton(btnPrimary, true, isDark);
            StyleCardButton(btnSecondary, false, isDark);
            StyleCardButton(btnDeal, false, isDark);

            if (isDark)
            {
                btnDelete.ForeColor = Color.FromArgb(220, 120, 120);
                btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 36, 40);
                btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 42, 46);
            }
            else
            {
                btnDelete.ForeColor = Color.FromArgb(170, 60, 60);
                btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 235, 235);
                btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 215, 215);
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color parentBg = Parent?.BackColor ?? (UiTheme.IsDark ? Color.FromArgb(20, 21, 24) : Color.FromArgb(246, 248, 250));
            g.Clear(parentBg);

            var rect = new Rectangle(1, 1, Width - 3, Height - 3);

            // Фон карточки
            Color bg = UiTheme.IsDark
                ? (isHovered ? Color.FromArgb(36, 38, 43) : Color.FromArgb(30, 31, 35))
                : (isHovered ? Color.FromArgb(250, 252, 255) : Color.White);

            using (var brush = new SolidBrush(bg))
            {
                using var path = CreateRoundedRectangle(rect, 12);
                g.FillPath(brush, path);

                // Бордер карточки
                Color border = isHovered
                    ? (UiTheme.IsDark ? Color.FromArgb(120, 130, 150) : Color.FromArgb(60, 100, 200))
                    : (UiTheme.IsDark ? Color.FromArgb(55, 58, 66) : Color.FromArgb(220, 224, 232));

                using var pen = new Pen(border, isHovered ? 1.5F : 1F);
                g.DrawPath(pen, path);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateContentLayout();
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            UpdateContentLayout();
        }

        private void UpdateContentLayout()
        {
            if (pnlActions == null || lblPrice == null) return;

            pnlActions.Location = new Point(Width - pnlActions.Width - 14, 34);
            if (btnDelete != null)
                btnDelete.Location = new Point(Width - 34, 8);

            const int textLeft = 262;
            int actionsLeft = pnlActions.Left;
            int maxPriceRight = (btnDelete != null && btnDelete.Visible ? Math.Min(actionsLeft, btnDelete.Left) : actionsLeft) - 14;
            int textWidth = Math.Max(180, actionsLeft - textLeft - 14);

            lblPrice.Location = new Point(textLeft, 10);
            int priceWidth = Math.Max(lblPrice.Width, lblPrice.PreferredWidth);
            int ppmLeft = textLeft + priceWidth + 12;
            lblPricePerMeter.Location = new Point(ppmLeft, 16);

            int ppmAvail = Math.Max(0, maxPriceRight - ppmLeft);
            lblPricePerMeter.MaximumSize = new Size(Math.Max(1, ppmAvail), 22);
            lblPricePerMeter.Visible = !string.IsNullOrEmpty(lblPricePerMeter.Text) && ppmAvail >= 65;

            lblTitle.SetBounds(textLeft, 40, textWidth, 25);
            lblAddress.SetBounds(textLeft, 66, textWidth, 21);
            lblSpecs.SetBounds(textLeft, 90, textWidth, 20);
            lblDescription.SetBounds(textLeft, 114, textWidth, 50);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                toolTip.Dispose();
            base.Dispose(disposing);
        }

        private static GraphicsPath CreateRoundedRectangle(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
