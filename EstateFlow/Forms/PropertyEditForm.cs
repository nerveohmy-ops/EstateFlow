using EstateFlow.Helpers;
using EstateFlow.Models;
using EstateFlow.Services;

namespace EstateFlow.Forms
{
    public partial class PropertyEditForm : BaseForm
    {
        private int propertyId;

        public PropertyEditForm(int id = 0)
        {
            propertyId = id;
            InitializeComponent();
            UiTheme.AttachPriceFormatter(txtPrice, lblPriceHint);
            cmbStatus.SelectedIndex = 0;
            if (id > 0)
            {
                Text = "Редактирование объекта — EstateFlow";
                lblTitle.Text = "Редактирование объекта #" + id;
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
                cmbType.Items.Clear();
                foreach (var t in PropertyService.GetTypes()) cmbType.Items.Add(t);
                if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;

                cmbAgent.Items.Clear();
                cmbAgent.Items.Add(new LookupItem(0, "— Не назначен —"));
                foreach (var a in UserService.GetLookup(UserRole.Agent)) cmbAgent.Items.Add(a);
                cmbAgent.SelectedIndex = 0;

                if (propertyId > 0)
                {
                    var p = PropertyService.GetById(propertyId);
                    if (p != null)
                    {
                        Validator.SplitAddress(p.Address, out string city, out string street, out string house, out string apt);
                        txtCity.Content = city;
                        txtStreet.Content = street;
                        txtHouse.Content = house;
                        txtApartment.Content = apt;

                        UiTheme.SelectById(cmbType, p.TypeId);
                        cmbStatus.SelectedItem = p.Status;
                        txtArea.Content = p.Area.ToString("0.##");
                        txtPrice.Content = ((long)p.Price).ToString();
                        if (p.AgentId.HasValue) UiTheme.SelectById(cmbAgent, p.AgentId.Value);
                        txtDescription.Content = p.Description;
                    }
                }
                else if (Session.CurrentUser != null && Session.CurrentUser.IsAgent)
                {
                    UiTheme.SelectById(cmbAgent, Session.CurrentUser.Id);
                }
            });
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string addrErr = Validator.AddressParts(
                txtCity.Content, txtStreet.Content, txtHouse.Content, txtApartment.Content, out string addr);
            if (addrErr != null)
            {
                UiTheme.Warning(addrErr);
                return;
            }

            var typeItem = cmbType.SelectedItem as LookupItem;
            if (typeItem == null || typeItem.Id == 0)
            {
                UiTheme.Warning("Выберите тип недвижимости.");
                cmbType.Focus();
                return;
            }

            string areaErr = Validator.PositiveDecimal(txtArea.Content ?? "", "Площадь", out decimal area);
            if (areaErr != null)
            {
                UiTheme.Warning(areaErr);
                txtArea.Focus();
                return;
            }

            string priceErr = Validator.PositiveDecimal(txtPrice.Content ?? "", "Стоимость", out decimal price);
            if (priceErr != null)
            {
                UiTheme.Warning(priceErr);
                txtPrice.Focus();
                return;
            }

            int? agentId = null;
            if (cmbAgent.SelectedItem is LookupItem aItem && aItem.Id > 0)
                agentId = aItem.Id;

            var prop = new Property
            {
                Id = propertyId,
                Address = addr,
                TypeId = typeItem.Id,
                Area = area,
                Price = price,
                Status = cmbStatus.SelectedItem?.ToString() ?? PropertyStatus.Free,
                AgentId = agentId,
                Description = (txtDescription.Content ?? "").Trim()
            };

            if (UiTheme.Try(() => PropertyService.Save(prop)))
            {
                UiTheme.Info("Данные объекта сохранены.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
