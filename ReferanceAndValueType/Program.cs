using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int, double, short, bool vb DEĞER tip
            int a = 10;
            int b = 20;
            b = a;
            a = 100;
            Console.WriteLine(b);


            // Array, absract sınıflar, stringler, classlar, interfaceler vb REFERANS tip
            string[] sehirler1 = new string[] {"A","B","C"};
            string[] sehirler2 = new string[] { "D", "E", "F" };

            sehirler1 = sehirler2;
            sehirler1[0] = "K";

            DataTable data; // newlemeye gerek yok zaten
            DataTable data2 = new DataTable();  
            data = data2;  // zaten data2 nin referansını verdik

            Console.WriteLine(sehirler1[0]);
            Console.ReadLine();
        }
    }
}
