using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.UserInfo
{
    public interface IUser
    {
        void Register(
            string email, 
            string username,
            Initials initials,
            string password, 
            string repeatPassword,
            DateTime birthdate
            );

        void Login(string username, string password);

        void Logout(string username);

        void Remove(string username);
    }
}
