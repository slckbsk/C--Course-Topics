using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    public class MySqlDatabaseDal : IDatabaseDal
    {

        public void Read()
        {
            Console.WriteLine("MySql Database'den okundu");
        }

        public void Add()
        {
            Console.WriteLine("MySql Database eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Database'den silindi"); ;
        }

        public void Update()
        {
            Console.WriteLine("MySql Database düzeltildi"); ;
        }
    }
}
