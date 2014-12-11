using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string expression)
        {
            if (expression == "")
                return 0;

            var stringValues = expression.Split(',');
            stringValues.Where(v => 
                (new[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}).Contains(v));
            if (stringValues.Any(v => v.StartsWith("1")))
            {
                
            }



            var intValues = stringValues.Select(int.Parse);
            var fel = intValues.Where(x => x > 0).Where(x => x < 10);
            //var rätt = intValues.First(x => x > 0);
            //Func<string, int> minMetod = int.Parse;
            //Func<string, int> minMetod2 = n => 5;
            //Func<string, int> minMetod3 = n => int.Parse(n);
            //Func<string, int> minMetod4 = DoStuff;




            return intValues.Sum();
        }

        private int DoStuff(string s)
        {
            return int.Parse(s);
        }
    }
}
