using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate1();
    public delegate void MyDelegate2(string message);
    public delegate int MyDelegate3(int sayi1, int sayi2);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendAlert();
            //customerManager.SendMessage();

            MyDelegate1 myDelegate1 = customerManager.SendMessage1;  
            myDelegate1 += customerManager.SendAlert1;
            myDelegate1 -= customerManager.SendAlert1;
            

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
         //   myDelegate2 += customerManager.SendAlert2;

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Carp;
         //   myDelegate3 += matematik.Carp;

            myDelegate1();
            myDelegate2("gelirsem görürüsün");
            Console.WriteLine(myDelegate3(3, 4));
            Console.ReadLine();
        }
    }


    public class CustomerManager
    {
        public void SendMessage1()
        {
            Console.WriteLine("Hello");
        }

        public void SendAlert1()
        {
            Console.WriteLine("Aman Dikkat!!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void SendAlert2(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Matematik
    {

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;   
        }
    }
}
