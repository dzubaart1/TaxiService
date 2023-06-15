using TaxiBusiness.Services;
using TaxiData.Models;

namespace TaxiClient
{
    public partial class ShiftForm : Form
    {
        private AdminForm _adminForm;
        private List<Driver> driverList = new List<Driver>();
        public ShiftForm(AdminForm adminForm)
        {
            InitializeComponent();
            _adminForm = adminForm;

            UpdateDispatcherComboBox();
            UpdateDriversListView();
        }

        private void ShiftForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _adminForm.Show();
        }

        private void UpdateDriversListView()
        {
            foreach (var driver in MainService.GetDriverService().Drivers)
            {
                ListViewItem item = new ListViewItem(driver.RegistrationCard.Id.ToString());
                item.SubItems.Add(driver.RegistrationCard.Name);
                DriversListView.Items.Add(item);
            }
        }

        private void UpdateDispatcherComboBox()
        {
            foreach (var user in MainService.GetUserService().Users)
            {
                if (user.UserType == TaxiData.Models.UserType.Dispatcher)
                {
                    DispatcherComboBox.Items.Add(user.Login);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MainService.GetShiftService().ClearShift();
            var dispatcher = MainService.GetUserService().FindUser(DispatcherComboBox.Text);
            foreach (ListViewItem driver in DriversListView.SelectedItems)
            {
                Driver selectedDriver = MainService.GetDriverService().GetDriver(int.Parse(driver.SubItems[0].Text));
                driverList.Add(selectedDriver);
            }
            MainService.GetShiftService().Add(dispatcher, driverList);
            _adminForm.Show();
            Close();
        }
    }
}
