using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMedArv
{
    public class AccountFactory
    {
        public static BankAccount[] Create()
        {
            BankAccount account2 = new SavingsAccount();
            account2.Deposit(100);
            BankAccount account4 = new SavingsAccount();
            account4.Deposit(100);
            BankAccount account5 = new SavingsAccount();
            account5.Deposit(100);

            SavingsAccount.Interest = 0.12m;

            BankAccount account3 = new CheckingAccount();
            account3.Deposit(100);

            return new []{account2, account3, account4, account5};
        }
    }
}
