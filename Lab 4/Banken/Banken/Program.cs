using System;
using Banken.Public;
using Banken.Admin;
using AccountTypes;

namespace Banken
{
    class Program
    {
        static void Main(string[] args)
        {
            var user2 = new Public.User();
            var manager = new ManageBank();
            var account = new Account("Anders");
            account.Deposit(100m);
            Console.WriteLine(account.Balance);

            account.Withdraw(50m);
            Console.WriteLine(account.Balance);
            
            account.Withdraw(-1000m);
            Console.WriteLine(account.Balance);

            Console.WriteLine(account);
        }
    }

    
}
