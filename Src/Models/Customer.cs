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
        public List<Order> OrderHistory { get; private set; }


        /// <summary>
        /// Creates a new 
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
        /// Creates a new Customer instance based off of a full name, description, and phone number
        /// </summary>
        /// <param name="fullName"> The full name of the customer </param>
        /// <param name="description"> The description for the customer </param>
        /// <param name="phoneNumebr"> The phone number of the customer </param>
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
        /// Sets a new full name, first name, and last name for the customer instance
        /// </summary>
        /// <param name="fullName"> The new full name of the customer </param>
        public void ChangeFullName(string fullName)
        {
            string[] h = fullName.Split(' ');
            FirstName = h[0];
            LastName = h[1];
            FullName = fullName;
        }

        /// <summary>
        /// Sets a new phone number for the customer instance
        /// </summary>
        /// <param name="newPhoneNumber"> The new phone number of the customer </param>
        public void ChangePhoneNumber( int newPhoneNumber )
        {
            PhoneNumber = newPhoneNumber;

        }

        /// <summary>
        /// Sets a new description for the customer instance
        /// </summary>
        /// <param name="newDescription"> The new description </param>
        public void ChangeDescription( string newDescription)
        {
            Description = newDescription;
        }
        
        /// <summary>
        /// Adds an Order instance to the customer instance
        /// </summary>
        /// <param name="order"> The order that the customer has placed </param>
        public void PlaceOrder( Order order )
        {
            OrderHistory.Add(order);
        }


    }
}
