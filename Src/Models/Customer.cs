using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDatabaseLookup.Src.Models
{
    public class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName { get; private set; }
        public string Description { get; private set; }
        public int PhoneNumber { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="description"></param>
        /// <param name="phoneNumber"></param>
        public Customer(string firstName, string lastName, string description, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{firstName} {lastName}";
            Description = description;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="description"></param>
        /// <param name="phoneNumebr"></param>
        public Customer(string fullName, string description, int phoneNumebr)
        {
            FullName = fullName;
            string[] h = fullName.Split(' ');
            FirstName = h[0];
            LastName = h[1];
            Description = description;
            PhoneNumber = phoneNumebr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullName"></param>
        public void ChangeFullName(string fullName)
        {
            string[] h = fullName.Split(' ');
            FirstName = h[0];
            LastName = h[1];
            FullName = fullName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newPhoneNumber"></param>
        public void ChangePhoneNumber( int newPhoneNumber )
        {
            PhoneNumber = newPhoneNumber;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newDescription"></param>
        public void ChangeDescription( string newDescription)
        {
            Description = newDescription;
        }

    }
}
