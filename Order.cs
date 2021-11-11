using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    enum OrderSatus { New, InProcess, InRoad, Delivered, Canceled}
    class Order
    {
        //відповідає за id створенних 
        private static int orderNextUniqueId = 1;

        public int OrderId { get; private set; }

        public DateTime orderDate { get; set; }

        public bool SelfDelivery { get; private set; }

        

        public Order()
        {
            this.OrderId = orderNextUniqueId++;

            this.orderDate = DateTime.Now;

            this.SelfDelivery = false;
        }
    }
}
