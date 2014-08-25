namespace RemoveNegative
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Demo
    {
        private static Random randomGenerator = new Random();

        private static List<int> GenerateRandomList(int count)
        {
            var result = new List<int>();

            for (int i = 0; i < count; i++)
            {
                result.Add(randomGenerator.Next(-20, 21));
            }

            return result;
        }

        static void Main()
        {
            Console.Write("Please, enter the length of the sequence: ");
            var input = int.Parse(Console.ReadLine());
            var sequence = GenerateRandomList(input);

            Console.WriteLine("Before:");
            Console.WriteLine(string.Join(", ", sequence));

            Console.WriteLine("After:");
            sequence.RemoveAll(e => e < 0);
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
