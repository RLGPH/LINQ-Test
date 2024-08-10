using System;
using LINQ_Test;

namespace LINQTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DataForLINQ data = new();
            LINQ_Methods linqMethods = new();

            
            data.MakeLists();

            List<User> users = new List<User>();
            users = data.GetDataUsers();

            int[] numbers;
            numbers = data.GetDataInts();

            var selectedUser = linqMethods.SelectedUser(users, 3);
            Console.WriteLine("Selected User:");
            Console.WriteLine(selectedUser);

            var evenNumbers = linqMethods.evenNumbers(numbers);
            Console.WriteLine("\nEven Numbers:");
            Console.WriteLine(string.Join(", ", evenNumbers));

            var oddNumbers = linqMethods.OddNumbers(numbers);
            Console.WriteLine("\nOdd Numbers:");
            Console.WriteLine(string.Join(", ", oddNumbers));

            Console.WriteLine("Current Users:");
            foreach (var user in data.users)
            {
                Console.WriteLine(user);
            }

            User newUser = new User(0, "Jane Smith", "Jane", "Smith", "+45 987654321", "jane@somewhere.some");
            data.NewUser(newUser);

            Console.WriteLine("\nUpdated Users List After Adding New User:");
            foreach (var user in data.users)
            {
                Console.WriteLine(user);
            }
        }
    }
}