﻿namespace AnimalWorld
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, Sex sex)
            : base(name, age, sex)
        {

        }
        
        public override void MakeSound()
        {
            Console.WriteLine("Myauuu! Cat");
        }
    }
}
