using TaxiBusiness.Services;
using TaxiData.Entities;
using TaxiData.Models;

namespace TaxiClient
{
    public partial class AddNewUserForm : Form
    {
        private User _currentUser;
        private AdminForm _adminForm;
        public AddNewUserForm(User user, AdminForm adminForm)
        {
            InitializeComponent();
            _adminForm = adminForm;
            _currentUser = user;
            UserTypeComboBox.Items.AddRange(new string[] { "Admin", "Dispatcher" });
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            if (string.IsNullOrWhiteSpace(login))
            {
                DebugText.Text = "Login is incorrect";
                return;
            }
            string password = PasswordTextBox.Text;
            if (string.IsNullOrWhiteSpace(password))
            {
                DebugText.Text = "Password is incorrect";
                return;
            }
            string userTypeStr = UserTypeComboBox.Text;
            if (string.IsNullOrWhiteSpace(userTypeStr))
            {
                DebugText.Text = "UserType is not selected";
                return;
            }

            UserType userType = UserType.Admin;
            switch (userTypeStr)
            {
                case "Dispatcher":
                    userType = UserType.Dispatcher;
                    break;
            }

            MainService.GetUserService().AddUser(login, password, userType);
            _adminForm.Show();
            Close();
        }

        private void AddNewUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _adminForm.Show();
        }
    }
}
