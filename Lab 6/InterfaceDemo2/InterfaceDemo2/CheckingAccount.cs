namespace InterfaceDemo2
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount()
        {
            Interest = 0.02m;
        }
        public static decimal Interest { get; set; } 

        public override decimal CalculateInterest()
        {
            return Interest * Balance;
        }

        public override string ToString()
        {
            return base.ToString() + " Interest: " + Interest ;
        }
    }
}
