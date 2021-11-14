using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    interface IOperationAdministratorAddRemoveProduct
    {
        public void AddProduct(int storageType,Product prod);
        public void RemoveProduct(int storageType, int prodID);
    }
    interface IOperationChangeCustomerStatus
    {
        public void ChangeCustomerStatus(int custID, UserStatus status);
    }


    class Administrator: Employee, IOperationChangeCustomerStatus, IOperationAdministratorAddRemoveProduct
    {
        //відповідає за id
        private static int administratorNextUniqueId = 1;

        public int AdministratorId { get; private set; }

        public Administrator():base()
        {
            this.AdministratorId = administratorNextUniqueId++;
        }

        //послати повідомлення у медіатор і там воно обробиться-----------------

        //змінити статус покупця
        public void ChangeCustomerStatus(int custID, UserStatus status)
        {
            ShopMediator.Instance().AdministratorChangeCustomerStatus(custID,status);
        }
        //додати продукт у сховище, тип сховища визначається цифрою
        // 1 - М'ясний, 2- Молочний, 3- Предмети для дому
        //Краща логіка добавлання продуктів буду у наступних версіях програми
        public void AddProduct(int storageType, Product prod)
        {
            ShopMediator.Instance().AdministratorAddProduct(storageType,prod);
        }

        //Видалити продукт
        public void RemoveProduct(int storageType, int prodID)
        {
            ShopMediator.Instance().AdministratorRemoveProduct(storageType,prodID);
        }
    }
}
