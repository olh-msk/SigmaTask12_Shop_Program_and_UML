using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    #region [Shopping Cart]
    class ShoppingCart
    {
        //має продукт і його кількість
        Dictionary<int, int> productsInCart;

        public ShoppingCart()
        {
            productsInCart = new Dictionary<int, int>();
        }

        //додати продукт у корзину на вказану кількість, виклик 
        //буде оброблятись у медіаторі
        public void AddProductToCart(int prodID, int amount = 1)
        {
            for(int i =0; i<amount;i++)
            {
                //перевірка чи продукт є на складі
                if(ShopMediator.Instance().CheckProductMinAmount(prodID))
                {
                    //перерірка чи ми ще не маємо такого продутку у корзині
                    if (!IfCartHaveProduct(prodID))
                    {
                        //беремо 1 штуку
                        ShopMediator.Instance().TakeProductFromStorage(prodID);
                        productsInCart[prodID] = 1;
                    }
                    //інаше нарощуємо кількість взяти продуктів
                    else
                    {
                        ShopMediator.Instance().TakeProductFromStorage(prodID);
                        productsInCart[prodID]++;
                    }
                }
                
            }
        }
        public void RemoveProductFormCart(int prodID, int amount = 1)
        {
            for(int i =0; i< amount; i++)
            {

            }
        }

        //виклик створення замовлення переноситься на медіатор----
        public void CreateOrder(bool ifSelf)
        {

        }

        public bool IfCartHaveProduct(int prodID)
        {
            return productsInCart.ContainsKey(prodID);
        }


    }
    #endregion
}
