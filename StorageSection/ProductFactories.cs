using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{

    #region [Factories]
    interface AbstractProductFactory
    {
        public MeatProduct CreateMeatProduct();
        public DairyProduct CreateDairyProduct();
        public HouseholdProduct CreateHouseholdProduct(); 
    }

    class UkrainianProductFactory : AbstractProductFactory
    {
        public DairyProduct CreateDairyProduct()
        {
            return new UkrainianDairyProduct();
        }

        public HouseholdProduct CreateHouseholdProduct()
        {
            return new UkrainianHouseholdProduct();
        }

        public MeatProduct CreateMeatProduct()
        {
            return new UkrainianMeatProduct();
        }
    }

    class EuropeanProductFactory : AbstractProductFactory
    {
        public DairyProduct CreateDairyProduct()
        {
            return new EuropeanDairyProduct();
        }

        public HouseholdProduct CreateHouseholdProduct()
        {
            return new EuropeanHouseholdProduct();
        }

        public MeatProduct CreateMeatProduct()
        {
            return new EuropeanMeatProduct();
        }
    }

    #endregion
}
