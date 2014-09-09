namespace SubSetsOfStrings
{
    using System;
    using System.Collections.Generic;

    class Demo
    {
        private static string[] setOfStrings = { "test", "rock", "fun" };
        static void Main()
        {
            var numberOfElements = 2;
            var permutations = new string[numberOfElements];
            var usedElements = new List<string>();

            GenerateCombinations(permutations, 0, 0);
        }

        private static void GenerateCombinations(string[] combinations, int index, int startOfElements)
        {
            if (index == combinations.Length)
            {
                Console.WriteLine(string.Join(", ", combinations));
                return;
            }

            for (int i = startOfElements; i < setOfStrings.Length; i++)
            {
                var currentElement = setOfStrings[i];

                combinations[index] = currentElement;
                GenerateCombinations(combinations, index + 1, i + 1);
            }
        }
    }
}
