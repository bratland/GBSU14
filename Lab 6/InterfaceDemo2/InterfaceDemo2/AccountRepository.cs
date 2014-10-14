using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace InterfaceDemo2
{
    public class AccountRepository : IAccountRepository
    {
        private List<SavingsAccount> _accounts;

        public AccountRepository()
        {
            //_accounts = new List<BankAccount>();
            if (File.Exists("accounts.xml"))
            {
                var fs = new FileStream("accounts.xml", FileMode.Open);
                var serializer = new XmlSerializer(typeof(List<SavingsAccount>));

                _accounts = (List<SavingsAccount>)serializer.Deserialize(fs);
            }
            else
            {
                _accounts = new List<SavingsAccount>();
            }

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

            var serializer = new XmlSerializer(typeof (List<SavingsAccount>));
            using(TextWriter writer = new StreamWriter("accounts.xml"))
            {
                serializer.Serialize(writer, _accounts);
                writer.Close();
            }

        }
    }
}
