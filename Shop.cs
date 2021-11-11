﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class Shop
    {
        private static Shop instance;


        private Shop()
        {

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
