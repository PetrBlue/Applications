﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obchudek2
{
    public class Product
    {
        public string name;
        public float price;
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
