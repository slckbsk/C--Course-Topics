using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[]
            {
                new Person(), 
                new Student(),
                new Teachers()
            };

            foreach (var p in person)
            {
                Console.WriteLine(p);
            }

            Person[] persons = new Person[]
             {
                new Person{FirstName = "Alice"},
                new Student{FirstName = "Alian"},
                new Teachers{FirstName = "Alfread"}
             };

            foreach (var p in persons)
            {
                Console.WriteLine(p.FirstName);
            }


            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }

        class Person2
        {
            // bunu miras alınana ekleyemeyiz, bir kişinin bir babası olur
        }

        interface IPerson
        {
            void iseBaslama();
        }

        interface IPerson2
        {
            void iseBaslama();
        }

        class Student: Person, IPerson, IPerson2
        {
            public int CourseHours { get; set; }

            public void iseBaslama()
            {
                throw new NotImplementedException();
            }
        }


        class Teachers : Person
        {
            public int Salary { get; set; }

        }




    }
}
