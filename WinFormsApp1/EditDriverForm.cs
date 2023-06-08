using TaxiBusiness.Services;
using TaxiData.Models;

namespace TaxiClient
{
    public partial class EditDriverForm : Form
    {
        private Driver _currentDriver;
        private DriverServiceForm _driverServiceForm;
        public EditDriverForm(Driver driver, DriverServiceForm driverServiceForm)
        {
            InitializeComponent();
            _currentDriver = driver;
            _driverServiceForm = driverServiceForm;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MainService.GetDriverService().Edit(int.Parse(IDTextBox.Text), NameTextBox.Text);
            _driverServiceForm.Show();
            Close();
        }

        private void EditDriverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _driverServiceForm.Show();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            MainService.GetDriverService().Remove(_currentDriver);
            _driverServiceForm.Show();
            Close();
        }
    }
}
