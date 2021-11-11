using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    enum MeatCategories { High_sort, I_sort, II_sort };
    class MeatProduct : Product
    {
        public MeatCategories MeatCategory { get; set; }

        public MeatProduct():base()
        {

        }
    }
}
