using TaxiBusiness;
using TaxiData;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainService.Upload();

            Application.ApplicationExit += new EventHandler(OnApplicationExit);
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string loginText = LoginTextBox.Text;
            string passwordText = PasswordTextBox.Text;

            var res = MainService.GetUserService().FindUser(loginText, passwordText);
            if (res != null)
            {
                DebugLabel.Text = $"Find User {res.Id}";
            }
            else
            {
                DebugLabel.Text = "Nothing!!!";
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            MainService.Upload();
        }
    }
}