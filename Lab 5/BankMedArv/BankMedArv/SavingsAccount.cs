namespace BankMedArv
{
    class SavingsAccount : BankAccount
    {
        public override decimal CalculateInterest()
        {
            return 0.1m * Balance;
        }
    }
}
