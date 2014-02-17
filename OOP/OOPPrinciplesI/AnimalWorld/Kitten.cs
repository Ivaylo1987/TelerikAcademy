namespace AnimalWorld
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, int age, Sex sex)
            : base(name, age, sex)
        {

        }
        
        public override void MakeSound()
        {
            Console.WriteLine("Miaaaaau, murrr!");
        }
    }
}
