using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database o = new Oracle();
            Database s = new MySql();

            o.ConnectionString();
            o.Add();
            o.Delete();

            s.ConnectionString();
            s.Add();
            s.Delete();

            Console.ReadLine();
        }

        abstract class Database
        {
            public abstract void ConnectionString();


            public void Add()
            {
                Console.WriteLine("default ADD");
            }
            public void Delete()
            {
                Console.WriteLine("default DELETE");
            }

        }


        class Oracle : Database
        {
            public override void ConnectionString()
            {
                Console.WriteLine("Oracle ConnectionString");
            }
        }


        class MySql : Database
        {
            public override void ConnectionString()
            {
                Console.WriteLine("MySql ConnectionString");
            }
        }


    }
}
