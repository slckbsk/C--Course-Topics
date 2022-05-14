using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> list = utilities.BuildList<string>("adana", "tokat", "mersin");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");



            List<Customer> Customerlist = utilities.BuildList<Customer>(new Customer { Name = "hakan" }, new Customer { Name = "makan" });

            foreach (var item in Customerlist)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("---------");

            //string a = new string('A', 6666);
            //Console.WriteLine(a);

            Console.ReadLine();
        }
    }
    public class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product
    {
    }

    interface IProductDal : IRepository<Product>
    {
        //List<Product> GetAll();
        //Product Get(int id);
        //void Add(Product product);
        //void Update(Product product);
        //void Delete(Product product);
    }


    class Customer
    {

        public string Name { get; set; }
    }


    interface ICustomerDal : IRepository<Customer>
    {
        //List<Customer> GetAll();
        //Product Get(int id);
        //void Add(Customer customer);
        //void Update(Customer customer);
        //void Delete(Customer customer);
    }

    class Student : IEntity
    {
    }

    interface IStudentDal : IRepository<Student>
    {
    }

    interface IEntity
    {
    }

    // BİRE BİR AYNI OLDUĞU İÇİN GENERİC OLUŞTURDUK
    interface IRepository<T> // KISTLAR where T : class, IEntity, new() ,,, T:struct ise sadece değer tipleri
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }



    class Deneme1 : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    class Deneme2 : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

}
