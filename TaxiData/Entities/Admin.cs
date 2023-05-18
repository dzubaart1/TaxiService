namespace TaxiData.Entities
{
    public class Admin : User
    {
        public Admin(string login, string password) : base(login, password)
        {
        }
            
        public User AddUser(string login, string password)
        {
            return new User(login, password);
        }
        
        public User RemoveUser(User user)
        {
            return user;
        }

        public void EditUser(User user, string login, string password)
        {
            user.EditUser(login, password);
        }
    }
}
