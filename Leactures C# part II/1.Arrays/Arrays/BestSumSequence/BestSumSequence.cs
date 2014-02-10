using System;
using System.Collections.Generic;
using System.Text;

class BestSumSequence
{
    /*Write a program that finds the sequence of maximal sum in given array. Example:
	 *{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
	 *Can you do it with only one loop (with single scan through the elements of the array)?
     */
    static void Main()
    {
        //With 2 loops
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, 5, 4 };
        int bestSum = int.MinValue; ;
        string result = null;

        for (int i = 0; i < arr.Length; i++)
        {
            List<int> bestSumArr = new List<int>(); //Could be done with StringBuilder for perfornace.
            int curretSum = 0;

            for (int j = i; j < arr.Length; j++)
            {
                curretSum += arr[j];
                bestSumArr.Add(arr[j]);

                if (curretSum > bestSum)
                {
                    bestSum = curretSum;
                    result = string.Join(", ", bestSumArr); //Could be done with StringBuilder for perfornace.
                }
            }
        }

        //Print
        Console.WriteLine(result);
        Console.WriteLine(bestSum);

        //With 1 loop

        //int[] arr = { -2, 1, -3, 4, -1, 2, 1, 5, 4 };
        //int currentSum = 0;
        //int bestSum = int.MinValue;
        //List<int> bestSumArr = new List<int>();
        //string result = null;

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    currentSum += arr[i];
        //    bestSumArr.Add(arr[i]);

        //    if (currentSum > bestSum)
        //    {
        //        bestSum = currentSum;
        //        result = string.Join(", ", bestSumArr);
        //    }
        //    if (currentSum < 0)
        //    {
        //        currentSum = 0;
        //        bestSumArr.Clear();
        //    }
        //}
        //Console.WriteLine(result);
        //Console.WriteLine(bestSum);
    }
}