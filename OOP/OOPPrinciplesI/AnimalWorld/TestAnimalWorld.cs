namespace AnimalWorld
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestAnimalWorld
    {
        static void Main()
        {
            // kittens
            Kitten[] kittens = 
            {
                new Kitten("Tonka", 4),
                new Kitten("Maca", 1),
                new Kitten("Meri", 7),
                new Kitten("Misha", 2)
           };

            kittens[1].MakeSound();
            Console.WriteLine("Kitens average Age: {0: 0.0}", Animal.CalcAverageAge(kittens));

            // tomcats
            Tomcat[] tomcats = 
            {
                new Tomcat("Tito", 3),
                new Tomcat("Rino", 8),
                new Tomcat("Goshko", 5),
                new Tomcat("Marko", 1)
            };

            tomcats[1].MakeSound();
            Console.WriteLine("Tomcats average Age: {0: 0.0}", Animal.CalcAverageAge(tomcats));

            // dogs
            Dog[] dogs = 
            {
                new Dog("Simon", 1, Sex.Male),
                new Dog("Kira", 4, Sex.Female),
                new Dog ("Bruno", 6, Sex.Male),
                new Dog("Katrin", 5, Sex.Female)
            };

            dogs[1].MakeSound();
            Console.WriteLine("Dogs average Age: {0: 0.0}", Animal.CalcAverageAge(dogs));

            // frogs
            Frog[] frogs = 
            {
                new Frog("Gina", 1, Sex.Female),
                new Frog("Lizi", 3, Sex.Female),
                new Frog("Rino", 13, Sex.Male),
            };

            frogs[1].MakeSound();
            Console.WriteLine("Frogs average Age: {0: 0.0}", Animal.CalcAverageAge(frogs));

            Animal kitten = new Kitten("Kiti", 1);   //declared as animal

            kitten.MakeSound();
            Console.WriteLine(kitten.Sex);

        }
    }
}
