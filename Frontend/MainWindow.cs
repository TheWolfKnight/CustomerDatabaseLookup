using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CustomerDatabaseLookup.Src.Models;

namespace CustomerDatabaseLookup
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer("John Dow", "Man with a heart of ice", 12345678);
            WriteToScreen(newCustomer);
        }
 
        /// <summary>
        /// Takes in a customer, and writes their data to the screen.
        /// </summary>
        /// <param name="customerToWrite"> The customer to be writen to the screen </param>
        private void WriteToScreen(Customer customerToWrite)
        {
            this.nameHolderLabel.Text  = customerToWrite.FullName;
            this.phoneNumberHolderLabel.Text = string.Format("{0}", customerToWrite.PhoneNumber);
            this.descriptionHolderLabel.Text = customerToWrite.Description;
        }

    }
}
