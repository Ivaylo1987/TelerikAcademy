namespace DesignPatterns.Composite
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// The 'Composite'
    /// </summary>
    class Commander : MilitaryPerson
    {
        private IList<MilitaryPerson> subordinates;

        public Commander(string name)
        {
            this.subordinates = new List<MilitaryPerson>();
            this.Name = name;
        }

        public void AddSubordinate(MilitaryPerson solder)
        {
            this.subordinates.Add(solder);
        }

        public void RemoveSubordiante(MilitaryPerson solder)
        {
            this.subordinates.Remove(solder);
        }

        public override void Display(int indent)
        {
            Console.Write(new string('-', indent));
            Console.WriteLine("Comander Name: {0}", this.Name);

            foreach (var solder in subordinates)
            {
                solder.Display(indent + 2);
            }
            
        }
    }
}
