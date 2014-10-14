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
            var fib = Fibonacci.Fib().Take(10);

            foreach (var i in fib)
            {
                Console.WriteLine(i);
            }

            //var persons = GeneratePersons();

            //Console.WriteLine("Tentan komer vara under v46 och 47!");

            //persons = persons.OrderBy(person => person.Name);

            //var x = persons.FirstOrDefault(p => p.Name.StartsWith("A"));

            //var w = from person in persons
            //    where person.Name.StartsWith("M")
            //    select person;


            //persons.ToList().ForEach(Print);

            //Console.WriteLine("The chosen one: " + x.Name);

            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person.Name);
            //}
        }

        private static void Print(Person obj)
        {
            Console.WriteLine(obj.Name);
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
