using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class Product
    {

        public Product()  // getlist
        {
        }

        public Product(int id, string name, decimal unitPrice, int stockAmount) // Update
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            StockAmount = stockAmount;
        }

        public Product(string name, decimal unitPrice, int stockAmount)  // Add
        {
            Name = name;
            UnitPrice = unitPrice;
            StockAmount = stockAmount;
        }

        public Product(int id)  // Delete
        {
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
