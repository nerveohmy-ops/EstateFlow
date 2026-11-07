using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class ShowingEditForm : BaseForm
    {
        private int showingId;
        private int initialPropertyId;

        public ShowingEditForm(int id = 0, int propId = 0)
        {
            showingId = id;
            initialPropertyId = propId;
            InitializeComponent();
            dtpDate.Value = DateTime.Today.AddDays(1);
            cmbTime.SelectedItem = "14:00";
            if (cmbTime.SelectedIndex < 0 && cmbTime.Items.Count > 0)
                cmbTime.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

            if (id > 0)
            {
                Text = "Изменение заявки — EstateFlow";
                lblTitle.Text = "Редактирование заявки #" + id;
            }

            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadData()
        {
            UiTheme.Try(() =>
            {
                Showing existingShowing = showingId > 0 ? ShowingService.GetById(showingId) : null;
                int? includePropId = existingShowing != null ? existingShowing.PropertyId : (initialPropertyId > 0 ? initialPropertyId : null);

                cmbProperty.Items.Clear();
                foreach (var p in PropertyService.GetLookup(excludeSold: true, includePropertyId: includePropId))
                    cmbProperty.Items.Add(p);

                cmbClient.Items.Clear();
                foreach (var c in UserService.GetLookup(UserRole.Client)) cmbClient.Items.Add(c);

                cmbAgent.Items.Clear();
                cmbAgent.Items.Add(new LookupItem(0, "— Не назначен —"));
                foreach (var a in UserService.GetLookup(UserRole.Agent)) cmbAgent.Items.Add(a);

                if (existingShowing != null)
                {
                    UiTheme.SelectById(cmbProperty, existingShowing.PropertyId);
                    UiTheme.SelectById(cmbClient, existingShowing.ClientId);
                    if (existingShowing.AgentId.HasValue) UiTheme.SelectById(cmbAgent, existingShowing.AgentId.Value);
                    dtpDate.Value = existingShowing.ShowDate.Date;
                    string timeSlot = existingShowing.ShowDate.ToString("HH:mm");
                    if (!cmbTime.Items.Contains(timeSlot))
                        cmbTime.Items.Add(timeSlot);
                    cmbTime.SelectedItem = timeSlot;
                    cmbStatus.SelectedItem = existingShowing.Status;
                    txtComment.Content = existingShowing.Comment;
                }
                else
                {
                    if (initialPropertyId > 0)
                        UiTheme.SelectById(cmbProperty, initialPropertyId);
                    else if (cmbProperty.Items.Count > 0)
                        cmbProperty.SelectedIndex = 0;

                    if (Session.CurrentUser != null && Session.CurrentUser.IsClient)
                    {
                        UiTheme.SelectById(cmbClient, Session.CurrentUser.Id);
                        cmbClient.Enabled = false;
                        cmbStatus.Enabled = false;
                    }
                    else if (cmbClient.Items.Count > 0)
                    {
                        cmbClient.SelectedIndex = 0;
                    }

                    if (Session.CurrentUser != null && Session.CurrentUser.IsAgent)
                    {
                        UiTheme.SelectById(cmbAgent, Session.CurrentUser.Id);
                    }
                }
            });
        }

        private void CmbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showingId == 0 && cmbProperty.SelectedItem is LookupItem item && item.Id > 0)
            {
                var p = PropertyService.GetById(item.Id);
                if (p?.AgentId.HasValue == true)
                {
                    UiTheme.SelectById(cmbAgent, p.AgentId.Value);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var propItem = cmbProperty.SelectedItem as LookupItem;
            if (propItem == null || propItem.Id == 0)
            {
                UiTheme.Warning("Выберите объект недвижимости для показа.");
                cmbProperty.Focus();
                return;
            }

            int clientId = (Session.CurrentUser != null && Session.CurrentUser.IsClient)
                ? Session.CurrentUser.Id
                : ((cmbClient.SelectedItem as LookupItem)?.Id ?? 0);
            if (clientId == 0)
            {
                UiTheme.Warning("Выберите клиента.");
                cmbClient.Focus();
                return;
            }

            int? agentId = null;
            if (cmbAgent.SelectedItem is LookupItem aItem && aItem.Id > 0)
                agentId = aItem.Id;

            if (!TimeSpan.TryParse(cmbTime.SelectedItem?.ToString() ?? "14:00", out var timeOfDay))
                timeOfDay = new TimeSpan(14, 0, 0);

            var showing = new Showing
            {
                Id = showingId,
                PropertyId = propItem.Id,
                ClientId = clientId,
                AgentId = agentId,
                ShowDate = dtpDate.Value.Date.Add(timeOfDay),
                Status = cmbStatus.SelectedItem?.ToString() ?? ShowingStatus.New,
                Comment = (txtComment.Content ?? "").Trim()
            };

            if (UiTheme.Try(() => ShowingService.Save(showing)))
            {
                UiTheme.Info("Заявка на просмотр сохранена.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
