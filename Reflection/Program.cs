using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,5);
            //Console.WriteLine(dortIslem.Carp(3,5));
            //Console.WriteLine(dortIslem.Carp1());


            //Calışma anında Activator ile bir Instance oluşturduk
            var tip = typeof(DortIslem);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip, 3,5);
            //Console.WriteLine(dortIslem.Carp(3,5));
            //Console.WriteLine(dortIslem.Carp1());


            var instance = Activator.CreateInstance(tip, 3, 6);
            MethodInfo methodInfo = instance.GetType().GetMethod("Carp1");
            Console.WriteLine(methodInfo.Invoke(instance, null));
            Console.WriteLine("---------");
            var methods = tip.GetMethods();
            foreach(var method in methods)
            {
                Console.WriteLine("Metodun Adı: {0}", method.Name);
                foreach (var parameter in method.GetParameters())
                {
                    Console.WriteLine("{0}'nin Parametreleri: {1}", method.Name, parameter.Name);
                }


                foreach (var attribute in method.GetCustomAttributes())
                {
                    Console.WriteLine("{0}'nin Parametreleri: {1}", method.Name, attribute.GetType().Name);
                }

            }

            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }


        public int Topla1()
        {
            return _sayi1 + _sayi2;
        }

        [MetodName("Carpma")]
        public int Carp1()
        {
            return _sayi1 * _sayi2;
        }

        public class MetodNameAttribute: Attribute
        {
            public MetodNameAttribute (string name) {

            }
        }
    }
}
