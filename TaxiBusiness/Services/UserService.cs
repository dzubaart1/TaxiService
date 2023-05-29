using TaxiData.Entities;
using TaxiData.Models;

namespace TaxiBusiness.Services
{
    public class UserService : IService<List<User>>
    {
        private List<User> _users;

        public UserService()
        {
            _users = Download();
            if (_users.Count == 0)
            {
                GenerateDefaultAdmin();
            }
        }
        public IReadOnlyCollection<User> Users => _users;

        public void AddUser(string login, string password, UserType userType)
        {
            _users.Add(new User(login, password, userType, MainService.GetIdGeneratorService().GetNextId()));
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

        public User? FindUser(string login, string password)
        {
            return _users.FirstOrDefault(user => user.Login.Equals(login) && user.Password.Equals(password));
        }

        public List<User> Download()
        {
            return MainService.GetJsonStorage().GetUsers() ?? new List<User>();
        }

        public void Upload()
        {
            MainService.GetJsonStorage().Save(_users);
        }

        private void GenerateDefaultAdmin()
        {
            AddUser("root", "root", UserType.Admin);
        }
    }
}
