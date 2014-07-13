namespace DesignPatterns.Factory
{
    class NamelessBank : MoneyFactory
    {
        public override Money ProduceMoney()
        {
            return new PaperMoney();
        }
    }
}
