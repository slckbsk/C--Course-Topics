using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------
            //try

            //{
            // Find();

            //}catch (RecordNotFoundExceptions ex)
            //{
            //    Console.WriteLine(ex.Message);  
            //}
            //Console.WriteLine("---------");


            //HandleExpaction(() => {
            //    Find();

            //});
            //---------------


            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,5));

            Func<int> getRandomNum1 = delegate()
            {
                Random random = new Random();
                return random.Next(10, 100);
            };

            Func<int> getRandomNum2 = () => new Random().Next(10, 100);   

            Console.WriteLine(getRandomNum1());
            Thread.Sleep(100);
            Console.WriteLine(getRandomNum2());
            Console.ReadLine();
        }

        static int Topla (int a, int b)
        {
            return a + b;
        }

        private static void HandleExpaction(Action action)
        {
            try
            {
                action.Invoke();
            }catch(RecordNotFoundExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Find()
        {
            List<string> list = new List<string> {"hakan", "bakan", "satan"};
            string isim = "hakanxx";



            if (!list.Contains(isim))
            {
                throw new RecordNotFoundExceptions("listede yok");

            }
            else
            {
                Console.WriteLine("{0} listede var", isim);
            }
        }
    }
}
