using TaxiClient.FormCntrls;
using TaxiClient.Services.CarService;
using TaxiData.Entities;
using WinFormsApp1;

namespace TaxiClient
{
    public partial class AdminForm : Form
    {
        private User _currentUser;
        private MainForm _mainForm;
        public AdminForm(User user, MainForm mainForm)
        {
            InitializeComponent();

            AdminFormCntrl adminFormCntrl = new AdminFormCntrl(user);
            _currentUser = user;
            _mainForm = mainForm;

            LoginText.Text = adminFormCntrl.GetLogin();
            UserTypeText.Text = adminFormCntrl.GetUserType();
        }
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.Show();
        }

        private void UserServiceBtn_Click(object sender, EventArgs e)
        {
            UserServiceForm userServiceForm = new UserServiceForm(this);
            userServiceForm.Show();
            Hide();
        }

        private void DriverServiceBtn_Click(object sender, EventArgs e)
        {
            DriverServiceForm driverServiceForm = new DriverServiceForm(this);
            driverServiceForm.Show();
            Hide();
        }

        private void CarServiceBtn_Click(object sender, EventArgs e)
        {
            CarServiceForm driverServiceForm = new CarServiceForm(this);
            driverServiceForm.Show();
            Hide();
        }
    }
}
