namespace DesignPatterns.Strategy
{
    using System;

    /// <summary>
    /// 'Context'
    /// </summary>
    class Car
    {
        public Car(string model, string brand, BrakeSystem brake)
        {
            this.Model = model;
            this.Brand = brand;
            this.BrakeSystem = brake;
        }

        public string Model { get; protected set; }
        public string  Brand { get; protected set; }
        public BrakeSystem  BrakeSystem { get; protected set; }
        
        public virtual void Brake()
        {
            this.BrakeSystem.Brake();
        }
    }
}
