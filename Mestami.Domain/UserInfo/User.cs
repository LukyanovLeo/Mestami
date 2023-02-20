using Mestami.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.UserInfo
{
    public class User : IUser
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string Login { get; set; }

        public DateTime RegisteredAt { get; set; }

        public DateTime LastLoginAt { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }

        public User()
        {

        }

        public User(
            Guid id, 
            string firstName, 
            string lastName, 
            string login, 
            DateTime registeredAt, 
            DateTime lastLoginAt, 
            string password, 
            string email,
            Role role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Login = login;
            RegisteredAt = registeredAt;
            LastLoginAt = lastLoginAt;
            Password = password;
            Email = email;
            Role = role;
        }

        public void Logout(string username)
        {
            throw new NotImplementedException();
        }

        public void Register(string email, string username, Initials initials, string password, string repeatPassword, DateTime birthdate)
        {
            throw new NotImplementedException();
        }

        public void Remove(string username)
        {
            throw new NotImplementedException();
        }

        void IUser.Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
