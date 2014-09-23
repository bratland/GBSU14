using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankMedArv
{
    public class CheckingAccount : BankAccount
    {
        public override decimal CalculateInterest()
        {
            return 0.02m*Balance;
        }
    }
}
