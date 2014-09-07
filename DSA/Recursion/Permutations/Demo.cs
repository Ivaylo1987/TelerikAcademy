namespace Permutations
{
    using System;
    using System.Collections.Generic;

    class Demo
    {
        private static int numberOfElementsInSet = 3;
        static void Main()
        {
            var numberOfElements = 3;
            var permutations = new int[numberOfElements];
            var usedElements = new List<int>();

            GeneratePermutations(permutations, 0, usedElements);
        }

        private static void GeneratePermutations(int[] permutations, int index, List<int> usedElements)
        {
            if (index == permutations.Length)
            {
                Console.WriteLine(string.Join(", ", permutations));
                return;
            }

            for (int i = 1; i <= numberOfElementsInSet; i++)
            {
                if (usedElements.Contains(i))
                {
                    continue;
                }
                permutations[index] = i;
                usedElements.Add(i);
                GeneratePermutations(permutations, index + 1, usedElements);
                usedElements.Remove(i);
            }
        }
    }
}
