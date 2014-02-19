namespace Bank
{
    public class Mortgage : Account
    {
        private const int NO_INTEREST_PERIOD_INDIVIDIAL = 6;
        private const int HALF_INTEREST_PERIOD_COMPANY = 12;

        public Mortgage(decimal balance, Customer customer, decimal interestRate)
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
                if (periodMonths <= HALF_INTEREST_PERIOD_COMPANY)
                {
                    return (this.InterestRate *periodMonths) / 2;
                }
                else
                {
                    return this.InterestRate * periodMonths;
                }
            }
        }
    }
}
