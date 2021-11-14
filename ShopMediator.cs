using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    #region [Shop Mediator]
    //відповідає за виклики функцій і зв'язки між різними класами
    class ShopMediator
    {
        private static ShopMediator instance;

        private ShopMediator()
        {

        }
        public static ShopMediator Instance()
        {
            if (instance == null)
            {
                instance = new ShopMediator();
            }
            return instance;
        }

        //реалізація методу зміни статусу покупця адміністратором
        public void AdministratorChangeCustomerStatus(int cusID, UserStatus status)
        {

        }
        //адмінстратор дадати продукт
        public void AdministratorAddProduct(int storageNum, Product prod)
        {

        }
        public void AdministratorRemoveProduct(int storageNum, int prodID)
        {

        }

    }
    #endregion
}
