using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class ShopMediator
    {
        private static ShopMediator instance;

        private ShopMediator()
        {

        }
        public static ShopMediator Instance()
        {
            if (instance == null)
            {
                instance = new ShopMediator();
            }
            return instance;
        }



    }
}
