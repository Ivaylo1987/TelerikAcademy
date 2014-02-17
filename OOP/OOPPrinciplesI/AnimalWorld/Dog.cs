﻿namespace AnimalWorld
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, Sex sex)
            : base(name, age, sex)
        {

        }
        
        public override void MakeSound()
        {
            Console.WriteLine("Bauuu!");
        }
    }
}
