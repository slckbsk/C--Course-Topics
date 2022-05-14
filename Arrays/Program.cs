using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] students = new string[3];

            //students[0] = "selim";
            //students[1] = "sevim";
            //students[2] = "sezen";

            //string[] students1 = new string[3] { "selim", "sevim", "sezen" };
            //string[] students2 = { "selim", "sevim", "sezen" };


            //foreach (var isim in students2)
            //{
            //    Console.WriteLine(isim);

            //}


            string[,] regions = new string[7, 3]
            {
                {"istanbul","canakkale","balıkesir" },
                {"izmir","muğla","manisa" },
                {"antalya","mersin","adana" },
                {"urfa","antep","mardin" },
                {"ankara","konya","kırıkkale" },
                {"elazıg","tuncelli","bingöl" },
                {"ordu","sinop","rize" }

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine((i + 1) + ". BÖLGE" );

                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }

            }

            Console.ReadLine(); 

        }
    }
}
