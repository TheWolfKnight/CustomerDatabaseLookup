using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CustomerDatabaseLookup.Src.WindowHandles;
using CustomerDatabaseLookup.Src.Services;

namespace CustomerDatabaseLookup.Frontend
{
    public partial class LoginWindow : Form
    {

        private LoginWindowHandle WindowHandle;
        private ErrorLogging Log;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            WindowHandle = new LoginWindowHandle(this);
            Log = new ErrorLogging();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                WindowHandle.LoginButtonClickEvent();
            } catch ( ArgumentNullException ANE )
            {
                MessageBox.Show("Both input fields must be field out", "Error", MessageBoxButtons.OK);
                Log.WriteErrorLog(ANE.Message);
            } catch ( InputException IE )
            {
                MessageBox.Show("Either Username of Password was wrong", "Error", MessageBoxButtons.OK);
                Log.WriteErrorLog(IE.Message);
            }
        }
    }
}
