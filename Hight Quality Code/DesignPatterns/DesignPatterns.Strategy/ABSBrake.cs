namespace DesignPatterns.Strategy
{
    using System;

    /// <summary>
    /// 'ConcreteStrategy'
    /// </summary>
    class ABSBrake: BrakeSystem
    {
        public override void Brake()
        {
            Console.WriteLine("ABS brake");
        }
    }
}
