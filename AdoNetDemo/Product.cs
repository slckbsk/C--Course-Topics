using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class Product
    {
       

        public Product(string name, string unitPrice, int stockAmount)
        {
            Name = name;
            UnitPrice = unitPrice;
            StockAmount = stockAmount;
        }

        public Product(int id, string name, string unitPrice, int stockAmount)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            StockAmount = stockAmount;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
