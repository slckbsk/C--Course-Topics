using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(add(23, 17));
            //Console.WriteLine(add(23)); // Default parametre

            //int ax = 5; // ref değer vermez isek hata cıkaar
            //int ay;  // out değer vermesekte olur
            //int b = 2;

            //int result = add1(ax, b); // bizde ref ile fark oluşmadı
            //Console.WriteLine(result);

            //Console.WriteLine(sum(ref ax, b));
            //Console.WriteLine(sum1(out ay, b));


            //Console.WriteLine(multiply(2,3));
            //Console.WriteLine(multiply(2,3,4));


            Console.WriteLine(add2(1, 2, 3, 4, 5)); // paramsdan dolayı aynı tipten istediğin kadar parametre gönderebiliriz

            Console.ReadLine();
        }

        //static int add(int a, int b = 27) // Default parametre
        //{
        //    return a + b;
        //}

        //static int add1(int ax, int b)
        //{
        //    ax = 20;  // a nın yeni değeri
        //    return ax + b;
        //}

        //static int sum(ref int ax, int b)
        //{
        //    ax = 20;  // a nın yeni değeri
        //    return ax + b;
        //}

        //static int sum1(out int ax, int b)
        //{
        //    ax = 20;  // a nın yeni değeri
        //    return ax + b;
        //}

        static int multiply(int a, int b)
        {
            return a * b;
        }

        static int multiply(int a, int b, int c)  // aynı isimde ki metodu 3 parametreli yaparak overload ettik
        {
            return a * b * c;
        }


        static int add2(params int[] numbers) // params 
        {
            return numbers.Sum();
        }

        static int add2(int a, params int[] numbers) // params 
        {
            return numbers.Sum();
        }


    }
}
