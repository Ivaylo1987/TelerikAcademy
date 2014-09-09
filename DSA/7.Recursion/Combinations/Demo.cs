namespace Combinations
{
    using System;

    class Demo
    {
        private static int numberOfElementsInSet = 3;
        static void Main()
        {
            var numberOfElements = 2;
            var combination = new int[numberOfElements];

            GenerateCombinations(combination, 0);
        }

        private static void GenerateCombinations(int[] combination, int index)
        {
            if (index == combination.Length)
            {
                Console.WriteLine(string.Join(", ", combination));
                return;
            }

            for (int i = 1; i <= numberOfElementsInSet; i++)
            {
                combination[index] = i;
                GenerateCombinations(combination, index + 1);
            }
        }
    }
}
