using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string city = "ANKARA";
            string city2 = "İSTANBUL";

            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(city2 + "-" + city);

            Console.WriteLine(String.Format("{0}{1}", city, city2));   // bellekte tekrar tanımlamıyor 


            string cumle = "ALİ OKULA GİT";
            var result = cumle.Length;
            var result2 = cumle.Clone();
            bool result3 = cumle.EndsWith("T");
            bool result4 = cumle.StartsWith("A");
            var result5 = cumle.IndexOf("İ");
            var result6 = cumle.LastIndexOf("İ");
            var result7 = cumle.Insert(0, "HEY ");
            var result8 = cumle.Substring(0, 8);
            var result9 = cumle.Substring(4, 9);
            var result10 = cumle.ToLower();
            var result11 = cumle.ToUpper();
            var result12 = cumle.Replace("OKULA", "EVE");
            var result13 = cumle.Remove(9);
            var result14 = cumle.Remove(5,2);


            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.WriteLine(result14);
            Console.ReadLine();

        }
    }
}
