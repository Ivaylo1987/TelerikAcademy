using System;

class BiggerThanNeighbor
{
    /* Write a method that checks if the element at given position in given array
     * of integers is bigger than its two neighbors (when such exist).
     */

    static bool GreaterThan(int[] arrToCheck, int index) 
    {
        if (1 <= index && index < arrToCheck.Length - 1)
        {
            if (arrToCheck[index] > arrToCheck[index + 1] && arrToCheck[index] > arrToCheck[index - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (index == 0)   //the first index of the array
        {
            if (arrToCheck[index] > arrToCheck[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else   //the last index in the array
        {
            if (arrToCheck[index] > arrToCheck[index - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }

    static void Main()
    {
        int[] arr = {4, 6, 10, -1, 0 , 118, -10, 42, 0, 13, -1, 7 };

        Console.WriteLine(GreaterThan(arr, 4));   //change the index to test
    }
}
