using TaxiBusiness.Services;
using TaxiClient.FormCntrls;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private MainFormCntrl _mainFormCntrl;
        public MainForm()
        {
            InitializeComponent();
            MainService.Upload();

            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            _mainFormCntrl = new MainFormCntrl();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string loginText = LoginTextBox.Text;
            string passwordText = PasswordTextBox.Text;

            var res = _mainFormCntrl.Authentication(loginText, passwordText);

            if (res is null)
            {
                DebugLabel.Text = "Nothing!!!";
                return;
            }

            this.Hide();
            _mainFormCntrl.Authorization(res);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            MainService.Upload();
        }
    }
}