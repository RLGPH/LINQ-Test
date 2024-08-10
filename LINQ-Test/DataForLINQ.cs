using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Test
{
    public class DataForLINQ
    {
        public List<User> users=new();
        public int[] numbers;
        public void MakeLists()
        {
            User user0 = new(1, "John Doe", "John", "Doe", "+45 123456789", "something@somewhere.some");
            User user1 = new(2, "John Doe", "John", "Doe", "+45 134567890", "something@somewhere.some");
            User user2 = new(3, "Special Doe", "Special", "Doe", "+45 123776789", "something@somewhere.some");
            User user3 = new(4, "John Doe", "John", "Doe", "+45 173456789", "something@somewhere.some");
            User user4 = new(5, "John Doe", "John", "Doe", "+45 128976789", "something@somewhere.some");
            User user5 = new(6, "John Doe", "John", "Doe", "+45 120656789", "something@somewhere.some");
            users.Add(user0);
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);

            numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
        public void NewUser(User user)
        {   
            int highestId = users.Max(u => u.UserId);

            user = new User(highestId + 1, user.FullName, user.FirstName, user.LastName, user.Tlf, user.Mail);

            users.Add(user);
        }
        public List<User> GetDataUsers()
        {
            return users;
        }
        public int[] GetDataInts()
        {
            return numbers;
        }
    }
}
