﻿using System;
using System.Globalization;


namespace ExpressoesLambdaDelegatesLinq.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Category.Name
                + ", "
                + Category.Tier;
        }
    }
}
