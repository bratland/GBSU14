namespace BankMedArv
{
    public abstract class BankAccount
    {
        public abstract decimal Interest { get; set; }

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

        public abstract decimal CalculateInterest();

        public override string ToString()
        {
            return "Balance: " + Balance;
        }
    }
}