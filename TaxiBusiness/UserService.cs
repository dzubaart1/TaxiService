using TaxiData.Entities;

namespace TaxiBusiness
{
    public class UserService : IService
    {
        private List<User> _users;
        private Admin _admin;

        public UserService()
        {
            _users = new List<User>();
            _admin = new Admin("123", "123");
        }

        public void AddUser(string login, string password)
        {
            _users.Add(_admin.AddUser(login, password));
        }

        public void RemoveUser(User user)
        {
            _users.Remove(_admin.RemoveUser(user));
        }

        public void EditUser(int id, string login, string password)
        {
            foreach (User user in _users)
            {
                if (user.Id == id)
                {
                    _admin.EditUser(login, password);
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
