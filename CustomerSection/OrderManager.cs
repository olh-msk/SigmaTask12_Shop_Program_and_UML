using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    #region [Order Manager]
    class OrderManager
    {
        private static OrderManager instance;

        //має id замовника і його замовлення
        Dictionary<int, List<Order>> customerOrders;

        private OrderManager()
        {
            customerOrders = new Dictionary<int, List<Order>>();
        }

        public static OrderManager Instance()
        {
            if(instance == null)
            {
                instance = new OrderManager();
            }
            return instance;
        }

        public void AddNewCustomerOrder(int cusID, Order order)
        {
            //просто добавити
            if(IfHasCustomerOrders(cusID))
            {
                customerOrders[cusID].Add(order);
            }
            //якщо такого замовлення ще не було, то ініціалізувати
            //список і добавити
            else
            {
                customerOrders[cusID] = new List<Order>();
                customerOrders[cusID].Add(order);
            }
        }

        public bool IfHasCustomerOrders(int cusID)
        {
            return customerOrders.ContainsKey(cusID);
        }

        //перевіряє чи існує таке замовлення
        //по вказаному ід
        public bool IfHasOrder(int orderID)
        {
            bool res = false;
            foreach(KeyValuePair<int, List<Order>> pair in customerOrders)
            {
                foreach(Order order in pair.Value)
                {
                    if(order.OrderId == orderID)
                    {
                        res = true;
                    }
                }
            }
            return res;
        }

        //отримати контректне замовлення по ід
        public Order GetOrderById(int orderID)
        {
            Order ord = null;
            foreach (KeyValuePair<int, List<Order>> pair in customerOrders)
            {
                foreach (Order order in pair.Value)
                {
                    if (order.OrderId == orderID)
                    {
                        return order;
                    }
                }
            }
            return ord;
        }
        //отримати всі замовлення покупця
        //перед ним має бути перевірка на те, чи існує ключ
        public List<Order> GetCustomerOrdersById(int cusID)
        {
            return customerOrders[cusID];
        }

        //Тут має бути взаємодія з GUI, щоб уточнити інформацію про
        //покупку, буде реалізовно у майбітніх версіях
        public Order CreateNewOrder(Dictionary<int,int> productsInCart)
        {
            return new Order();
        }
    }
    #endregion
}
