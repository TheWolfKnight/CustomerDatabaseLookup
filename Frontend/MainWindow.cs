using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CustomerDatabaseLookup.Src;
using CustomerDatabaseLookup.Src.Models;

namespace CustomerDatabaseLookup
{
    public partial class MainWindow : Form
    {

        private MainWindowHandle Handle { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Handle = new MainWindowHandle(this);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Handle.InitMainWindow();
        }
    }
}
