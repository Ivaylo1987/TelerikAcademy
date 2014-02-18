namespace AnimalWorld
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Sex.Male)
        {

        }
        
        public override void MakeSound()
        {
            Console.WriteLine("Murr, murrr Tomcat!");
        }
    }
}
