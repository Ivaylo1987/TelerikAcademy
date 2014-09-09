namespace Variations
{
    using System;

    class Demo
    {
        private static string[] setOfelemetns = { "hi", "a", "b" };
        static void Main()
        {
            var numberOfElements = 2;
            var variations = new string[numberOfElements];

            GenerateVariations(variations, 0);
        }

        private static void GenerateVariations(string[] variations, int index)
        {
            if (index == variations.Length)
            {
                Console.WriteLine(string.Join(", ", variations));
                return;
            }

            for (int i = 0; i < setOfelemetns.Length; i++)
            {
                variations[index] = setOfelemetns[i];
                GenerateVariations(variations, index + 1);
            }
        }
    }
}
