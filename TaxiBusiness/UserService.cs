using TaxiData.Entities;
using TaxiData.Models;

namespace TaxiBusiness
{
    public class UserService : IService
    {
        private List<User> _users;

        public UserService()
        {
            _users = new List<User>();
        }

        public void AddUser(string login, string password, UserType userType)
        {
            _users.Add(new User(login, password, userType));
        }

        public void RemoveUser(User user)
        {
            _users.Remove(user);
        }

        public void EditUser(int id, string login, string password)
        {
            foreach (User user in _users)
            {
                if (user.Id == id)
                {
                    user.EditUser(login, password);
                }
            }
        }

        public void Download()
        {
            throw new NotImplementedException();
        }

        public void Upload()
        {
            throw new NotImplementedException();
        }
    }
}
