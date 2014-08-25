namespace ReverseSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Demo
    {
        static void Main()
        {
            Stack<int> sequenceStack = new Stack<int>();
            Console.WriteLine("Please, enter some integers. To break enter an empty line.");

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

                sequenceStack.Push(current);
            }

            while (sequenceStack.Count > 0)
            {
                Console.WriteLine(sequenceStack.Pop());
            }
        }
    }
}
