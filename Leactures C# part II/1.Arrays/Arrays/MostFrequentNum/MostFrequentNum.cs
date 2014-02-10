using System;

class MostFrequentNum
{
    //Write a program that finds the most frequent number in an array. Example:
    //{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int len = 1;
        int bestLen = 1;
        int bestIndex = 0;

        // Sort the array then just find the longest sequence like in problem 04.MaxSec
        Array.Sort(arr); 
        for (int i = 0; i < arr.Length - 1; i += len)
        {
            len = 1;
            for (int j = i; j < arr.Length; j++)
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

            if (len > bestLen)
            {
                bestLen = len;
                bestIndex = i;
            }

        }

        //Print
        Console.WriteLine("{0} -> {1} times", arr[bestIndex], bestLen);
    }
}
