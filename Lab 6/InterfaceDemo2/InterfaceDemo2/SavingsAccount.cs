namespace InterfaceDemo2
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount()
        {
            Interest = 0.1m;
        }

        public override decimal CalculateInterest()
        {
            return Interest * Balance;
        }

        public decimal TotalSavings { get; set; }

        public override string ToString()
        {
            return base.ToString() + " Interest: " + Interest + " TotSavings: " + TotalSavings;
        }

        public static decimal Interest { get; set; }
    }
}
