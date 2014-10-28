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
            var intValues = stringValues.Select(int.Parse);

            return intValues.Sum();
        }
    }
}
