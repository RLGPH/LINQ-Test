using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Test
{
    public class LINQ_Methods
    {
        User User;
        public User SelectedUser(List<User> users, int ID)
        {
            if (users == null)
            {
                throw new ArgumentNullException(nameof(users), "The users list cannot be null.");
            }

            return users.FirstOrDefault(user => user.UserId == ID);
        }

        public int[] evenNumbers(int[] Numbers)
        {
            return Numbers.Where(num => num % 2 == 0).ToArray();
        }

        public int[] OddNumbers(int[] Numbers)
        { 
            return Numbers.Where(num => num % 2 != 0).ToArray();
        }
    }
}
