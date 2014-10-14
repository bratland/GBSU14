using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceDemo2
{
    public interface IAccountRepository
    {
        IEnumerable<SavingsAccount> GetAccounts();
        BankAccount GetAccount(int id);
        void AddAccount(SavingsAccount bankAccount);


    }
}
