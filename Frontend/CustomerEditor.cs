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
using CustomerDatabaseLookup.Src.WindowHandles;

namespace CustomerDatabaseLookup.Frontend
{

    public partial class CustomerEditor : Form
    {

        private CustomerEditorHandle WindowHandle { get; set; }
        
        public Customer ToChange { get; private set; }
        public MainWindow Owner { get; private set; }

        public CustomerEditor(MainWindow owner, Customer toChange)
        { 
            InitializeComponent();
            ToChange = toChange;
            Owner = owner;
            WindowHandle = new CustomerEditorHandle(this);

        }


        private void CustomerEditor_Load(object sender, EventArgs e)
        {
            WindowHandle.CustomerEditorLoad();
        }

        private void submitButton_Click( object sender, EventArgs e )
        {
            WindowHandle.SubmitButtonClickEvent();
        }

        private void cancelButton_Click( object sender, EventArgs e )
        {
            WindowHandle.CancelButtonClickEvent();
        }

    }
}
