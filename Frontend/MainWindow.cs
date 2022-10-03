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

        public MainWindowHandle WindowHandle { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            WindowHandle = new MainWindowHandle(this);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            WindowHandle.InitMainWindow();
        }

        private void editUserDateButton_Click(object sender, EventArgs e)
        {
            WindowHandle.EditUserDataButtonClickEvent();
        }
    }
}
