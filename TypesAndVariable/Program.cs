using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VALUE TYPES DEĞER TİPLERİ
            int sayi1 = -2147483647;
            long sayi2 = -9223372036854775807;
            short sayi3 = -32767;
            byte sayi4 = 255; // -255 değil 0-255
            double sayi5 = 10.4;  // 64 bit
            decimal sayi6 = 10.4m;
            bool dogru = true;
            char character = 'A';

            var number = 10; // ilk tanımda iny yaptık artık hep int
            number = 'A'; // A nın ASCII değeri yani int algılayacak
            // number = "A"; -> hata verecek çünkü string verdik
         

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi3);
            Console.WriteLine(sayi4);
            Console.WriteLine(sayi5);
            Console.WriteLine(sayi6);
            Console.WriteLine(dogru);
            Console.WriteLine(character);
            Console.WriteLine((int)character); // ASCII değeri
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Monday);
            Console.WriteLine(number); // ASCII değerini verecek

            Console.ReadLine();


        }

        enum Days { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    }
}
