namespace DesignPatterns.Factory
{
    using System;

    /// <summary>
    /// Demo for Factory Method Design Pattern
    /// </summary>
    class Demo
    {
        static void Main()
        {
            var paperMoneyProducer = new NamelessBank();
            var pokerMoney = paperMoneyProducer.ProduceMoney();

            Console.WriteLine("Money for Poker table: {0}", pokerMoney.Name);

            var coinProducer = new PiggyBank();
            var slotsMoney = coinProducer.ProduceMoney();

            Console.WriteLine("Money for Slots: {0}", slotsMoney.Name);
        }
    }
}
