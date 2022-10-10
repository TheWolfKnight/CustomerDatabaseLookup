using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomerDatabaseLookup.Src.Services;
using CustomerDatabaseLookup.Src.Models;
using CustomerDatabaseLookup.Frontend;

namespace CustomerDatabaseLookup.Src.WindowHandles
{
    public class CustomerEditorHandle
    {

        public CustomerEditor Owner { get; private set; }

        private ErrorLogging Log = new ErrorLogging();

        public CustomerEditorHandle( CustomerEditor owner)
        {
            Owner = owner;
        }

        public void CustomerEditorLoad()
        {
            Owner.firstNameInput.Text = Owner.ToChange.FirstName;
            Owner.lastNameInput.Text = Owner.ToChange.LastName;
            Owner.phoneNumberInput.Text = Owner.ToChange.PhoneNumber.ToString();
            Owner.descriptionInput.Text = Owner.ToChange.Description;
        }

        public void SubmitButtonClickEvent()
        {
            try
            {

                if (Owner.phoneNumberInput.Text.Length != 8)
                    throw new FormatException("Less than 8");

                Customer customer = new Customer(
                    Owner.firstNameInput.Text,
                    Owner.lastNameInput.Text,
                    Owner.descriptionInput.Text,
                    int.Parse(Owner.phoneNumberInput.Text)
                );
                Owner.Owner.WindowHandle.CustomerEditorUpdater(customer);
                Owner.Close();
            } catch ( FormatException fe )
            {
                if (fe.Message.Equals("Less than 8") && int.TryParse(Owner.phoneNumberInput.Text, out int _))
                    Owner.lb_errorLabel.Text = "The phone number may, only contains 8 numbers";
                else
                    Owner.lb_errorLabel.Text = "The phone number field may only contain numbers";
                Owner.lb_errorLabel.Visible = true;
                Log.WriteErrorLog(fe.Message);
            }
        }

        public void CancelButtonClickEvent()
        {
            Owner.Close();
        }
    }
}
