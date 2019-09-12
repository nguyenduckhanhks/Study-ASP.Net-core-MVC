using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson3.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public static IEnumerable<Product> GetProducts()
        {
            List<Product> a = new List<Product> { new Product { Name = "1", Price = 100M } };
            return a;
        }

    }
}
