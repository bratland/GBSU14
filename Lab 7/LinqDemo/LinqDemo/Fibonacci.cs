using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Fibonacci
    {
        public static IEnumerable<int> Fib()
        {
            int counter = 0;
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);
            yield return CalcFib(counter++);

            while (true)
            {
                yield return CalcFib(counter++);
            }
        }

        public static int CalcFib(int pos)
        {
            if (pos <= 1)
                return 1;

            return CalcFib(pos - 1) + CalcFib(pos - 2);
        }
    }
}
