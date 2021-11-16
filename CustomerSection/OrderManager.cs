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

        public void AddNewCustomerOrder(int cusID, bool ifSelf)
        {
            if(IfHasCustomerOrders(cusID))
            {
                customerOrders[cusID].Add(new Order());
                customerOrders[cusID][0].s
            }
            else
            {
                customerOrders[cusID] = 
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
        public Order CreateNewOrder()
        {
            return new Order();
        }
    }
    #endregion
}
