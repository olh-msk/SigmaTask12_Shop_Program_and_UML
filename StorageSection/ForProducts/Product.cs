﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    abstract class Product
    {
        //змінна для id
        private static int nextProductId = 1;
        public int ProductId { get; private set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Weight { get; set; }

        public int Amount { get; set; }

        public DateTime ExpirationDate { get; set; }

        //юудемо ініціалізовувати через нащадків
        public Product()
        {
            this.ProductId = nextProductId++;
            this.Name = "N/A";
            this.Price = 0;
            this.Weight = 0;
            this.Amount = 0;
            this.ExpirationDate = DateTime.Now;
        }
    }
}
