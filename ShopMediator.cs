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

        public bool IfProductExistInStorage()
        {
            bool res = false;
            
            return res;
        }

        public Product GetProductByID(int prodID)
        {
            Product
        }
        //треба перевірку чи не вийшло за максимальну
        //кількість продутків на складі
        //бо тоді не вийде додати
        //bool значить можна додати
        public bool CheckProductMaxAmount(int prodID)
        {
            bool res = false;
            return res;
        }

        //те саме, коли продукту немає на складі
        //ми не можемо його додати у замовлення або видалити зі складу
        //bool значить можна відняти
        public bool CheckProductMinAmount(int prodID)
        {
            bool res = false;
            return res;
        }

        //адмінстратор дадати продукт
        //якщо є вже такий продукт, то просто кількість збільшити??
        public void AdministratorAddProduct(int storageNum, Product prod)
        {

        }
        public void AdministratorRemoveProduct(int storageNum, int prodID)
        {

        }

    }
    #endregion
}
