using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class SqlServerDatabaseDal : IDatabaseDal
    {

        public void Read()
        {
            Console.WriteLine("SqlServer Database'den okundu");
        }

        public void Add()
        {
            Console.WriteLine("SqlServer Database eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("SqlServer Database'den silindi"); ;
        }

        public void Update()
        {
            Console.WriteLine("SqlServer Database düzeltildi"); ;
        }
    }
}
