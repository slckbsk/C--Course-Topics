using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    interface IDatabaseDal
    {
        void Read();
        void Add();
        void Update();
        void Delete();
    }
}
