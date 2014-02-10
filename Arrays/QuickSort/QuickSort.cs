using System;
using System.Collections.Generic;

class QuickSort
{

    /* Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
     */

    //The simple version of Quick sort algorithm
    static List<int> SimpleQuickSort(List<int> unsortedList)
    {
        if (unsortedList.Count <= 1)
        {
            return unsortedList;
        }

        int pivot = unsortedList.Count / 2;
        int pivotValue = unsortedList[pivot];
        unsortedList.RemoveAt(pivot);

        List<int> lesser = new List<int>();
        List<int> greater = new List<int>();

        //Fill up lesser nad greater arrays
        foreach (int element in unsortedList)
        {
            if (element <= pivotValue)
            {
                lesser.Add(element);
            }
            else
            {
                greater.Add(element);
            }
        }

        //Recursively implemet quick sort.
        List<int> result = new List<int>();
        result.AddRange(SimpleQuickSort(lesser));
        result.Add(pivotValue);
        result.AddRange(SimpleQuickSort(greater));

        return result;

    }

    static void Main()
    {
        List<int> array = new List<int> { 7, 11, 5, 0, 123, 3, 23, 2722, 89 };
        List<int> sortedArray = SimpleQuickSort(array);

        Console.WriteLine(String.Join(", ", sortedArray));
    }
}