namespace AnimalWorld
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, Sex sex)
            : base(name, age, sex)
        {

        }
        
        public override void MakeSound()
        {
            Console.WriteLine("Murr, murrr!");
        }
    }
}
