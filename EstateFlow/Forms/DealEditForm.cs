using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class DealEditForm : BaseForm
    {
        private int dealId;
        private int initialPropertyId;

        public DealEditForm(int id = 0, int propId = 0)
        {
            dealId = id;
            initialPropertyId = propId;
            InitializeComponent();
            UiTheme.AttachPriceFormatter(txtAmount, lblAmountHint);
            dtpDate.Value = DateTime.Today;
            cmbStatus.SelectedIndex = 0;

            if (id > 0)
            {
                Text = "Редактирование сделки — EstateFlow";
                lblTitle.Text = "Редактирование сделки #" + id;
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
                Deal existingDeal = dealId > 0 ? DealService.GetById(dealId) : null;
                int? includePropId = existingDeal != null ? existingDeal.PropertyId : (initialPropertyId > 0 ? initialPropertyId : null);

                cmbProperty.Items.Clear();
                foreach (var p in PropertyService.GetLookup(excludeSold: dealId == 0, includePropertyId: includePropId))
                    cmbProperty.Items.Add(p);

                cmbClient.Items.Clear();
                foreach (var c in UserService.GetLookup(UserRole.Client)) cmbClient.Items.Add(c);

                cmbAgent.Items.Clear();
                foreach (var a in UserService.GetLookup(UserRole.Agent)) cmbAgent.Items.Add(a);

                if (existingDeal != null)
                {
                    UiTheme.SelectById(cmbProperty, existingDeal.PropertyId);
                    UiTheme.SelectById(cmbClient, existingDeal.ClientId);
                    UiTheme.SelectById(cmbAgent, existingDeal.AgentId);
                    dtpDate.Value = existingDeal.DealDate;
                    txtAmount.Content = ((long)existingDeal.Amount).ToString();
                    cmbStatus.SelectedItem = existingDeal.Status;
                }
                else
                {
                    if (initialPropertyId > 0)
                        UiTheme.SelectById(cmbProperty, initialPropertyId);
                    else if (cmbProperty.Items.Count > 0)
                        cmbProperty.SelectedIndex = 0;

                    if (Session.CurrentUser != null && Session.CurrentUser.IsAgent)
                        UiTheme.SelectById(cmbAgent, Session.CurrentUser.Id);
                    else if (cmbAgent.Items.Count > 0)
                        cmbAgent.SelectedIndex = 0;

                    if (cmbClient.Items.Count > 0) cmbClient.SelectedIndex = 0;
                }
            });
        }

        private void CmbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dealId == 0 && cmbProperty.SelectedItem is LookupItem item && item.Id > 0)
            {
                var p = PropertyService.GetById(item.Id);
                if (p != null)
                {
                    txtAmount.Content = ((long)p.Price).ToString();
                    if (p.AgentId.HasValue) UiTheme.SelectById(cmbAgent, p.AgentId.Value);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var propItem = cmbProperty.SelectedItem as LookupItem;
            if (propItem == null || propItem.Id == 0)
            {
                UiTheme.Warning("Выберите объект недвижимости.");
                cmbProperty.Focus();
                return;
            }

            var clientItem = cmbClient.SelectedItem as LookupItem;
            if (clientItem == null || clientItem.Id == 0)
            {
                UiTheme.Warning("Выберите клиента-покупателя.");
                cmbClient.Focus();
                return;
            }

            var agentItem = cmbAgent.SelectedItem as LookupItem;
            if (agentItem == null || agentItem.Id == 0)
            {
                UiTheme.Warning("Выберите ответственного агента.");
                cmbAgent.Focus();
                return;
            }

            string amountErr = Validator.PositiveDecimal(txtAmount.Content ?? "", "Сумма сделки", out decimal amount);
            if (amountErr != null)
            {
                UiTheme.Warning(amountErr);
                txtAmount.Focus();
                return;
            }

            string status = cmbStatus.SelectedItem?.ToString() ?? DealStatus.InProgress;

            if (status != DealStatus.Cancelled && DealService.HasActiveDeal(propItem.Id, dealId))
            {
                UiTheme.Warning("По данному объекту уже зарегистрирована активная или завершённая сделка.");
                return;
            }

            var deal = new Deal
            {
                Id = dealId,
                PropertyId = propItem.Id,
                ClientId = clientItem.Id,
                AgentId = agentItem.Id,
                DealDate = dtpDate.Value,
                Amount = amount,
                Status = status
            };

            if (UiTheme.Try(() => DealService.Save(deal)))
            {
                UiTheme.Info("Сделка сохранена.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
