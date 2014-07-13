namespace DesignPatterns.Factory
{
    using System;

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class Coin : Money
    {
        private readonly string name;

        public Coin()
        {
            this.name = "Coin Money";
        }

        public override string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}
