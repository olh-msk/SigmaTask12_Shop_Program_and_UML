﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
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
}
