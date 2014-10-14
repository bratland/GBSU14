namespace InterfaceDemo2
{
    public class AccountFactory
    {
        public static SavingsAccount[] Create()
        {
            SavingsAccount account2 = new SavingsAccount();
            account2.Deposit(100);
            SavingsAccount account4 = new SavingsAccount();
            account4.Deposit(100);
            SavingsAccount account5 = new SavingsAccount();
            account5.Deposit(100);

            SavingsAccount.Interest = 0.12m;

            //BankAccount account3 = new CheckingAccount();
            //account3.Deposit(100);

            return new []{account2, account4, account5};
        }
    }
}
