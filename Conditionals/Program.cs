using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var number = 11;

            Console.WriteLine(number == 10 ? "Doğru" : "Yanlış");


            switch (number)
            {
                case 10:
                    Console.WriteLine("Doğru");
                    break;
                case 20:
                    Console.WriteLine("Yanlış");
                    break;
                default:
                    Console.WriteLine("Hiçbiri değil");
                    break;
            }





            Console.ReadLine();
        }


    }
}
