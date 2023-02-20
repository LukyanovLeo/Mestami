using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.UserInfo
{
    public class Initials
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string FirstNameShort { get; private set; }

        public string LastNameShort { get; private set; }


        public Initials(
            string firstName, 
            string lastName, 
            string patronymic)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            FirstNameShort = firstName?.First().ToString();
            LastNameShort = lastName?.First().ToString();
        }
    }
}
