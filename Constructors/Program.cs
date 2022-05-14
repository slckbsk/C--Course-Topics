using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ProductManager databaseManager = new ProductManager(26, "thank you");
            //databaseManager.Listele();
            //Product product = new Product(2, "Lenovo", "Lenovo Y520", 10000);
            //Console.WriteLine(product._Name);


            //DatabaseManager dbManager = new DatabaseManager(new DatabaseLoger());
            //dbManager.Add();


            //PersonManager personManager = new PersonManager("how are you");
            //personManager.Add();

            SinifA.DoSomething(); // statik sınıf newlemeden çağırdık
            SinifB.DontDoBadthing(); // sınıf statik değil sınıfın içindeki method statik newleme yok
            
            
            
            Console.ReadLine();
        }

        // ------Static sınıf ve method------------------------
        
        static class SinifA
        {
            static SinifA ()// statik sınıfın static constructorü
            {

            }
            public static void DoSomething()
            {
                Console.WriteLine("birşeyler yaptım");
            }
        }

         class SinifB
        {
            public void DoGoodthing()
            {
                Console.WriteLine("iyi şeyler yaptım");
            }

            public static void DontDoBadthing()
            {
                Console.WriteLine("kötü birşeyler yapmadım");
            }
        }



        // ------Temel sınıfın yapıcı bloğu------------------------

        class BaseClass
        {
            private string _entity;
            public BaseClass(string entity)
            {
                _entity = entity;
            }

            public void Message()
            {
                Console.WriteLine("{0} message", _entity );
            }
        }


        class PersonManager : BaseClass
        {
            public PersonManager(string entity) : base(entity)
            {

            }

            public void Add()
            {
                Console.WriteLine("Added!");
                Message();
            }
        }






        // ------Constructor Enjection----------------------------------
        class DatabaseManager
        {

            public ILoger _loger;

           public DatabaseManager (ILoger loger){ // Constructor Ejection 
                _loger = loger;
            }

        public void Add()
            {
                _loger.log();
                Console.WriteLine("Müşteri Eklendi");
            }
        }

        interface ILoger
        {
            void log();
        }

        class FileLoger : ILoger
        {
            public void log()
            {
                Console.WriteLine("FileLoger calıştı");
            }
        }

        class DatabaseLoger : ILoger
        {
            public void log()
            {
                Console.WriteLine("DatabaseLoger calıştı");
            }
        }

        class SmsLoger : ILoger
        {
            public void log()
            {
                Console.WriteLine("SmsLoger calıştı");
            }
        }

        // ------------Constructor Intro-------------------------------
        class ProductManager
        {
            private int _count = 0;
            private string _message = "";
            public ProductManager(int count, string message)
            {
                _count = count;
                _message = message;
            }

            public ProductManager(int count)
            {
                _count = count;
            }

            public void Listele()
            {
                Console.WriteLine(_count + "-> items listed " + _message);
            }

        }















        class Product
        {

            public int _Id;
            public string _Name;
            public string _Descriptions;
            public int _Price;

            public Product(int id, string name, string descriptions, int price)
            {
                _Id = id;
                _Name = name;
                _Descriptions = descriptions;
                _Price = price;
            }


            public int Id { get; set; }
            public string Name { get; set; }
            public string Descriptions { get; set; }
            public int Price { get; set; }

        }


    }
}
