namespace Bank
{
    public class Deposit : Account, IDepositable, IWithDrawable
    {
        public override decimal CalculateInterest(decimal periodMonths)
        {
            throw new System.NotImplementedException();
        }

        public void DepositMoney(decimal amount)
        {
            throw new System.NotImplementedException();
        }

        public void WithDrawMomey(decimal amout)
        {
            throw new System.NotImplementedException();
        }
    }
}
