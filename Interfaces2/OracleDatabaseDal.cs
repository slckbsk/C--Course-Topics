using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    public class OracleDatabaseDal : IDatabaseDal
    {

        public void Read()
        {
            Console.WriteLine("Oracle Database'den okundu");
        }

        public void Add()
        {
            Console.WriteLine("Oracle Database eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Database'den silindi"); ;
        }

        public void Update()
        {
            Console.WriteLine("Oracle Database düzeltildi"); ;
        }
    }
}
