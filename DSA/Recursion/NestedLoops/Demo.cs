namespace NestedLoops
{
    using System;

    class Demo
    {
        static void Main()
        {
            var numberOfNestedLoops = 2;
            var vector = new int[numberOfNestedLoops];

            NestedLoops(vector, 0);
        }

        private static void NestedLoops(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(", ", vector));
                return;
            }

            for (int i = 1; i <= vector.Length; i++)
            {
                vector[index] = i;
                NestedLoops(vector, index + 1);
            }
        }
    }
}
