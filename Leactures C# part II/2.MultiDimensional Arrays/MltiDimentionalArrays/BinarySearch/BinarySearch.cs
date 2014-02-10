using System;

class BinarySearch
{
    /* Write a program, that reads from the console an array of N integers and an integer K,
     * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
     */

    //Method that reads an array.
    static int[] ReadArray(int arraySize)
    {
        int[] tempArray = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Please, enter array element[{0}]: ", i);
            tempArray[i] = int.Parse(Console.ReadLine());
        }

        return tempArray;
    }

    static void Main()
    {
        Console.Write("Please, enter a number K to compare: ");
        int numberToCompare = int.Parse(Console.ReadLine());

        Console.Write("Please, enter size of the array: ");
        int arrSize = int.Parse(Console.ReadLine());

        int[] intArray = ReadArray(arrSize);
        Array.Sort(intArray);

        int index;
        index = Array.BinarySearch(intArray, numberToCompare); //returns the bitwise complement of the index of the first greater member in the array
                                                               //if the key value is not present.

        //Console.WriteLine(index); //Uncoment for test purposes.

        if (index >= 0)
        {
            Console.WriteLine("The number is {0}", intArray[index]);
        }
        else
        {
            if (~index == 0)
            {
                Console.WriteLine("There is no numberthat is <= K in the array.");
            }
            else
            {
                Console.WriteLine("The number is {0}", intArray[(~index) - 1]);
            }
            
        }
    }
}