namespace DesignPatterns.Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class PiggyBank : MoneyFactory
    {
        public override Money ProduceMoney()
        {
            return new Coin();
        }
    }
}
