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
        private OrderFilter Filter;

        public MainWindowHandle( MainWindow owner )
        {
            Owner = owner;
            Filter = new OrderFilter();
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
                    new Order(i, "Plastic straws", DateTime.Now.AddMinutes(i + 5), (float)RandomNumber(), (i % 2 == 0) ? OrderStatus.Processing : OrderStatus.Complete)
                );
            }
            WriteToScreen();
            WriteDataGridViews();

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
            changes.SetOrderHistory(ActiveCustomer.OrderHistory);
            ActiveCustomer = changes;
            WriteToScreen();
            WriteDataGridViews();
        }


        /// <summary>
        /// Takes in a customer, and writes their data to the screen.
        /// </summary>
        private void WriteToScreen()
        {
            Owner.nameHolderLabel.Text = ActiveCustomer.FullName;
            Owner.phoneNumberHolderLabel.Text = $"{ActiveCustomer.PhoneNumber}";
            Owner.descriptionHolderLabel.Text = ActiveCustomer.Description;
        }

        /// <summary>
        /// 
        /// </summary>
        private void WriteDataGridViews()
        {
            Owner.dgv_CustomerOrderHistories.DataSource = ActiveCustomer.OrderHistory;
            Owner.dgv_CustomerOrderPriceIncress.DataSource = Filter.SortPricesIncresse(ActiveCustomer.OrderHistory);
            Owner.dgv_CompletedOrders.DataSource = Filter.GetCompletedOrder(ActiveCustomer.OrderHistory);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private double RandomNumber()
        {
            Random rng = new Random(DateTime.Now.Millisecond * DateTime.Now.Year);
            return rng.NextDouble() * 100;
        }

    }

}
