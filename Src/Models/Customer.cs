using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDatabaseLookup.Src.Models
{
    class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName { get; private set; }
        public string Description { get; private set; }
        public int PhoneNumber { get; private set; }

        public Customer( string firstName, string lastName, string description, int phoneNumber )
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{firstName} {lastName}";
            Description = description;
            PhoneNumber = phoneNumber;
        }

        public Customer( string fullName, string description, int phoneNumebr )
        {
            FullName = fullName;
            string[] h = fullName.Split(' ');
            FirstName = h[0];
            LastName = h[1];
            Description = description;
            PhoneNumber = phoneNumebr;
        }

        public void ChangeFullName( string fullName )
        {
            string[] h = fullName.Split(' ');
            FirstName = h[0];
            LastName = h[1];
            FullName = fullName;
        }

    }
}
