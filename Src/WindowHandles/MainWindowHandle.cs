using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using CustomerDatabaseLookup.Src;
using CustomerDatabaseLookup.Src.Models;

namespace CustomerDatabaseLookup.Src
{
    public class MainWindowHandle
    {

        public MainWindow Window { get; private set; }
        private const int TEST_CASE_AMT = 4;

        public MainWindowHandle( MainWindow window )
        {
            Window = window;
        }

        /// <summary>
        /// 
        /// </summary
        public void InitMainWindow()
        {
            Customer newCustomer = new Customer("John Dow", "Man with a heart of ice", 12345678);
            for ( int i = 0; i < TEST_CASE_AMT; i++ )
            {
                newCustomer.PlaceOrder(
                    new Order(i, "Plastic straws", DateTime.Now.AddMinutes(i + 5), 5, (i % 2 == 0) ? OrderStatus.Processing : OrderStatus.Complete)
                );
            }
            WriteToScreen(newCustomer);
        }

        /// <summary>
        /// Takes in a customer, and writes their data to the screen.
        /// </summary>
        /// <param name="customerToWrite"> The customer to be writen to the screen </param>
        private void WriteToScreen(Customer customerToWrite)
        {
            Window.nameHolderLabel.Text = customerToWrite.FullName;
            Window.phoneNumberHolderLabel.Text = $"{customerToWrite.PhoneNumber}";
            Window.descriptionHolderLabel.Text = customerToWrite.Description;
        }

    }
}
