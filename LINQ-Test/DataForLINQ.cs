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
        List<User>? users;
        int[] numbers;
        public void MakeList()
        {
            User user0 = new("1", "John Doe", "John", "Doe", "+45 123456789", "something@somewhere.some");
            User user1 = new("2", "John Doe", "John", "Doe", "+45 123456789", "something@somewhere.some");
            User user2 = new("3", "John Doe", "John", "Doe", "+45 123456789", "something@somewhere.some");
            User user3 = new("4", "John Doe", "John", "Doe", "+45 123456789", "something@somewhere.some");
            User user4 = new("5", "John Doe", "John", "Doe", "+45 123456789", "something@somewhere.some");
            User user5 = new("6", "John Doe", "John", "Doe", "+45 123456789", "something@somewhere.some");
            users?.Add(user0);
            users?.Add(user1);
            users?.Add(user2);
            users?.Add(user3);
            users?.Add(user4);
            users?.Add(user5);

            numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
    }
}
