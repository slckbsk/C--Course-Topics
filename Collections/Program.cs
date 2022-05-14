using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Listeler();

            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("A", "65");
            map.Add("B", "66");
            map.Add("C", "67");
            map.Add("D", "68");

            Console.WriteLine(map["A"]);

            foreach (var item in map)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(map.ContainsKey("A"));
            Console.WriteLine(map.ContainsKey("R"));
            Console.WriteLine(map.ContainsValue("67"));
            Console.WriteLine(map.ContainsValue("55"));

            Console.ReadLine();

        }


        public static void Listeler()
        {

            ArrayList cities = new ArrayList();
            cities.Add("Antep");
            cities.Add("Mardin");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("---------");



            List<string> sehirler = new List<string>();
            sehirler.Add("Antep");
            sehirler.Add("Mardin");

            foreach (string city in sehirler)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("---------");


            List<Cities> sehirlers = new List<Cities>();

            Cities c = new Cities(4, "türkiye", "Antalya");
            Cities d = new Cities(5, "türkiye", "Mersin");

            sehirlers.Add(new Cities(1, "türkiye", "Adana"));
            sehirlers.Add(new Cities(2, "türkiye", "Adıyaman"));
            sehirlers.Add(new Cities(3, "türkiye", "Ankara"));
            sehirlers.Add(c);
            sehirlers.Add(d);


            sehirlers.AddRange(new Cities[2]{
                new Cities(6, "türkiye", "Konya"),
                new Cities(7, "türkiye", "Hatay")
            });

            sehirlers.Add(c); // tekrar eklediğim için sondan saydı ilk yakaladığı değeri baştan sayarak verdi 
            sehirlers.Insert(6, c);

            // sehirlers.Remove(c); // sadece bulduğu ilk değeri siler
            // sehirlers.Clear(); // hepsini temizler
            // sehirlers.RemoveAll(k => k.Name == "Antalya");


            String sonuc = "";
            bool varmi = sehirlers.Contains(c);
            sonuc = (varmi) ? "var" : "yok";
            int index = sehirlers.IndexOf(c);
            int index2 = sehirlers.LastIndexOf(c);
            Console.WriteLine("{0} {1}.index", sonuc, index);
            Console.WriteLine("{0} {1}.index", sonuc, index2);

            var count = sehirlers.Count();
            Console.WriteLine("{0} Şehir var", count);


            foreach (Cities city in sehirlers)
            {
                Console.WriteLine(city.Id + " " + city.Name + " " + city.Country);
            }
            Console.WriteLine("---------");



        }



        class Cities
        {
            public Cities(int id, string country, string name)
            {
                Id = id;
                Country = country;
                Name = name;
            }

            public int Id { get; set; }
            public string Country { get; set; }
            public string Name { get; set; }

        }
    }
}
