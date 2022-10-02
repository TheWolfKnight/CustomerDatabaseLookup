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

        private CustomerEditor Owner { get; set; }


        public CustomerEditorHandle( CustomerEditor owner)
        {
            Owner = owner;
        }

        public void CustomerEditorLoad()
        {
            // TBD
        }

    }
}
