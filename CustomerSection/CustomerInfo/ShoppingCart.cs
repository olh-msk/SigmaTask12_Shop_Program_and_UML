using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class ShoppingCart
    {
        List<Order> customerOrders;

        public ShoppingCart()
        {
            customerOrders = new List<Order>();
        }

        //перевіряє чи є подібний заказ вже у списку
        public bool IfOredrInList(int orderID)
        {
            bool res = false;
            foreach(Order order in customerOrders)
            {
                if(order.OrderId == orderID)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }
        public void AddNewOrder(Order order)
        {
            if(!IfOredrInList(order.OrderId))
            {
                customerOrders.Add(order);
            }
        }
    }
}
