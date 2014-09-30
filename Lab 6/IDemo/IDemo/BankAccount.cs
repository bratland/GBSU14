using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDemo
{
    public class BankAccount
    {
        public int AccountId { get; set; }

        private readonly ILogger _logger;

        public BankAccount(int id, ILogger logger)
        {
            _logger = logger;
            AccountId = id;
        }

        public void Witdraw(decimal amount)
        {
            _logger.Log("Witdraw, amount: " + amount);
            Balance -= amount;
        }

        public decimal Balance { get; set; }
    }
}
