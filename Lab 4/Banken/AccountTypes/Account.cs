using System;

namespace AccountTypes
{
    public class Account
    {
        private string _owner; //fält och variabel
        public Account(string owner)
        {
            var notField = "blablah"; //variabel, ej fält
            notField = "";
            _owner = owner;
        }

        private decimal _balance = 0.0m;

        public decimal Balance
        {
            get { return _balance; }
        }
        public int Id { get; set; }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("otillåtet belopp!");
                return;
            }
            _balance -= amount;
        }

        public override string ToString()
        {
            return "Account is owned by " + _owner + " with balance: " + _balance;
        }
    }
}
