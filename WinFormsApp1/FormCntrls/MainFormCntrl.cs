using TaxiBusiness.Services;
using TaxiData.Entities;
using TaxiData.Models;

namespace TaxiClient.FormCntrls
{
    public class MainFormCntrl
    {
        public User? Authentication(string login, string password)
        {
            return MainService.GetUserService().FindUser(login, password);
        }
        public void Authorization(User user)
        {
            switch (user.UserType)
            {
                case UserType.Admin:
                    AdminForm adminForm = new AdminForm(user);
                    adminForm.Show();
                    break;
                case UserType.Dispatcher:
                    break;
                default:
                    break;
            }
        }
    }
}
