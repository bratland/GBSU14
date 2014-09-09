using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Fib(i));
            }
        }

        private static int Fib(int pos)
        {
            if (pos <= 1)
                return 1;

            return Fib(pos - 1) + Fib(pos - 2);
        }
    }
}
