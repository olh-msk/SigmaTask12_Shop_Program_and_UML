using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    #region [For Customer Order]
    enum OrderSatus { New, InProcess, InRoad, Delivered, Canceled}
    
    interface IOperationOrderAddRemoveProduct
    {
        public void AddProduct(int prodID);
        public void Removeproduct(int prodID);
    }
    class Order: IOperationOrderAddRemoveProduct
    {
        //відповідає за id створенних 
        private static int orderNextUniqueId = 1;

        //записуються ID замовлених продуктів
        List<int> orderedProducts;

        public int OrderId { get; private set; }

        public DateTime orderDate { get; set; }

        public bool SelfDelivery { get; set; }

        public OrderSatus OrderSatus { get; set; }


        public Order()
        {
            this.OrderId = orderNextUniqueId++;

            this.orderDate = DateTime.Now;

            this.SelfDelivery = false;

            this.OrderSatus = OrderSatus.New;

            this.orderedProducts = new List<int>();
        }

        //тут у майбутньому можна реалізувати відрахування коштів покупцю
        //замовлені продукти
        public void CancelOrder()
        {
            this.OrderSatus = OrderSatus.Canceled;
        }

        public void UpdateOrderStatus(OrderSatus stat)
        {
            this.OrderSatus = stat;
        }

        public double GetTotalProductPrice()
        {
            double allPrice = 0;
            foreach(int prodID in orderedProducts)
            {

            }
            return allPrice;
        }
        //додати продукт у корзину
        //передаємо сигнал медіатору
        public void AddProduct(int prodID)
        {
            // Якщо ще є продукти на складі
            if(ShopMediator.Instance().CheckProductMinAmount(prodID))
            {
                orderedProducts.Add(prodID);

            }
        }

        //видалити зі замовлення продукт
        public void Removeproduct(int prodID)
        {
            //якщо нема місця на складі, то буде наднормаю
            //у майбутньому можна реалізувати знижку на цей продукт
            //щоб покупець передумав його викидати
            
        }
    }
    #endregion
}
