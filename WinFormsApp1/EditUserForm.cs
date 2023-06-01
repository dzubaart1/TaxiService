using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiBusiness.Services;
using TaxiData.Entities;
using TaxiData.Models;
using WinFormsApp1;

namespace TaxiClient
{
    public partial class EditUserForm : Form
    {
        private User _currentUser;
        private AdminForm _adminForm;
        public EditUserForm(User user, AdminForm adminForm)
        {
            InitializeComponent();
            _currentUser = user;

            LoginTextBox.Text = user.Login;
            PasswordTextBox.Text = user.Password;
            UserTypeComboBox.Items.AddRange(new string[] { "Admin", "Dispatcher" });
            UserTypeComboBox.SelectedIndex = (int)user.Status;

            _adminForm = adminForm;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string userTypeStr = UserTypeComboBox.Text;
            UserType userType = UserType.Admin;
            switch (userTypeStr)
            {
                case "Dispatcher":
                    userType = UserType.Dispatcher;
                    break;
            }
            MainService.GetUserService().EditUser(_currentUser.Id, LoginTextBox.Text, PasswordTextBox.Text, userType);
            _adminForm.Show();
            Close();
        }

        private void EditUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _adminForm.Show();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            MainService.GetUserService().RemoveUser(_currentUser);
            _adminForm.Show();
            Close();
        }
    }
}
