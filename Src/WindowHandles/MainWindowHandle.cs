using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using CustomerDatabaseLookup.Frontend;

using CustomerDatabaseLookup.Src;
using static CustomerDatabaseLookup.Src.Services.OrderFilter;
using CustomerDatabaseLookup.Src.Models;
using CustomerDatabaseLookup.Src.Services;

namespace CustomerDatabaseLookup.Src
{
    public class MainWindowHandle
    {

        public MainWindow Owner { get; private set; }
        public Customer ActiveCustomer { get; private set; }

        private const int TEST_CASE_AMT = 4;

        public MainWindowHandle( MainWindow owner )
        {
            Owner = owner;
        }

        /// <summary>
        /// Initiates the main window for the program
        /// </summary
        public void InitMainWindow()
        {
            ActiveCustomer = new Customer("John Dow", "Man with a heart of ice", 12345678);
            for ( int i = 0; i < TEST_CASE_AMT; i++ )
            {
                ActiveCustomer.PlaceOrder(
                    new OrderHistories(i, "Plastic straws", DateTime.Now.AddMinutes(i + 5), (float)RandomNumber(), (i % 2 == 0) ? OrderStatus.Processing : OrderStatus.Complete)
                );
            }
            WriteToScreen(ActiveCustomer);

            Owner.dgv_CustomerOrderHistories.DataSource = ActiveCustomer.OrderHistory;
            Owner.dgv_CustomerOrderPriceIncress.DataSource = OrderFilter.SortPricesIncresse(ActiveCustomer.OrderHistory);

        }


        /// <summary>
        ///
        /// </summary>
        public void EditUserDataButtonClickEvent()
        {
            CustomerEditor customerEditor = new CustomerEditor(Owner, ActiveCustomer);
            customerEditor.Show();
        }

        /// <summary>
        ///
        /// </summary>
        public void CustomerEditorUpdater( Customer changes )
        {
            throw new Exception("TBD");
        }


        /// <summary>
        /// Takes in a customer, and writes their data to the screen.
        /// </summary>
        /// <param name="customerToWrite"> The customer to be writen to the screen </param>
        private void WriteToScreen(Customer customerToWrite)
        {
            Owner.nameHolderLabel.Text = customerToWrite.FullName;
            Owner.phoneNumberHolderLabel.Text = $"{customerToWrite.PhoneNumber}";
            Owner.descriptionHolderLabel.Text = customerToWrite.Description;
        }

        private double RandomNumber()
        {
            Random rng = new Random(DateTime.Now.Millisecond * DateTime.Now.Year);
            return rng.NextDouble() * 100;
        }

    }

}
