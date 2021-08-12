using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk_Cookie_H3.Models
{
    // This class represents Product!
    public class Product
    {
        // Create auto implemented properties with get and set accesor!
        public string Name { get; set; }
        public double Price { get; set; }

        // Constructor declaration with parameters!
        public Product(string name, double price)
        {
            // Initialization!
            Name = name;
            Price = price;
        }
    }
}
