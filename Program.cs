

using EvTapsirigi26082025.Models;

namespace EvTapsirigi26082025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Name = "Kamil", Surname = "Mahmudov", Age = 21 });
            people.Add(new Person { Name = "Ehmed", Surname = "Ehmedov", Age = 19 });
            people.Add(new Person { Name = "Besti", Surname = "Abbasova", Age = 26 });

            var item = people.FindAll(p => p.Name == "Kamil");
            Console.WriteLine("Kamil Adi Olanlar");
            foreach (var person in item)
            {
                Console.WriteLine($"{person.Name},{person.Surname},{person.Age}");
            }

            var value = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));
            Console.WriteLine("\nSoyadi Ov-Ova ile Bitenler");
            foreach (var person in value)
            {
                Console.WriteLine($"{person.Name},{person.Surname},{person.Age}");
            }


            var a = people.FindAll(p => p.Age >= 20);
            Console.WriteLine("\nYasi 20+ Olanlar");
            foreach (var person in a)
            {
                Console.WriteLine($"{person.Name},{person.Surname},{person.Age}");
            }
        }   
    }
}
