namespace Bank
{
    using System;
    public abstract class Account : IInterest
    {
        private decimal interestRate;

        protected Account(decimal balance, Customer accountholder, decimal interestRate)
        {
            this.Balance = balance;
            this.AccountHolder = accountholder;
            this.InterestRate = interestRate;
            CreateDate = DateTime.Now;
        }

        public Customer AccountHolder { get; set; }

        public decimal Balance { get; set; }

        public DateTime CreateDate { get; private set; }   // for testing purposes tasks doesn't need it.

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative!");
                }

                this.interestRate = value;
            }
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public abstract decimal CalculateInterest(decimal periodMonths);
    }
}
