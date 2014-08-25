namespace IntegerSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class IntegerSequence
    {
        static void Main()
        {
            List<int> sequence = new List<int>();
            Console.WriteLine("Please, enter some integers. To break enter mepty line.");

            while (true)
            {
                var input = Console.ReadLine();
                
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                int current;
                if (!int.TryParse(input, out current))
                {
                    Console.WriteLine("Input should be valid integer");
                    continue;
                } 

                sequence.Add(current);
            }

            Console.WriteLine("Sequence average is: {0}", sequence.Average());
            Console.WriteLine("Sequence sum is: {0}", sequence.Sum()); 
        }
    }
}
