namespace DesignPatterns.Factory
{
    using System;

    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class MoneyFactory
    {
        public abstract Money ProduceMoney();
    }
}
