using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = GeneratePersons().ToList();

            persons = persons.OrderBy(person => person.Name);

            var x = persons.FirstOrDefault(p => p.Name);

            Console.WriteLine("The chosen one: " + x.Name);

            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
        }

        private static IEnumerable<Person> GeneratePersons()
        {
            var result = new List<Person>();
            result.Add(new Person{ Name = "Anders"});
            result.Add(new Person{ Name = "Sebastian"});
            result.Add(new Person{ Name = "Mikael"});
            result.Add(new Person{ Name = "Åsa"});
            return result;
        }
    }
}
