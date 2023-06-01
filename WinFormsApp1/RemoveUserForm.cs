using TaxiBusiness.Services;
using TaxiData.Entities;

namespace TaxiClient
{
    public partial class RemoveUserForm : Form
    {
        private User _currentUser;
        int i;
        public RemoveUserForm(User user)
        {
            InitializeComponent();

            _currentUser = user;
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUserListView();
        }

        private void UpdateUserListView()
        {
            foreach (var user in MainService.GetUserService().Users)
            {
                if (user.Id.ToString().Equals(IDTextBox.Text))
                {
                    ListViewItem item = new ListViewItem(user.Id.ToString());
                    item.SubItems.Add(user.Login);
                    UserListView.Items.Add(item);
                }
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            foreach (var user in MainService.GetUserService().Users)
            {
                //if (int.TryParse(IDTextBox.Text, out i))
                //{
                //    DebugText.Text = "Incorrect ID";
                //    return;
                //}

                if (user.Id.ToString().Equals(IDTextBox.Text))
                {
                    MainService.GetUserService().RemoveUser(user);
                }
            }
        }
    }
}
