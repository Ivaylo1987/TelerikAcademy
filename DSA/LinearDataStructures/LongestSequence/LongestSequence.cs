namespace LongestSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestSequence
    {
        private static IList<int> MaxSequenceOfEqual(IList<int> sequence)
        {
            if (sequence == null)
            {
                throw new NullReferenceException("Sequence cannot be null");
            }

            var bestCount = 1;
            var currentCount = 1;
            var element = sequence[0];

            for (int i = 0; i < sequence.Count - 1; i += currentCount)
            {
                currentCount = 1;
                for (int j = i; j < sequence.Count - 1; j++)
                {
                    if (sequence[j] == sequence[j + 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bestCount < currentCount)
                {
                    bestCount = currentCount;
                    element = sequence[i];
                }
            }

            return Enumerable.Repeat(element, bestCount).ToList();
        }

        static void Main()
        {
            List<int> sequence = new List<int>() { 2, 1, 1, 2, 3, 3, 3, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1 };

            var result = string.Join(", ", MaxSequenceOfEqual(sequence));
            Console.WriteLine(result);
        }
    }
}
