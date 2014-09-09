using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var expr = "2+5";
            var expr1 = "2+5*10-6/3";
            var expr2 = "5*10";
            var expr3 = "2+5*10+1";

            Console.WriteLine(expr +  " = " + EvalExpr(expr));
            Console.WriteLine(expr1 + " = " + EvalExpr(expr1));
            Console.WriteLine(expr2 + " = " + EvalExpr(expr2));
            Console.WriteLine(expr3 + " = " + EvalExpr(expr3));
        }

        private static int EvalExpr(string expr)
        {
            int result = 0;
            if (expr.Contains('+'))
            {
                var expressions = expr.Split(new[] { '+' }, 2);
                result = EvalExpr(expressions[0]) + EvalExpr(expressions[1]);
            }
            else if (expr.Contains('-'))
            {
                var expressions = expr.Split(new []{'-'},2);
                result = EvalExpr(expressions[0])- EvalExpr(expressions[1]);
            }
            else if (expr.Contains('*'))
            {
                var expressions = expr.Split(new[] { '*' }, 2);
                result = EvalExpr(expressions[0]) * EvalExpr(expressions[1]);

            } else if (expr.Contains('/'))
            {
                var expressions = expr.Split(new[] { '/' }, 2);
                result = EvalExpr(expressions[0]) / EvalExpr(expressions[1]);
            }
            else
            {
                result = int.Parse(expr);
            }

            return result;
        }
    }
}
