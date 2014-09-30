using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new ConsoleLogger();
            var bankAccount1 = new BankAccount(consoleLogger);
            bankAccount1.Balance = 100m;
            bankAccount1.Witdraw(50m);
            
            var fileLogger = new FileLogger();
            var bankAccount2 = new BankAccount(fileLogger);
            bankAccount2.Balance = 100m;
            bankAccount2.Witdraw(50m);

            Console.ReadLine();
        }
    }
}
