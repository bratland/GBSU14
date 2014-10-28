using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculator;

namespace CalculatorGUI1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine("Input: ");
            var input = Console.ReadLine();
            Console.WriteLine("Resultat: " + calc.Add(input));
        }
    }
}
