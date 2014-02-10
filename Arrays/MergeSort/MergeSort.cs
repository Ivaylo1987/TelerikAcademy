using System;
using System.Collections.Generic;

class MergeSort
{
    /* * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
     */


    //Merge sort algorithm
    static List<int> MergeSortAlg(List<int> unsortedList)
    {
        if (unsortedList.Count <= 1)   //Bottom of recursion
        {
            return unsortedList;
        }

        List<int> left = new List<int>();
        List<int> right = new List<int>();

        int middle = unsortedList.Count / 2;

        //fill up left and right arrays
        for (int i = 0; i < middle; i++)
        {
            left.Add(unsortedList[i]);
        }
        for (int i = middle; i < unsortedList.Count; i++)
        {
            right.Add(unsortedList[i]);
        }

        left = MergeSortAlg(left);    //Recursively call algorithm for left array.
        right = MergeSortAlg(right);  //Recursively call algorithm for right array.
        return Merge(left, right);

    }

    //Merging already sorted arrays
    static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();
        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else if (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }
        return result;
    }

    static void Main()
    {
        List<int> array = new List<int> { 1111, 1, 4, 90, 123, 0, 3, 23 };
      
        List<int> sortedArray = MergeSortAlg(array);

        Console.WriteLine(String.Join(", ", sortedArray));
    }
}