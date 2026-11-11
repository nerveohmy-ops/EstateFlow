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
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Cursor = Cursors.Hand;
            Padding = new Padding(8);

            // Фотография
            picPhoto = new PictureBox
            {
                Location = new Point(10, 10),
                Size = new Size(230, 155),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(240, 242, 245),
                Cursor = Cursors.Hand
            };
            picPhoto.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Бейдж статуса поверх фото
            lblStatusBadge = new Label
            {
                AutoSize = true,
                BackColor = Color.FromArgb(16, 185, 129),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold),
                Padding = new Padding(6, 3, 6, 3),
                Location = new Point(16, 16),
                Text = "Свободен"
            };
            lblStatusBadge.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Бейдж типа недвижимости внизу фото
            lblTypeBadge = new Label
            {
                AutoSize = true,
                BackColor = Color.FromArgb(180, 0, 0, 0),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 8F),
                Padding = new Padding(5, 2, 5, 2),
                Location = new Point(16, 136),
                Text = "Квартира"
            };
            lblTypeBadge.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Блок цен
            lblPrice = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Location = new Point(252, 10),
                Text = "8 900 000 ₽",
                Cursor = Cursors.Hand
            };
            lblPrice.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            lblPricePerMeter = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.Gray,
                Location = new Point(430, 17),
                Text = "152 397 ₽/м²",
                Cursor = Cursors.Hand
            };
            lblPricePerMeter.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Заголовок (например: 2-комн. квартира, 58.4 м², 5/9 эт.)
            lblTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold),
                Location = new Point(252, 40),
                Text = "2-комн. квартира, 58.4 м², 5/9 эт.",
                Cursor = Cursors.Hand
            };
            lblTitle.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Адрес
            lblAddress = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(70, 70, 70),
                Location = new Point(252, 66),
                Text = "📍 г. Благовещенск, р-н Центр, ул. Ленина, д. 148, кв. 24",
                Cursor = Cursors.Hand
            };
            lblAddress.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Характеристики (чипсы/теги)
            lblSpecs = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.DimGray,
                Location = new Point(252, 92),
                Text = "Кухня 11.2 м²  •  Жилая 34 м²  •  2018 г.  •  Агент: Петров П. П.",
                Cursor = Cursors.Hand
            };
            lblSpecs.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Описание (кратко)
            lblDescription = new Label
            {
                Location = new Point(252, 116),
                Size = new Size(470, 48),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.Gray,
                Text = "Светлая 2-комнатная квартира с качественным евроремонтом в самом сердце Благовещенска...",
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };
            lblDescription.Click += (s, e) => CardClicked?.Invoke(this, PropertyData);

            // Панель кнопок справа
            pnlActions = new Panel
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
                Location = new Point(735, 8),
                Size = new Size(175, 158),
                BackColor = Color.Transparent
            };

            btnPrimary = new cuiButton
            {
                Location = new Point(5, 10),
                Size = new Size(165, 38),
                Content = "На просмотр",
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                NormalBackground = Color.Black,
                NormalForeColor = Color.White,
                NormalOutline = Color.Black,
                HoverBackground = Color.FromArgb(40, 40, 40),
                HoverForeColor = Color.White,
                HoverOutline = Color.Black,
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
                Location = new Point(5, 54),
                Size = new Size(165, 36),
                Content = "Подробнее",
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Black,
                NormalBackground = Color.White,
                NormalForeColor = Color.Black,
                NormalOutline = Color.FromArgb(160, 160, 160),
                HoverBackground = Color.FromArgb(240, 240, 240),
                HoverForeColor = Color.Black,
                HoverOutline = Color.Black,
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
                Location = new Point(5, 96),
                Size = new Size(165, 36),
                Content = "Оформить сделку",
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.Black,
                NormalBackground = Color.White,
                NormalForeColor = Color.Black,
                NormalOutline = Color.FromArgb(160, 160, 160),
                HoverBackground = Color.FromArgb(240, 240, 240),
                HoverForeColor = Color.Black,
                HoverOutline = Color.Black,
                Rounding = new Padding(16),
                OutlineThickness = 1F,
                TextAlignment = StringAlignment.Center
            };
            btnDeal.Click += (s, e) => DealRequested?.Invoke(this, PropertyData);

            btnDelete = new Button
            {
                Location = new Point(140, 134),
                Size = new Size(30, 24),
                Text = "✕",
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                ForeColor = Color.DarkGray,
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            btnDelete.Click += (s, e) => DeleteRequested?.Invoke(this, PropertyData);

            pnlActions.Controls.Add(btnPrimary);
            pnlActions.Controls.Add(btnSecondary);
            pnlActions.Controls.Add(btnDeal);
            pnlActions.Controls.Add(btnDelete);

            Controls.Add(lblStatusBadge);
            Controls.Add(lblTypeBadge);
            Controls.Add(picPhoto);
            Controls.Add(lblPrice);
            Controls.Add(lblPricePerMeter);
            Controls.Add(lblTitle);
            Controls.Add(lblAddress);
            Controls.Add(lblSpecs);
            Controls.Add(lblDescription);
            Controls.Add(pnlActions);

            lblStatusBadge.BringToFront();
            lblTypeBadge.BringToFront();

            MouseEnter += (s, e) => SetHover(true);
            MouseLeave += (s, e) =>
            {
                if (!ClientRectangle.Contains(PointToClient(Cursor.Position)))
                    SetHover(false);
            };

            foreach (Control c in Controls)
            {
                if (c != pnlActions)
                {
                    c.MouseEnter += (s, e) => SetHover(true);
                    c.MouseLeave += (s, e) =>
                    {
                        if (!ClientRectangle.Contains(PointToClient(Cursor.Position)))
                            SetHover(false);
                    };
                }
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

            // Цена
            lblPrice.Text = $"{p.Price:N0} ₽".Replace('\u00A0', ' ');
            lblPrice.Location = new Point(252, 10);

            // Цена за метр
            decimal ppm = p.PricePerMeter;
            lblPricePerMeter.Text = ppm > 0 ? $"({ppm:N0} ₽/м²)" : "";
            lblPricePerMeter.Location = new Point(lblPrice.Right + 10, 16);

            // Заголовок
            lblTitle.Text = p.FullTitle;

            // Район и Адрес
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

            // Роли и доступность кнопок
            var user = Session.CurrentUser;
            bool isClient = user == null || user.IsClient;
            bool isAgent = user != null && user.IsAgent;
            bool isAdmin = user != null && user.IsAdmin;

            if (isClient)
            {
                btnPrimary.Content = "Записаться на просмотр";
                btnSecondary.Content = "Подробнее";
                btnDeal.Visible = false;
                btnDelete.Visible = false;
                btnPrimary.Location = new Point(5, 30);
                btnSecondary.Location = new Point(5, 78);
            }
            else
            {
                btnPrimary.Content = "Редактировать";
                btnSecondary.Content = "На просмотр";
                btnDeal.Visible = true;
                btnDeal.Content = "Сделка";
                btnDelete.Visible = isAdmin;

                btnPrimary.Location = new Point(5, 10);
                btnSecondary.Location = new Point(5, 54);
                btnDeal.Location = new Point(5, 96);
            }

            if (p.Status == PropertyStatus.Sold)
            {
                btnPrimary.Enabled = !isClient;
                btnSecondary.Enabled = false;
                btnDeal.Enabled = false;
            }
            else
            {
                btnPrimary.Enabled = true;
                btnSecondary.Enabled = true;
                btnDeal.Enabled = true;
            }

            ApplyTheme();
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

            // Кнопки
            if (isDark)
            {
                btnPrimary.NormalBackground = Color.FromArgb(240, 240, 245);
                btnPrimary.NormalForeColor = Color.Black;
                btnPrimary.NormalOutline = Color.White;
                btnPrimary.HoverBackground = Color.White;
                btnPrimary.HoverForeColor = Color.Black;

                btnSecondary.NormalBackground = Color.FromArgb(38, 40, 45);
                btnSecondary.NormalForeColor = Color.FromArgb(240, 240, 245);
                btnSecondary.NormalOutline = Color.FromArgb(85, 88, 98);
                btnSecondary.HoverBackground = Color.FromArgb(48, 50, 58);
                btnSecondary.HoverForeColor = Color.White;

                btnDeal.NormalBackground = Color.FromArgb(38, 40, 45);
                btnDeal.NormalForeColor = Color.FromArgb(240, 240, 245);
                btnDeal.NormalOutline = Color.FromArgb(85, 88, 98);
                btnDeal.HoverBackground = Color.FromArgb(48, 50, 58);
                btnDeal.HoverForeColor = Color.White;

                btnDelete.ForeColor = Color.FromArgb(180, 100, 100);
            }
            else
            {
                btnPrimary.NormalBackground = Color.Black;
                btnPrimary.NormalForeColor = Color.White;
                btnPrimary.NormalOutline = Color.Black;
                btnPrimary.HoverBackground = Color.FromArgb(40, 40, 40);
                btnPrimary.HoverForeColor = Color.White;

                btnSecondary.NormalBackground = Color.White;
                btnSecondary.NormalForeColor = Color.Black;
                btnSecondary.NormalOutline = Color.FromArgb(180, 180, 180);
                btnSecondary.HoverBackground = Color.FromArgb(242, 242, 242);
                btnSecondary.HoverForeColor = Color.Black;

                btnDeal.NormalBackground = Color.White;
                btnDeal.NormalForeColor = Color.Black;
                btnDeal.NormalOutline = Color.FromArgb(180, 180, 180);
                btnDeal.HoverBackground = Color.FromArgb(242, 242, 242);
                btnDeal.HoverForeColor = Color.Black;

                btnDelete.ForeColor = Color.FromArgb(160, 60, 60);
            }

            btnPrimary.Invalidate();
            btnSecondary.Invalidate();
            btnDeal.Invalidate();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

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
            if (pnlActions != null)
            {
                pnlActions.Location = new Point(Width - pnlActions.Width - 10, (Height - pnlActions.Height) / 2);
                lblDescription.Width = Math.Max(200, pnlActions.Left - lblDescription.Left - 20);
            }
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
