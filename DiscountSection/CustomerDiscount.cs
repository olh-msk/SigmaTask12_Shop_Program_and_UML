using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class CustomerDiscount: Discount
    {
        public CustomerDiscount():base()
        {
            this.Interest = 0.20;
        }
    }
}
