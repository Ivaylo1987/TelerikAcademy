namespace SortIncreasingOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortIncreasingOrder
    {
        static void Main()
        {
            List<int> sequence = new List<int>();
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

                sequence.Add(current);
            }
            
            Console.WriteLine(string.Join(", ", sequence.OrderBy(n => n)));
        }
    }
}
