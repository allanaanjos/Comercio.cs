using System;

namespace Comercio.entities
{
    internal class Product
    {
        public string Name { get; set; }
        public Double Price { get; set; }

        public Product() { }

        public Product(string name, Double price)
        {
            Name = name;
            Price = price;
        }
    }
}
