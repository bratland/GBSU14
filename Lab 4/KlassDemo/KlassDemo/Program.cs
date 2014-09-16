using System;

namespace KlassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Namn = "A";
            Console.WriteLine(person.Namn);
            person.Namn = "Anders";
            Console.WriteLine(person.Namn);
            
        }
    }

    public class Person
    {
        private string _namn;

        public string Personnummer { get; set; } // Auto-propp

        private string _personnummer;
        public string Personnummer2 // "Vanlig" propp
        {
            get { return _personnummer; }
            set { _personnummer = value; }
        }

        public string Namn
        {
            get { return _namn; }
            set
            {
                if (value.Length >= 2)
                {
                    _namn = value;
                }
            }
        }
    }
}
