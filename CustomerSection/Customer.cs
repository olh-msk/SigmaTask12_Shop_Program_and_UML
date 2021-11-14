using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    abstract class Customer
    {
        //змінна для id
        private static int nextCustomertId = 1;

        public int CustomerId { get; private set; }

        public ShoppingCart ShoppingCart { get; set; }
        public PersonalData PersonalData { get; set; }

        public Customer()
        {
            CustomerId = nextCustomertId++;
            this.ShoppingCart = new ShoppingCart();
            this.PersonalData = new PersonalData();
        }

        //для заходження у систему-----------
        public bool LogIn()
        {
            bool ifSuccess = false;
            return ifSuccess;
        }
    }
}
