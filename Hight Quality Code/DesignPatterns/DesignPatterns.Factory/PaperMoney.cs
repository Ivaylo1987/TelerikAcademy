namespace DesignPatterns.Factory
{
    using System;

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class PaperMoney : Money
    {
        private readonly string name;

        public PaperMoney()
        {
            this.name= "Paper Money";
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
