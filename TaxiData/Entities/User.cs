﻿using TaxiData.Models;
using TaxiData.Tools;

namespace TaxiData.Entities
{
    public class User
    {
        public User(string login, string password, UserType userType)
        {
            Login = login;
            Password = password;
            Id = IdGenerator.GenerateId();
            Status = Status.Hired;
            UserType = userType;
        }
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Status Status { get; private set; }
        public UserType UserType { get; private set; }

        public void EditUser(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}

    