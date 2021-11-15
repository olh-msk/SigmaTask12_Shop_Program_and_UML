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
    interface IOperationModeratorCreateDiscounts
    {
        public void CreateCustomerDiscount(int cusID);
        public void CreateProductDiscount(int prodID);
    }
    class Moderator : Employee, IOperationModeratorCreateDiscounts
    {
        //відповідає за id створенних модераторів
        private static int moderatorNextUniqueId = 1;

        public int ModeratorId { get; private set; }

        public Moderator():base()
        {
            this.ModeratorId = moderatorNextUniqueId++;
        }
        //створити знижки передаємо на посередника
        public void CreateCustomerDiscount(int cusID)
        {
            ShopMediator.Instance().ModeratorAddNewCustomerDiscount(cusID);
        }

        public void CreateProductDiscount(int prodID)
        {
            ShopMediator.Instance().ModeratorAddNewProductDiscount(prodID);
        }
    }
    #endregion
}
