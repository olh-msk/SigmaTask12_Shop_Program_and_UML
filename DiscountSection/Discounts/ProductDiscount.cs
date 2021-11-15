using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class ProductDiscount: Discount
    {

        public ProductDiscount():base()
        {
            this.Interest = 0.15;
        }
    }
}
