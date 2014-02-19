namespace Bank
{
    public class Loan : Account, IDepositable
    {
        public override decimal CalculateInterest(decimal periodMonths)
        {
            throw new System.NotImplementedException();
        }

        public void DepositMoney(decimal amount)
        {
            throw new System.NotImplementedException();
        }
    }
}
