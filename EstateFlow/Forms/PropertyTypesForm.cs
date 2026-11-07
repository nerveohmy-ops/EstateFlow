using EstateFlow.Helpers;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class PropertyTypesForm : BaseForm
    {
        public PropertyTypesForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(grid);
            LoadData();
        }

        private void grid_DoubleClick(object sender, EventArgs e) => RenameSelected();
        private void btnAdd_Click(object sender, EventArgs e) => AddType();
        private void btnRename_Click(object sender, EventArgs e) => RenameSelected();
        private void btnDelete_Click(object sender, EventArgs e) => DeleteSelected();
        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void LoadData()
        {
            UiTheme.Try(() =>
            {
                var table = PropertyService.GetTypesTable();
                grid.DataSource = table;
                lblCount.Text = $"Всего категорий: {table.Rows.Count}";
            });
        }

        private void AddType()
        {
            string name = Prompt("Введите наименование нового типа недвижимости:", "Добавление типа");
            if (string.IsNullOrWhiteSpace(name)) return;

            if (PropertyService.TypeExists(name))
            {
                UiTheme.Warning("Такой тип недвижимости уже существует.");
                return;
            }

            if (UiTheme.Try(() => PropertyService.AddType(name)))
            {
                UiTheme.Info("Тип недвижимости добавлен.");
                LoadData();
            }
        }

        private void RenameSelected()
        {
            var id = UiTheme.SelectedId(grid);
            if (!id.HasValue)
            {
                UiTheme.Warning("Выберите тип недвижимости для редактирования.");
                return;
            }

            string currentName = grid.CurrentRow.Cells["Тип недвижимости"].Value?.ToString() ?? "";
            string newName = Prompt("Введите новое наименование:", "Переименование типа", currentName);
            if (string.IsNullOrWhiteSpace(newName) || newName == currentName) return;

            if (PropertyService.TypeExists(newName, id.Value))
            {
                UiTheme.Warning("Тип с таким названием уже существует.");
                return;
            }

            if (UiTheme.Try(() => PropertyService.RenameType(id.Value, newName)))
            {
                UiTheme.Info("Тип недвижимости переименован.");
                LoadData();
            }
        }

        private void DeleteSelected()
        {
            var id = UiTheme.SelectedId(grid);
            if (!id.HasValue)
            {
                UiTheme.Warning("Выберите тип недвижимости для удаления.");
                return;
            }

            if (UiTheme.Confirm("Удалить выбранную категорию недвижимости?"))
            {
                if (UiTheme.Try(() => PropertyService.DeleteType(id.Value)))
                {
                    UiTheme.Info("Категория удалена.");
                    LoadData();
                }
            }
        }

        private static string Prompt(string text, string caption, string def = "")
        {
            using var f = new Form
            {
                Text = caption,
                ClientSize = new Size(420, 160),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.White
            };

            var lbl = new Label { Text = text, Location = new Point(15, 15), Size = new Size(390, 20), Font = new Font("Segoe UI", 9.5F) };
            var tb = UiTheme.CreateTextBox("Наименование", 390);
            tb.Content = def;
            tb.Location = new Point(15, 42);

            var btnOk = UiTheme.CreateButton("ОК", true, 110, 38);
            btnOk.Location = new Point(180, 102);
            btnOk.Click += (s, e) => { f.DialogResult = DialogResult.OK; f.Close(); };

            var btnCancel = UiTheme.CreateButton("Отмена", false, 110, 38);
            btnCancel.Location = new Point(295, 102);
            btnCancel.Click += (s, e) => { f.DialogResult = DialogResult.Cancel; f.Close(); };

            f.Controls.AddRange(new Control[] { lbl, tb, btnOk, btnCancel });
            return f.ShowDialog() == DialogResult.OK ? (tb.Content ?? "").Trim() : null;
        }
    }
}
