namespace AnimalWorld
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Sex.Male)
        {

        }

        // override Sex not to allow female tomcats
        public override Sex Sex
        {
            get
            {
                return base.Sex;
            }
            set
            {
                if (value == Sex.Female)
                {
                    throw new ArgumentException("Tomcats can only be male!");
                }
                base.Sex = value;
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("Murr, murrr Tomcat!");
        }
    }
}
