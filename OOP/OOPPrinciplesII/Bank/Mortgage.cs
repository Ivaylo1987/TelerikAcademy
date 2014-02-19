namespace Bank
{
    public class Mortgage : Account ,IDepositable
    {
        public void DepositMoney(decimal amount)
        {
            throw new System.NotImplementedException();
        }

        public override decimal CalculateInterest(decimal periodMonths)
        {
            throw new System.NotImplementedException();
        }
    }
}
