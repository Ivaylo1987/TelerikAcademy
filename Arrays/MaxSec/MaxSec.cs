using System;

class MaxSec
{
    /* Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.
     */

    static void Main()
    {
        int[] arr = { 2, 1, 1, 2, 3, 3, 3, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1}; // Some additional values are addet for testing purposes.
        
        int bestStart = 0;
        int bestLen = 1;
        int len = 1;

        for (int i = 0; i < arr.Length; i += len) // i is incremented with the last value of len in order to save useless iterations.
        {
            len = 1;
            for (int j = i; j < arr.Length - 1; j++)
            {

                if (arr[j] == arr[j + 1])
                {
                   len++;
                }
                else
                {
                    break;
                }
            }

            if (len > bestLen)   // check if best length so far i les the last found length.
            {
                bestLen = len;
                bestStart = i;
            }
        }

        //print
        Console.Write("{ ");
        for (int i = bestStart; i < (bestStart + bestLen); i++)
        {
            if (i != bestStart)
            {
                Console.Write(", ");
            }
            Console.Write("{0}", arr[i]);
        }
        Console.WriteLine(" }");
    }
}
