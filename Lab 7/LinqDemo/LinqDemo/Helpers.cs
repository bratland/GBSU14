using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public static class Helpers
    {

        public static IEnumerable<Person> FilterByCity(this IEnumerable<Person> persons, string city)
        {
            return persons.Where(p => p.City == city);
        }
        public static IEnumerable<Person> FilterByAge(this IEnumerable<Person> persons, int age)
        {
            return persons.Where(p => p.Age == age);
        }
    }
}
