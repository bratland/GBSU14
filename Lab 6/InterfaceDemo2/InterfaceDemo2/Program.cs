using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = AccountFactory.Create();
            var repo = new FakeAccountRepository();


            foreach (var savingsAccount in accounts)
            {
                Console.WriteLine(savingsAccount);
            }

            accounts[1].Balance = 10000m;

            foreach (var savingsAccount in accounts)
            {
                Console.WriteLine(savingsAccount);
            }

        }
    }
}
