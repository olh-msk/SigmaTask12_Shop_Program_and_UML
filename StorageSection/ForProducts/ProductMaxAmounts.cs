using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    #region [Products Max Amounts]
    //зберігає максимальну кількість продуктів
    class ProductMaxAmounts
    {
        private static ProductMaxAmounts instance;

        //збрігає id продукту і його максимальну кількість
        Dictionary<int, int> listOfAmounts;

        private ProductMaxAmounts()
        {
            listOfAmounts = new Dictionary<int, int>();
        }

        public static ProductMaxAmounts Instance()
        {
            if(instance == null)
            {
                instance = new ProductMaxAmounts();
            }
            return instance;
        }
        //встановлює макс кількість-----
        public void SetProductMaxAmount(int prodID, int maxAmount)
        {
            listOfAmounts[prodID] = maxAmount;
        }
        //вертає макс кількість залежно від ід продукту----
        public int GetProductMaxAmount(int prodID)
        {
            if(listOfAmounts.ContainsKey(prodID))
            {
                return listOfAmounts[prodID];
            }
            //якщо нема ід тоді 0
            return 0;
        }
        public void RemoveProductMaxAmount(int prodID)
        {
            listOfAmounts.Remove(prodID);
        }
    }
    #endregion
}
