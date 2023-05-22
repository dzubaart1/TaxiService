using TaxiData.Models;

namespace TaxiData.Entities
{
    public class Dispatcher : User
    {
        public Dispatcher(string login, string password) : base(login, password, UserType.Dispatcher)
        {
        }
    }
}
