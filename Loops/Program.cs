using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //forx();
            //whilex();
            //doWhilex();
            //foreachx();





            if (primeNumber(1232))
            {
                Console.WriteLine("ASAL");
            }
            else
            {
                Console.WriteLine("ASAL DEĞİL");
            }

            Console.ReadLine();
        }

        private static bool primeNumber(int number)
        {

            if (number == 2)
            {
                return true;

            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;

                    }

                }
            }
            return true;
        }



        private static void foreachx()
        {
            string[] students = { "selim", "sevim", "sezen" };

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

        private static void doWhilex()
        {
            int r = 0;
            do // bir kere calışır
            {
                Console.WriteLine(r);
                r++;
            } while (r <= 10);
        }

        private static void whilex()
        {
            int k = 0;
            while (k <= 10)
            {
                Console.WriteLine(k);
                k++;
            }
        }


        private static void forx()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}