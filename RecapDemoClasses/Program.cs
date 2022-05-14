using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DatabaseManager dbManager = new DatabaseManager();
            //   dbManager.Add(new SmsLoger()); // benim yaptığım PARAMETRE

            dbManager.loger = new SmsLoger(); // propetries injection
            dbManager.Add();
            Console.ReadLine(); 
        }



        class DatabaseManager
        {
            // benim yaptığım PARAMETRE
            //public ILoger Loger { get; set; }
            //public void Add(ILoger loger)
            //{
            //    this.Loger = loger;
            //    loger.log();
            //    Console.WriteLine("Müşteri Eklendi");
            //}


            public ILoger loger { get; set; } // propetries injection
            public void Add()
            {
                loger.log();
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
    }
}
