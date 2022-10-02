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

        private CustomerEditorHandle Handle { get; set; }
        private Customer ToChagne { get; set; }

        public CustomerEditor(Customer toChange)
        { 
            InitializeComponent();
            ToChagne = toChange;
            Handle = new CustomerEditorHandle(this);

        }

        private void CustomerEditor_Load(object sender, EventArgs e)
        {
            Handle.CustomerEditorLoad();
        }
    }
}
