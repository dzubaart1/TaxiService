using TaxiBusiness.Services;
using TaxiClient.FormCntrls;
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

            UpdateUserListView();
        }
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUserForm = new AddNewUserForm(_currentUser, this);
            addNewUserForm.Show();
            Close();
        }
        public void UpdateUserListView()
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
            _mainForm.Show();
        }
        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            RemoveUserForm removeUserForm = new RemoveUserForm(_currentUser);
            removeUserForm.Show();
            Close();
        }
        private void UserListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserListView.SelectedItems.Count == 0)
            {
                return;
            }

            User selectedUser = MainService.GetUserService().GetUser(int.Parse(UserListView.SelectedItems[0].Text));
            EditUserForm editUserForm = new EditUserForm(selectedUser, this);
            editUserForm.Show();
            Hide();
        }

        public void ClearUserList()
        {
            UserListView.Items.Clear();
        }
    }
}
