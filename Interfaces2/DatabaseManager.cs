using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class DatabaseManager
    {
        public void Add(IDatabaseDal databaseDal)
        {
            databaseDal.Add();
        }

        public void Delete(IDatabaseDal databaseDal)
        {
            databaseDal.Delete();
        }

        public void Read(IDatabaseDal databaseDal)
        {
            databaseDal.Read();
        }

        public void Update(IDatabaseDal databaseDal)
        {
            databaseDal.Update();
        }
    }
}
