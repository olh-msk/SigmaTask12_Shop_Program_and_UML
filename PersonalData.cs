using System;
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
            Name = "N/A";
            Password = "N/A";
            Age = 0;
            PnoneNumber = "N/A";
            Money = 0;
            Address = new Address();
        }
    }
}
