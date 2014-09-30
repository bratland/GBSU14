using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDemo
{
    public class BankAccount
    {
        private readonly ILogger _logger;

        public BankAccount(ILogger logger)
        {
            _logger = logger;
        }

        public void Witdraw(decimal amount)
        {
            _logger.Log("Witdraw, amount: " + amount);
            Balance -= amount;
        }

        public decimal Balance { get; set; }
    }
}
