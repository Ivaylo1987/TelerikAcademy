namespace DesignPatterns.Composite
{
    using System;

    /// <summary>
    /// The 'Component' element 
    /// </summary>
    abstract class MilitaryPerson
    {
        public string Name { get; protected set; }

        public abstract void Display(int indent);
    }
}
