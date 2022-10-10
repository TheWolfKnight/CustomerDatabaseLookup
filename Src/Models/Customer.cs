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
        public List<Models.Order> OrderHistory { get; private set; }


        /// <summary>
        /// Creates a new customer based on a first name, last name, desctiption, and phone number
        /// </summary>
        /// <param name="firstName"> The first name of the customer </param>
        /// <param name="lastName"> The last name of the customer </param>
        /// <param name="description"> The description of the customer </param>
        /// <param name="phoneNumber"> The phone number of the customer </param>
        public Customer(string firstName, string lastName, string description, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{firstName} {lastName}";
            Description = description;
            PhoneNumber = phoneNumber;
            OrderHistory = new List<Order>();
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
            OrderHistory = new List<Order>();
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

        /// <summary>
        /// Get the count of orders for the customer
        /// </summary>
        /// <returns> Integer amt of orders in order history </returns>
        public int OrderAmount()
        {
            return OrderHistory.Count;
        }


    }
}
