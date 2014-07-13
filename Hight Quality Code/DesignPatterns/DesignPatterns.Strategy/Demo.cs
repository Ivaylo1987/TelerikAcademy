namespace DesignPatterns.Strategy
{
    using System;

    /// <summary>
    /// Stratedy Design Pattern - Behavioral
    /// </summary>
    class Demo
    {
        static void Main()
        {
            var opel = new Car("Corsa", "Opel", new ABSBrake());
            Console.WriteLine("{0} {1}:", opel.Brand, opel.Model);
            opel.Brake();

            var clAMG = new Car("CL", "Mercedes", new SportBrake());
            Console.WriteLine("{0} {1}:", clAMG.Brand, clAMG.Model);
            clAMG.Brake();

        }
    }
}
