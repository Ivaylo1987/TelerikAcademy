namespace Bank
{
    using System;
    public class Loan : Account
    {
        private const int NO_INTEREST_PERIOD_INDIVIDIAL = 3;
        private const int NO_INTEREST_PERIOD_COMPANY = 2;

        public Loan(decimal balance, Customer customer, decimal interestRate)
            : base(balance, customer, interestRate)
        {

        }

        public override decimal CalculateInterest(decimal periodMonths)
        {
            if (this.AccountHolder is Individual)
            {
                if (periodMonths <= NO_INTEREST_PERIOD_INDIVIDIAL)
                {
                    return 0;
                }
                else
                {
                    return this.InterestRate * (periodMonths - NO_INTEREST_PERIOD_INDIVIDIAL);
                }
            }
            else
            {
                if (periodMonths <= NO_INTEREST_PERIOD_COMPANY)
                {
                    return 0;
                }
                else
                {
                    return this.InterestRate * (periodMonths - NO_INTEREST_PERIOD_COMPANY);
                }
            }
        }

    }
}
