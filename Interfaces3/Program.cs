using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWork[] workers = new IWork[]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };

            foreach (var workx in workers)
            {
                workx.work();
            }


            ISalary[] salaries = new ISalary[]
             {
                new Worker(),
                new Manager()
             };

            foreach (var salaryx in salaries)
            {
                salaryx.getSalary();
            }

            IEat[] eats = new IEat[]
             {
                new Worker(),
                new Manager()
             };

            foreach (var eatx in eats)
            {
                eatx.eat();
            }

            Console.ReadLine();


        }

        interface IWork
        {
            void work();
        }

        interface IEat
        {
            void eat();
        }

        interface ISalary
        {
            void getSalary();
        }



        class Manager : IWork, ISalary, IEat
        {
            public void eat()
            {
                Console.WriteLine("Manager-Yedim");
            }

            public void getSalary()
            {
                Console.WriteLine("Manager-Para Aldım");
            }

            public void work()
            {
                Console.WriteLine("Manager-Çalıştım");
            }
        }

        class Worker : IWork, ISalary, IEat
        {
            public void eat()
            {
                Console.WriteLine("Worker-Yedim");
            }

            public void getSalary()
            {
                Console.WriteLine("Worker-Para Aldım");
            }

            public void work()
            {
                Console.WriteLine("Worker-Çalıştım");
            }
        }

        class Robot : IWork
        {
            public void work()
            {
                Console.WriteLine("Robot-Çalıştım");
            }
        }
    }
}
