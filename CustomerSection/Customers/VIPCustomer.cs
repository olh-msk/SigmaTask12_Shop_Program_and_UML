using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class VIPCustomer: Customer
    {

        public VIPCustomer():base()
        {
            this.UserStatus = UserStatus.VIP;
        }
    }
}
