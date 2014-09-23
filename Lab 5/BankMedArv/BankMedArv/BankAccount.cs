using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMedArv
{
    public class BankAccount
    {
        public decimal Balance { get; set; }

        public int Id { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public virtual decimal CalculateInterest()
        {
            return 0.0m;
        }
    }
}
