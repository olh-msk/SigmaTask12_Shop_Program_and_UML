using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    #region [Moderator]
    interface IOperationModeratorGetCustomerOrderList
    {
        public void GetCustomerOrders();
    }
    class Moderator : Employee
    {
        //відповідає за id створенних модераторів
        private static int moderatorNextUniqueId = 1;

        public int ModeratorId { get; private set; }

        public Moderator():base()
        {
            this.ModeratorId = moderatorNextUniqueId++;
        }


    }
    #endregion
}
