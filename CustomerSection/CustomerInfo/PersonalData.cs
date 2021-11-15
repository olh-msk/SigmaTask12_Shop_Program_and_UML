﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class PersonalData
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        public string PnoneNumber { get; set; }

        public double Money { get; set; }
        public Address Address { get; set; }

        public PersonalData()
        {
            this.Name = "N/A";
            this.Password = "N/A";
            this.Age = 0;
            this.PnoneNumber = "N/A";
            this.Money = 0;
            this.Address = new Address();
        }

        //перервірка логіну і паролю
        //true, якщо співпадає
        public bool CheckForLogin(string name, string password)
        {
            bool res = false;
            if(this.Name == name && this.Password == password)
            {
                res = true;
            }    
            return res;
        }

        //тут буде взаємодія з GUI для зміни персональної інформації
        public void ChangeInformation()
        {

        }
    }
}
