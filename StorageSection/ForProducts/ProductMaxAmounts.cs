using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
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
        //встановлює макс кількість---
        public void SetProdMaxAmount(int prodID, int maxAmount)
        {
            listOfAmounts[prodID] = maxAmount;
        }
        //вертає макс кількість залежно від ід продукту--
        public int GetMaxAmount(int prodID)
        {
            if(listOfAmounts.ContainsKey(prodID))
            {
                return listOfAmounts[prodID];
            }
            //якщо нема ід тоді 0
            return 0;
        }
    }
}
