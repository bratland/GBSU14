using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public string PNummer { get; set; }
        public string City { get; set; }
    }
    
    class Person2
    {
        public string FullName { get; set; }

        public string PNummer { get; set; }
    }
}
