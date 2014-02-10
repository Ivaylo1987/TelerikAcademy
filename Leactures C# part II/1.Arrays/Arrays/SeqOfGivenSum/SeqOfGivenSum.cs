using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    /*Write a program that finds in given array of integers a sequence of given sum S (if present).
     * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
     */
    static void Main()
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        
        int givenSum = 11;
        StringBuilder arrOfSum = new StringBuilder();
        string result = null;
        bool resultFound = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (!resultFound)
            {
                int currentSum = 0;
                arrOfSum.Clear();

                for (int j = i; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    arrOfSum.AppendFormat("{0}, ", arr[j]);

                    if (currentSum == givenSum)
                    {
                        result = arrOfSum.ToString();
                        resultFound = true;
                        break;
                    }
                    if (currentSum > givenSum)              // When elements in the array are all positive this check saves useless iterations.
                    {
                        break;
                    }
                }
            }
            else
            {
                break;
            }
        }

        if (resultFound)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("No such sum exists in the array!");
        }
        
    }
}