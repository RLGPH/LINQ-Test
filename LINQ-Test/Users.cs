using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Test
{
    public class User
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tlf { get; set; }
        public string Mail { get; set; }
        public User(string userid, string fullName, string firstName, string lastName, string tlf, string mail)
        {
            UserId = userid;
            FullName = fullName;
            FirstName = firstName;
            LastName = lastName;
            Tlf = tlf;
            Mail = mail;
        }

        public string nameCombiner()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
