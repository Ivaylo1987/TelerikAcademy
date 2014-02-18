namespace AnimalWorld
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Sex.Female)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Miaaaaau, murrr Kitten!");
        }
    }
}
