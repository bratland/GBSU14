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
            //const int pageSize = 5;
            //var page = 2;
            //var fib = Fibonacci.Fib().Take(page*pageSize).Skip((page-1)*pageSize);

            //foreach (var i in fib)
            //{
            //    Console.WriteLine(i);
            //}

            var persons = new List<Person>();
            persons.Add(new Person{FirstName = "Rolf", LastName = "Rolfsson"});
            persons.Add(new Person{FirstName = "Anders", LastName = "Andersson"});

            var persons2 = persons.Select(p => new Person2{FullName = p.FirstName + " " + p.LastName});

            persons.Add(new Person{FirstName = "Olle"});
            var persons3 = persons.OrderBy(p => p.FirstName);


            var blah = persons.Where(p => p.FirstName.StartsWith("A"))
                .Where(p => p.LastName.Length > 100)
                .Where(p => !(p.Age == 10));

            
            foreach (var person in persons2)
            {
                Console.WriteLine(person.FullName);
            }

            foreach (var person in persons3.FilterByCity("göteborg").FilterByAge(10))
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();



            //Console.WriteLine("Tentan komer vara under v46 och 47!");

            //persons = persons.OrderBy(person => person.FirstName);

            //var x = persons.FirstOrDefault(p => p.FirstName.StartsWith("A"));

            //var w = from person in persons
            //    where person.FirstName.StartsWith("M")
            //    select person;


            //persons.ToList().ForEach(Print);

            //Console.WriteLine("The chosen one: " + x.FirstName);

            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person.FirstName);
            //}
        }


        private static void Print(Person obj)
        {
            Console.WriteLine(obj.FirstName);
        }

        private static IEnumerable<Person> GeneratePersons()
        {
            var result = new List<Person>();
            result.Add(new Person{ FirstName = "Anders"});
            result.Add(new Person{ FirstName = "Sebastian"});
            result.Add(new Person{ FirstName = "Mikael"});
            result.Add(new Person{ FirstName = "Åsa"});
            return result;
        }
    }
}
