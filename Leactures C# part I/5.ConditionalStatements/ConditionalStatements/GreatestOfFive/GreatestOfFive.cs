using System;

class GreatestOfFive
{
    static void Main()
    {
        /* Write a program that finds the greatest of given 5 variables.
         */

        int[] numArray = new int[5];
        int temp;

        //initialize values in the array
        for (int i = 0; i < numArray.Length; i++)
        {
            Console.Write("Please, enter number[{0}]: ", i);
            numArray[i] = int.Parse(Console.ReadLine());
        }

        //find greatest
        for (int i = 0; i < numArray.Length - 1; i++)
        {
            if (numArray[i] > numArray[i + 1])
            {
                // swap with temp variable
                temp = numArray[i + 1];
                numArray[i + 1] = numArray[i];
                numArray[i] = temp;
            }
        }

        Console.WriteLine("The greatest of the five is {0}", numArray[4]);
    }
}
