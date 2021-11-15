﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class Shop
    {
        private static Shop instance;

        public ShopFacade Facade { get; private set; }

        private Shop()
        {
            this.Facade = ShopFacade.Instance();
        }

        public static Shop Instance()
        {
            if(instance == null)
            {
                instance = new Shop();
            }
            return instance;
        }
    }
}
