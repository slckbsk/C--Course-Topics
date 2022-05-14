using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OracleDatabase oracleDatabase = new OracleDatabase();
            MySqlDatabase mySqlDatabase = new MySqlDatabase();

            oracleDatabase.Add();
            mySqlDatabase.Add();    
            Console.ReadLine();

        }

        class Database
        {

          public virtual void Add()
            {
                Console.WriteLine("default ADD");
            }
            public void Delete()
            {
                Console.WriteLine("default DELETE");
            }
        }



        class OracleDatabase: Database
        {
            public override void Add()
            {
                Console.WriteLine("OracleDatabase ADD");
                base.Add();
            }
        }

        class MySqlDatabase : Database
        {

        }



    }
}
