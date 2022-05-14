using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "selcuk",
                LastName = "basak",
                Age = 52
            };

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);


            Console.ReadLine();
        }
    }

    [ToTable("Customer")]
    [ToTable("tblCustomer")]
    class Customer
    {
        [RequiredProperty]
        public int Id { get; set; }

        [RequiredProperty]
        public string FirstName { get; set; }

        [RequiredProperty]
        public string LastName { get; set; }

        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use NewAdd Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0} {1} {2} {3} Added!",
                customer.Id,
                customer.FirstName,
                customer.LastName,
                customer.Age);
        }

        public void NewAdd(Customer customer)
        {
            Console.WriteLine("{0} {1} {2} {3} Added!",
                customer.Id,
                customer.FirstName,
                customer.LastName,
                customer.Age);
        }
    }

   //  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
   // ve bu gibi uzatabiliriz 
    
    
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }


    }
}
