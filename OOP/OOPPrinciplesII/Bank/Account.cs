namespace Bank
{
    using System;
    public abstract class Account : IInterest
    {
        private decimal balance;
        private decimal interestRate;

        protected Account(decimal balance, Customer accountholder, decimal interestRate)
        {
            this.Balance = balance;
            this.AccountHolder = accountholder;
            this.InterestRate = interestRate;
        }

        public Customer AccountHolder { get; protected set; }

        public decimal Balance 
        {
            get
            {
                return this.balance;
            }
            set 
            {
                this.balance = value;
            }
        }

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

        public abstract decimal CalculateInterest(decimal periodMonths);
    }
}
