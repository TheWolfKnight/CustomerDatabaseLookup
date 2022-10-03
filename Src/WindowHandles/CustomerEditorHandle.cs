using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomerDatabaseLookup.Src.Models;
using CustomerDatabaseLookup.Frontend;

namespace CustomerDatabaseLookup.Src.WindowHandles
{
    public class CustomerEditorHandle
    {

        public CustomerEditor Owner { get; private set; }


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

                Customer customer = new Customer(
                    Owner.firstNameInput.Text,
                    Owner.lastNameInput.Text,
                    Owner.descriptionInput.Text,
                    int.Parse(Owner.phoneNumberInput.Text)
                );
                Owner.Owner.WindowHandle.CustomerEditorUpdater(customer);
            } catch ( FormatException _ )
            {
                throw new Exception("TBD");
            }
        }

        public void CancelButtonClickEvent()
        {
            Owner.Close();
        }
    }
}
