﻿using System;
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
        Dictionary<int, int> listOfProductMaxAmounts;

        private ProductMaxAmounts()
        {
            listOfProductMaxAmounts = new Dictionary<int, int>();
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
            listOfProductMaxAmounts[prodID] = maxAmount;
        }
        //вертає макс кількість залежно від ід продукту----
        public int GetProductMaxAmount(int prodID)
        {
            if(listOfProductMaxAmounts.ContainsKey(prodID))
            {
                return listOfProductMaxAmounts[prodID];
            }
            //якщо нема ід тоді 0
            return 0;
        }
        public void RemoveProductMaxAmount(int prodID)
        {
            listOfProductMaxAmounts.Remove(prodID);
        }
    }
    #endregion
}
