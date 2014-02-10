using System;

class SelectionSort
{
    /* Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
     * Use the "selection sort" algorithm:
     * Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
     */
    static void Main()
    {
        //DateTime time = DateTime.Now;
        double[] arr = { 3, 2, 3, 4, 2, 2.1, 4, 1.5, 8.9, 17, 11 };
        int IndexOfMin;
        double temp = 0;
        
        //Selection sort
        for (int i = 0; i < arr.Length - 1; i++)
        {
            IndexOfMin = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[IndexOfMin])
                {
                    IndexOfMin = j;
                }
            }

            if (IndexOfMin != i)
            {
                temp =  arr[i];
                arr[i] = arr[IndexOfMin];
                arr[IndexOfMin] = temp;
            }
        }

        //Print sorted array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0}, ", arr[i]); 
        }
        Console.WriteLine();

        //DateTime outTime = DateTime.Now;
        //Console.WriteLine(outTime - time);

    }
}