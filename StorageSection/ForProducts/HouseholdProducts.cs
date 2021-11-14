using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    #region [HouseHold Products]
    class HouseholdProduct : Product
    {
        public HouseholdProduct():base()
        {

        }
    }

    class UkrainianHouseholdProduct: HouseholdProduct
    {
        public UkrainianHouseholdProduct():base()
        {

        }
    }

    class EuropeanHouseholdProduct : HouseholdProduct
    {
        public EuropeanHouseholdProduct() : base()
        {

        }
    }
    #endregion
}
