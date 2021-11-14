using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    interface IPerationAddRemoveProduct
    {

    }
    interface IOperationChangeCustomerStatus
    {
        public bool ChangeCustomerStatus(int custID, UserStatus status);
    }

    abstract class Employee
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Employee()
        {
            this.Name = "N/A";
            this.PhoneNumber = "N/A";
        }
    }

    class Administrator: Employee, IOperationChangeCustomerStatus
    {
        //відповідає за id
        private static int administratorNextUniqueId = 1;

        public int AdministratorId { get; private set; }

        public Administrator():base()
        {
            this.AdministratorId = administratorNextUniqueId++;
        }

        //змінити статус покупця
        //послати повідомлення у медіатор і там воно обробиться-----------------
        public bool ChangeCustomerStatus(int custID, UserStatus status)
        {
            throw new NotImplementedException();
        }
    }
}
