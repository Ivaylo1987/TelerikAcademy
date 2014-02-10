using System;

class CountOfANumber
{
    /* Write a method that counts how many times given number appears in given array.
     * Write a test program to check if the method is working correctly.
     */
    static int CountOfKey(int[] arrayToSearch, int key) 
    {
        int count = 0;
        for (int i = 0; i < arrayToSearch.Length; i++)
        {
            if (arrayToSearch[i] == key)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        int[] arr = {1, 4, 3, 6, 4, 0, 100, -1, 5, 13, 4, -1 };

        Console.WriteLine(CountOfKey(arr, 4));
    }
}
