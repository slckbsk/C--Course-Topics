using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager products = new ProductManager();
            products.Add();
            products.Update();

            Customer customer = new Customer();
            Console.WriteLine(customer.Name);  // get calıştı

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "hakan";   // set calıştı
            customer2.Lastname = "taşıyan";
            customer2.Email = "hakan@mail.com";
            Console.WriteLine(customer2.Name);  // get calıştı


            Console.ReadLine();
        }
    }


    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("EKLENDİ");
        }

        public void Update()
        {
            Console.WriteLine("DÜZENLENDİ");
        }
    }
}
