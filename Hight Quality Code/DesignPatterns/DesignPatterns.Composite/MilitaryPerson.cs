namespace DesignPatterns.Composite
{
    using System;

    abstract class MilitaryPerson
    {
        public string Name { get; protected set; }

        public abstract void Display(int indent);
    }
}
