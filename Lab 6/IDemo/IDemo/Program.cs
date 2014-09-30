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
            var bankAccount1 = new BankAccount(1, consoleLogger);
            bankAccount1.Balance = 100m;
            bankAccount1.Witdraw(50m);
            
            var fileLogger = new FileLogger();
            var bankAccount2 = new BankAccount(2, fileLogger);
            bankAccount2.Balance = 100m;
            bankAccount2.Witdraw(50m);

            var loggers = new List<ILogger>();
            loggers.Add(fileLogger);
            loggers.Add(consoleLogger);

            var accounts = new List<BankAccount>();
            accounts.Add(bankAccount1);
            accounts.Add(bankAccount2);

            Console.WriteLine("\nLista");
            foreach (var account in accounts)
            {
                Console.WriteLine(account.Balance);
            }

            var accountDictionary = new Dictionary<int, BankAccount>();

            accountDictionary.Add(bankAccount1.AccountId, bankAccount1);
            accountDictionary.Add(bankAccount2.AccountId, bankAccount2);

            Console.WriteLine("\nDictionary");
            foreach (var item in accountDictionary)
            {
                Console.WriteLine("Key: " + item.Key + " value: " + item.Value.Balance);
            }

            Console.WriteLine(accountDictionary[1].Balance);
            Console.ReadLine();

        }

        public class Raion
        { }
    }
}
