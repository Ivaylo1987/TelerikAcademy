namespace DesignPatterns.Strategy
{
    using System;

    /// <summary>
    /// 'ConcreteStrategy'
    /// </summary>
    class SportBrake : BrakeSystem
    {
        public override void Brake()
        {
            Console.WriteLine("Sport Brake"); ;
        }
    }
}
