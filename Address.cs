﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Zipcode { get; set; }

        public Address()
        {
            Street = "N/A";
            City = "N/A";
            Country = "N/A";
            Zipcode = 0;
        }
    }
}
