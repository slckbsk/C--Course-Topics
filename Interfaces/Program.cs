using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // InterfaceInfo();



            Console.ReadLine();
        }



        public static void InterfaceInfo()
        {

            PersonManager personManager = new PersonManager();
            Teachers teachers = new Teachers()
            {
                Id = 1,
                FirstName = "selcuk",
                LastName = "basak",
                Address = "HATAY"
            };

            Students students = new Students()
            {
                Id = 1,
                FirstName = "ömer",
                LastName = "basak",
                Email = "ömer@mail.com"
            };

            personManager.Add(teachers);
            personManager.Add(students);

        }

        interface IPeron // SOYUTTUR NEW lenemez
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Teachers : IPeron // somuttur soyut sınıftan türemiştir
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }  // ektra ekledik
        }

        class Students : IPeron
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Email { get; set; }  // ektra ekledik
        }


        class PersonManager
        {
            public void Add(IPeron p)
            {
                Console.WriteLine(p.FirstName);
            }
        }

    }
}
