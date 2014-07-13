namespace DesignPatterns.Composite
{
    using System;

    /// <summary>
    /// The 'Leaf'
    /// </summary>
    class Soldier : MilitaryPerson
    {
        public Soldier(string name)
        {
            this.Name = name;
        }

        public override void Display(int indent)
        {
            Console.Write(new string('-', indent));
            Console.WriteLine("Soldier Name: {0}", this.Name);
        }
    }
}
