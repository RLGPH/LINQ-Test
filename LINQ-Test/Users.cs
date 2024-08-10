using System;

namespace LINQ_Test
{
    public class User
    {
        public int UserId { get; private set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tlf { get; set; }
        public string Mail { get; set; }

        public User(int userId, string fullName, string firstName, string lastName, string tlf, string mail)
        {
            UserId = userId;
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

        public override string ToString()
        {
            return $"ID: {UserId}, Name: {FullName}, Phone: {Tlf}, Email: {Mail}";
        }
    }
}