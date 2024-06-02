using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class Sale
    {
        public Sale(int id, string product, decimal price)
        {
            Id = id;
            Product = product;
            Price = price;
        }
        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
    }
}