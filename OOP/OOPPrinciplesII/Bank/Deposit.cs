namespace Bank
{
    public class Deposit : Account, IWithDrawable
    {
        public Deposit(decimal balance, Customer customer, decimal interestRate)
            : base(balance, customer, interestRate)
        { 
        }

        public override decimal CalculateInterest(decimal periodMonths)
        {
            if (this.Balance > 0 || this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * periodMonths * this.Balance / 100;
            }
        }

        public void WithDrawMomey(decimal amout)
        {
            this.Balance -= amout;
        }
    }
}
