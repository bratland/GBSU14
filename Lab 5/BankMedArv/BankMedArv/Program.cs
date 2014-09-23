using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMedArv
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount account = new BankAccount();
            //account.Deposit(100);
            var accounts = AccountFactory.Create();


            foreach (var bankAccount in accounts)
            {
                DisplayAccountInformation(bankAccount);
            }

            Console.ReadLine();

        }

        private static void DisplayAccountInformation(BankAccount account)
        {
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.CalculateInterest());
            Console.WriteLine(account);
            Console.WriteLine();
        }
    }
}
