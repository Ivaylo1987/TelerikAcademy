namespace RemoveOdd
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Demo
    {
        static void Main()
        {
            List<int> sequence = new List<int>() { 2, 2, 1, 1, 3, 3, 3, 3, 3, 4, 4, 4, 4, 1, 1, 1, 1, 1 };
            Console.WriteLine("Before:");
            Console.WriteLine(string.Join(", ", sequence));

            var numbersAndOccurances = new Dictionary<int, int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                if (numbersAndOccurances.ContainsKey(sequence[i]))
                {
                    numbersAndOccurances[sequence[i]]++;
                }
                else
                {
                    numbersAndOccurances.Add(sequence[i], 1);
                }
            }

            foreach (var number in numbersAndOccurances)
            {
                if (number.Value % 2 != 0)
                {
                    sequence.RemoveAll(el => el == number.Key);
                }
            }

            Console.WriteLine("After:");
            sequence.RemoveAll(e => e < 0);
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
