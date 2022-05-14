using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IDatabaseDal[] databaseDal = new IDatabaseDal[3]
            {
                new SqlServerDatabaseDal(),
                new OracleDatabaseDal(),
                new MySqlDatabaseDal()
            };


            foreach (var databasedals in databaseDal)
            {
                databasedals.Add();
            }


            //DatabaseManager databaseManager = new DatabaseManager();
            //databaseManager.Add(new OracleDatabaseDal());


        
        
        Console.ReadLine(); 
        }
    }
}
