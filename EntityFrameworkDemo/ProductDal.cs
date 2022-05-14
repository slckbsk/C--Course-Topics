using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    internal class ProductDal
    {
        public List<Product> GetAll() {
            using (ETradeContext context = new ETradeContext())
            {
               return context.Products.ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(
                   p => p.UnitPrice >=min && p.UnitPrice <= max).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(
                   p => p.UnitPrice >= price).ToList();
            }
        }

        public List<Product> SearchAll(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(
                   p => p.Name.Contains(key)
                || p.StockAmount.ToString().Contains(key)
                || p.UnitPrice.ToString().Contains(key)).ToList();
            }
        }

        public List<Product> GetById (string id)
        {
            using (ETradeContext context = new ETradeContext())
            {
             return context.Products.Where(p => p.Id.ToString().Contains(id)).ToList();
            }
        }

        public Product GetByIdx(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.FirstOrDefault(p => p.Id == id);
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //  context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
            
        }


        public void Update (Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete (Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
