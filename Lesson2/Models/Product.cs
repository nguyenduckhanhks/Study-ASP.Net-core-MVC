﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson2.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; } = 0;
        public Product Related { get; set; }

        public static Product[] GetProducts()
        {
            Product kayak = new Product { Name = "Kayak", Price = 275M };
            Product lifeJacket = new Product { Name = "LifeJacket", Price = 48.95M };

            kayak.Related = lifeJacket;

            return new Product[] { kayak, lifeJacket, null };
        }
    }
}
