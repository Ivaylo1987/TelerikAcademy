using System;

class BiggerThanNeighbor2
{
    /* Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1,
     * if there’s no such element. Use the method from the previous exercise.
     */

    static int GreaterThan(int[] arrToCheck)
    {
        int result = -1;

        for (int index = 0; index < arrToCheck.Length; index++)
        {
            if (1 <= index && index < arrToCheck.Length - 1)
            {
                if (arrToCheck[index] > arrToCheck[index + 1] && arrToCheck[index] > arrToCheck[index - 1])
                {
                    return index;
                }
            }
            else if (index == 0)   //arrToCheck[index] = first index of the array
            {
                if (arrToCheck[index] > arrToCheck[index + 1])
                {
                    return index;
                }
            }
            else   // arrToCheck[index] = the last index in the array
            {
                if (arrToCheck[index] > arrToCheck[index - 1])
                {
                    return index;
                }
            }
        }

        return result;
    }

    static void Main()
    {
       // int[] arr = { 4, 6, 10, 10, 10 }; //test for -1
        int[] arr = { 4, 6, 10, -1, 0, 118, -10, 42, 0, 13, -1, 7 };

        Console.WriteLine(GreaterThan(arr));   //change the index to test
    }
}
