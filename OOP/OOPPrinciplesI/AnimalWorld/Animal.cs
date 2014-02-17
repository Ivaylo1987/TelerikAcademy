namespace AnimalWorld
{
    using System;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentException();
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.age = value;
            }
        }

        public Sex Sex { get; private set; }

        public abstract void MakeSound();

    }
}