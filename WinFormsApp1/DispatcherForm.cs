using TaxiClient.FormCntrls;
using TaxiData.Entities;

namespace TaxiClient
{
    public partial class DispatcherForm : Form
    {
        public DispatcherForm(User user)
        {
            InitializeComponent();

            DispatcherFormCntrl dispatcherFormCntrl = new DispatcherFormCntrl(user);

            UserText.Text = dispatcherFormCntrl.GetLogin();
            UserTypeText.Text = dispatcherFormCntrl.GetUserType();
        }
    }
}
