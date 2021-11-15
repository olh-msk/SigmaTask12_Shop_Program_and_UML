﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    #region [Product Discount Manager]
    interface IOperationSetGetProductDiscount
    {
        public ProductDiscount GetProductDiscount(int prodID);
        public void SetDiscountForProduct(int prodID, ProductDiscount dis);
    }
    class ProductDiscountManager: IOperationSetGetProductDiscount
    {
        private static ProductDiscountManager instance;
        //зберігає ід покупця і його знижку, якщо вона є
        Dictionary<int, ProductDiscount> productDiscounts;

        private ProductDiscountManager()
        {
            productDiscounts = new Dictionary<int, ProductDiscount>();
        }
        public static ProductDiscountManager Instance()
        {
            if (instance == null)
            {
                instance = new ProductDiscountManager();
            }
            return instance;
        }

        public ProductDiscount CreateNewProductDiscount()
        {
            return new ProductDiscount();
        }

        //встановити знижку для покупця
        public void SetDiscountForProduct(int prodID, ProductDiscount dis)
        {
            productDiscounts[prodID] = dis;
        }

        //видалити знижку----
        public void RemoveDiscountFromProduct(int prodID)
        {
            productDiscounts.Remove(prodID);
        }
        //отримати знижку по ід-----
        public ProductDiscount GetProductDiscount(int prodID)
        {
            if (productDiscounts.ContainsKey(prodID))
            {
                return productDiscounts[prodID];
            }
            return null;
        }
        //чи має покупець знижку
        public bool IfProductHasDiscount(int prodID)
        {
            return productDiscounts.ContainsKey(prodID);
        }
    }
    #endregion
}
