using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CustomerDatabaseLookup.Frontend;

namespace CustomerDatabaseLookup.Src.WindowHandles
{
    public class LoginWindowHandle
    {

        private LoginWindow Owner;

        public LoginWindowHandle( LoginWindow owner )
        {
            Owner = owner;
        }

        public void LoginButtonClickEvent()
        {
            string userNameInput = Owner.tb_UserName.Text;
            string passwordInput = Owner.tb_Password.Text;

            if ( userNameInput is null || passwordInput is null )
            {
                throw new ArgumentNullException("Either username or password is null");
            }

            if ( userNameInput != Properties.Resources.Username )
            {
                throw new InputException("The username input was not found in the database");
            }

            if ( passwordInput != Properties.Resources.Password )
            {
                throw new InputException("Password input was not found in the database");
            }

            Owner.Visible = false;
            new MainWindow().ShowDialog();
            Owner.Close();
        }

    }


    public class InputException : Exception
    {
        public InputException() : base() { }
        public InputException(string msg) : base(msg) { }
        public InputException(string msg, Exception inner) : base(msg, inner) { }
    }

}
