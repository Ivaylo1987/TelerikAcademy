﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr)
        where T : IComparable<T>
    {
        // public method throw Exception not an Assertion
        if (arr == null)
        {
            throw new ArgumentNullException("Arr cannot be null");
        }

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        Debug.Assert(CheckIfSorted(arr), "Array is not sorted!");
    }

    public static int BinarySearch<T>(T[] arr, T value)
        where T : IComparable<T>
    {
        // public method throw Exception not an Assertion
        if (arr == null)
        {
            throw new ArgumentNullException("Arr cannot be null");
        }

        if (value == null)
        {
            throw new ArgumentNullException("Value cannot be null");
        }

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        // Assertions
        Debug.Assert(arr != null, "Array cannot be null!");
        Debug.Assert(startIndex >= 0, "Start index cannot be negative");
        Debug.Assert(endIndex <= arr.Length - 1, "End index cannot be larger than arr length!");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        // Assertions
        Debug.Assert(arr != null, "Array cannot be null!");
        Debug.Assert(value != null, "Array cannot be null!");
        Debug.Assert(startIndex <= endIndex, "Start index should be less than or equal to endIndex!");
        Debug.Assert(CheckIfSorted(arr), "Array is not sorted!");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    private static bool CheckIfSorted<T>(T[] arr)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Arr should not be null!");

        if (arr.Length == 0)
        {
            return true;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].CompareTo(arr[i + 1]) > 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
