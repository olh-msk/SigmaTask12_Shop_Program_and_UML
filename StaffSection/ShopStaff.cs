using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class ShopStaff
    {
        private static ShopStaff instance;

        private ShopStaff()
        {
            
        }

        public static ShopStaff Instance()
        {
            if(instance == null)
            {
                instance = new ShopStaff();
            }
            return instance;
        }
    }
}
