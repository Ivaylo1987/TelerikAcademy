using System;

class FindMaxAndSort
{
    /* Write a method that return the maximal element in a portion of array of integers starting at given index.
     * Using it write another method that sorts an array in ascending / descending order.
     */

    //Method that find max elemnt starting at a given index
    static int FindIndexOfMaxElement(int[] arrayToSearch, int index)
    {
        int maxIndex = index;
        for (int i = index; i < arrayToSearch.Length; i++)
        {
            if (arrayToSearch[maxIndex] < arrayToSearch[i])
            {
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    //Method that sorts array
    static int[] SortArray(int[] arrayToSort, bool ascending = false) //By Default it sort is descending order
    {
        int temp;
        int maxIndex;
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            temp = arrayToSort[i];
            maxIndex = FindIndexOfMaxElement(arrayToSort, i);

            arrayToSort[i] = arrayToSort[maxIndex];
            arrayToSort[maxIndex] = temp;
        }

        if (ascending)
        {
            Array.Reverse(arrayToSort);
        }
        return arrayToSort;
    }

    static void Main()
    {
        int[] numArray = { 1, 34, -1, 13, 2, 2, 7, 18 };

        int maxElementIndex = FindIndexOfMaxElement(numArray, 0); //Call with index 0 -> max element in the whole array.
        int[] sortedArray = SortArray(numArray);   //if ascending is needed add second argument "true" when method is called.

        Console.WriteLine(maxElementIndex);
        Console.WriteLine(String.Join(", ", sortedArray));
    }
}
