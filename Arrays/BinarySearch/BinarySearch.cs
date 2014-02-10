using System;
using System.Collections.Generic;

class BinarySearch
{
    /* Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm 
     * (find it in Wikipedia).
     */
    static void Main()
    {
        int startIndex = 0;
        int endIndex;
        int midIndex = 0;
        List<int> listArr = new List<int>();

        Console.Write("Please, enter key value to search: ");
        int key = int.Parse(Console.ReadLine());

        Console.Write("Please, enter initial size of the array: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Array[{0}] = ", i);
            listArr.Add(int.Parse(Console.ReadLine()));
        }

        endIndex = listArr.Count - 1;
        listArr.Sort();
        bool found = false;

        //Binary search algorithm
        while ((startIndex <= endIndex) && !found)
        {
            // (startIndex + endIndex) / 2 cannot be used because it can overflow the int type and give wrong value.
            midIndex = startIndex + (endIndex - startIndex) / 2;  
            if (key > listArr[midIndex])                           
            {
                startIndex = midIndex + 1;
            }
            else if (key < listArr[midIndex])
            {
                endIndex = midIndex - 1;
            }
            else
            {
                found = true;
            }
        }

        //Print
        if (found)
        {
            Console.WriteLine("Key found on index {0}", midIndex);
        }
        else
        {
            Console.WriteLine("Key not fount in the Array");
        }
    }
}
