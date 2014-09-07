namespace CombinationsWithOutDuplicates
{
    using System;

    class Demo
    {
        private static int numberOfElementsInSet = 4;
        static void Main()
        {
            var numberOfElements = 2;
            var combination = new int[numberOfElements];

            GenerateCombinations(combination, 0, 1);
        }

        private static void GenerateCombinations(int[] combination, int index, int startOfElements)
        {
            if (index == combination.Length)
            {
                Console.WriteLine(string.Join(", ", combination));
                return;
            }

            for (int i = startOfElements; i <= numberOfElementsInSet; i++)
            {
                combination[index] = i;
                GenerateCombinations(combination, index + 1, i + 1);
            }
        }
    }
}
