using EstateFlow.Helpers;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class MainForm : BaseForm
    {
        public bool LogoutRequested { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F1) btnGuide_Click(s, e);
            };

            if (Session.CurrentUser != null)
            {
                ConfigureByRole();
                LoadDashboard();
            }
        }

        private void ConfigureByRole()
        {
            lblUserGreeting.Text = $"{Session.CurrentUser.FullName} ({Session.CurrentUser.RoleName})";

            if (Session.CurrentUser.IsClient)
            {
                btnDeals.Content = "Мои сделки";
                btnShowings.Content = "Мои просмотры";
                btnUsers.Visible = false;
                btnTypes.Visible = false;
                btnReports.Visible = false;
                btnGuide.Location = new Point(232, 252);
                btnAbout.Size = new Size(250, 45);
                btnAbout.Location = new Point(502, 252);
                btnLogout.Size = new Size(250, 45);
                btnLogout.Location = new Point(232, 320);
                btnExit.Size = new Size(250, 45);
                btnExit.Location = new Point(502, 320);
            }
            else if (Session.CurrentUser.IsAgent)
            {
                btnUsers.Visible = false;
                btnTypes.Visible = false;
                btnReports.Location = new Point(232, 252);
                btnGuide.Location = new Point(502, 252);
            }
        }

        public void LoadDashboard()
        {
            if (Session.CurrentUser == null) return;
            UiTheme.Try(() =>
            {
                var (free, inWork, showings, sum) = ReportService.GetDashboard(Session.CurrentUser);
                string dealLabel = Session.CurrentUser.IsClient ? "Мои сделки" : "Сделки в работе";
                string sumLabel = Session.CurrentUser.IsClient ? "Покупки" : "Продажи";
                lblStats.Text = $"Свободно объектов: {free}   |   {dealLabel}: {inWork}   |   Просмотры: {showings}   |   {sumLabel}: {sum:N0} ₽";
            });
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            using var f = new PropertiesForm();
            f.ShowDialog(this);
            LoadDashboard();
        }

        private void btnDeals_Click(object sender, EventArgs e)
        {
            using var f = new DealsForm();
            f.ShowDialog(this);
            LoadDashboard();
        }

        private void btnShowings_Click(object sender, EventArgs e)
        {
            using var f = new ShowingsForm();
            f.ShowDialog(this);
            LoadDashboard();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            using var f = new UsersForm();
            f.ShowDialog(this);
            LoadDashboard();
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            using var f = new PropertyTypesForm();
            f.ShowDialog(this);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            using var f = new ReportsForm();
            f.ShowDialog(this);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            using var f = new ProfileForm();
            f.ShowDialog(this);
            lblUserGreeting.Text = $"{Session.CurrentUser.FullName} ({Session.CurrentUser.RoleName})";
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            using var f = new HelpForm();
            f.ShowDialog(this);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using var f = new AboutForm();
            f.ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (UiTheme.Confirm("Выйти из учётной записи?"))
            {
                LogoutRequested = true;
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (UiTheme.Confirm("Завершить работу с программой?"))
            {
                LogoutRequested = false;
                Close();
            }
        }
    }
}
