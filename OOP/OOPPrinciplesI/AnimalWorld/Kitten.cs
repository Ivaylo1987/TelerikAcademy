namespace AnimalWorld
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Sex.Female)
        {

        }

        // override Sex not to allow male kitties
        public override Sex Sex
        {
            get
            {
                return base.Sex;
            }
            set
            {
                if (value == Sex.Male)
                {
                    throw new ArgumentException("Kittens are only female!");
                }
                base.Sex = value;
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("Miaaaaau, murrr Kitten!");
        }
    }
}
