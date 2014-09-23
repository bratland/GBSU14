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

            BankAccount account2 = new SavingsAccount();
            account2.Deposit(100);

            BankAccount account3 = new CheckingAccount();
            account3.Deposit(100);

            //DisplayAccountInformation(account);
            DisplayAccountInformation(account2);
            DisplayAccountInformation(account3);

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
