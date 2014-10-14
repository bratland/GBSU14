using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    public class FakeAccountRepository : IAccountRepository
    {
        private List<SavingsAccount> _accounts;
        public FakeAccountRepository()
        {
            _accounts = AccountFactory.Create().ToList();
        }

        public IEnumerable<SavingsAccount> GetAccounts()
        {
            return _accounts;
        }

        public BankAccount GetAccount(int id)
        {
            foreach (var bankAccount in _accounts)
            {
                if (bankAccount.Id == id)
                    return bankAccount;
            }

            return null;
        }

        public void AddAccount(SavingsAccount bankAccount)
        {
            _accounts.Add(bankAccount);
        }
    }
}
