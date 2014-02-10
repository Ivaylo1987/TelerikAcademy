using System;

class MaxIncreasingSec
{
    /*Write a program that finds the maximal increasing sequence in an array.
     * Example: {3, 2, 3, 4, 2, 2, 4, 1, 8, 7} -> {2, 3, 4}.
     */
    static void Main()
    {
        int[] arr = { 3, 2, 3, 4, 2, 2, 4, 1, 8, 11, 17 };   // Some additional values are addet for testing purposes.

        int len = 1;
        int bestIndex = 0;
        int bestLen = 1;

        for (int i = 0; i < arr.Length; i += len)   // i is incremented with the last value of len in order to save useless iterations.
        {
            len = 1;

            for (int j = i; j < arr.Length - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    len++;
                }
                else
                {
                    break;
                }
            }

            if (len > bestLen)
            {
                bestLen = len;
                bestIndex = i;
            }
        }

        //Print
        Console.Write("{ ");
        for (int i = bestIndex; i < bestIndex + bestLen; i++)
        {
            if (i != bestIndex)
            {
                Console.Write(", ");
            }
            Console.Write("{0}", arr[i]);
        }
        Console.WriteLine(" }");
    }
}
