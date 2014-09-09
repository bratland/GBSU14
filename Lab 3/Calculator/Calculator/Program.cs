using System;
using System.Linq;

namespace Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string expr = "(2+5)*(3+7)";
            //var expr1 = "2+5*10-6/3";
            //var expr2 = "5*10";
            //var expr3 = "2+5*10+1";

            Console.WriteLine(expr + " = " + EvalExpr(expr));
            //Console.WriteLine(expr1 + " = " + EvalExpr(expr1));
            //Console.WriteLine(expr2 + " = " + EvalExpr(expr2));
            //Console.WriteLine(expr3 + " = " + EvalExpr(expr3));
            Console.ReadLine();
        }

        private static int EvalExpr(string expr)
        {
            if (expr == "") return 0;

            if (expr.Contains('('))
            {
                var expressions = SplitInTwo(expr, '(');
                return EvalExpr(expressions[0]) + InnerExpression(expressions[1]);
            }


            if (expr.Contains('+'))
            {
                var expressions = SplitInTwo(expr, '+');
                return EvalExpr(expressions[0]) + EvalExpr(expressions[1]);
            }

            if (expr.Contains('-'))
            {
                var expressions = SplitInTwo(expr, '-');
                return EvalExpr(expressions[0]) - EvalExpr(expressions[1]);
            }

            if (expr.Contains('*'))
            {
                var expressions = SplitInTwo(expr, '*');
                return EvalExpr(expressions[0])*EvalExpr(expressions[1]);
            }

            if (expr.Contains('/'))
            {
                var expressions = SplitInTwo(expr, '/');
                return EvalExpr(expressions[0])/EvalExpr(expressions[1]);
            }


            return int.Parse(expr);
        }

        private static int InnerExpression(string expr)
        {
            if (expr.Contains('('))
            {
                if (expr.IndexOf('(') < expr.IndexOf(')'))
                {
                    return EvalExpr(expr);
                }
            }

            var temp = SplitInTwo(expr, ')');
            return EvalExpr(temp[0]) + EvalExpr(temp[1]);

        }

        private static string[] SplitInTwo(string expr, char splitChar)
        {
            return expr.Split(new[] {splitChar}, 2);
        }
    }
}