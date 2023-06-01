using TaxiBusiness.Services;
using TaxiClient.FormCntrls;
using TaxiData.Entities;
using WinFormsApp1;

namespace TaxiClient
{
    public partial class AdminForm : Form
    {
        private User _currentUser;
        public AdminForm(User user)
        {
            InitializeComponent();

            AdminFormCntrl adminFormCntrl = new AdminFormCntrl(user);
            _currentUser = user;

            LoginText.Text = adminFormCntrl.GetLogin();
            UserTypeText.Text = adminFormCntrl.GetUserType();

            UpdateUserListView();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUserForm = new AddNewUserForm(_currentUser);
            addNewUserForm.Show();
            this.Hide();
        }
        private void UpdateUserListView()
        {
            foreach (var user in MainService.GetUserService().Users)
            {
                ListViewItem item = new ListViewItem(user.Id.ToString());
                item.SubItems.Add(user.Login);
                UserListView.Items.Add(item);
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            RemoveUserForm removeUserForm = new RemoveUserForm(_currentUser);
            removeUserForm.Show();
            this.Hide();
        }
    }
}
