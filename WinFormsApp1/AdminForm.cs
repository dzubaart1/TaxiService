using TaxiClient.FormCntrls;
using TaxiData.Entities;

namespace TaxiClient
{
    public partial class AdminForm : Form
    {
        public AdminForm(User user)
        {
            InitializeComponent();

            AdminFormCntrl adminFormCntrl = new AdminFormCntrl(user);

            LoginText.Text = adminFormCntrl.GetLogin();
            UserTypeText.Text = adminFormCntrl.GetUserType();
        }
    }
}
