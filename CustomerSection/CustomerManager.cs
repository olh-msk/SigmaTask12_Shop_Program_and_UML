using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    interface IOperationAddRemoveCustomer
    {
        public void AddCustomer(Customer cust);
        public void RemoveCustomer(int cusID);
    }

    class CustomerManager : IOperationAddRemoveCustomer
    {
        private static CustomerManager instance;

        List<Customer> customers;

        private CustomerManager()
        {
            customers = new List<Customer>();
        }
        public static CustomerManager Instance()
        {
            if(instance == null)
            {
                instance = new CustomerManager();
            }
            return instance;
        }

        //перевіряє чи є покупець по ID
        public bool IfCustomerInList(int cusID)
        {
            bool res = false;
            foreach(Customer cust in customers)
            {
                if(cust.CustomerId == cusID)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        //перед цим ми будемо викликати чи є покупець у списку
        public Customer GetCustomerById(int cusID)
        {
            foreach(Customer cust in customers)
            {
                if(cust.CustomerId == cusID)
                {
                    return cust;
                }
            }
            return null;
        }
        //додати покупця
        public void AddCustomer(Customer cust)
        {
            this.customers.Add(cust);
        }
        //видалити покупця по ID
        public void RemoveCustomer(int cusID)
        {
            for(int i =0; i < customers.Count;i++)
            {
                if(customers[i].CustomerId == cusID)
                {
                    customers.RemoveAt(i);
                }
            }
        }
    }
}
