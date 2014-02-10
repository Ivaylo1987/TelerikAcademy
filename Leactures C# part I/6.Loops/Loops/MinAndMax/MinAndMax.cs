using System;

class MinAndMax
{
    static void Main()
    {
        //Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

        Console.Write("How many numbers would you like to enter: ");
        int numCount = int.Parse(Console.ReadLine());
        
        int[] arrayOfInts = new int[numCount];
        int min = int.MaxValue; // initialize with the max possible value
        int max = int.MinValue; // initialize with the min possible value

        // initialize the array (squence) of numbers.
        for (int i = 0; i < numCount; i++)
        {
            Console.Write("Please, enter number[{0}]: ", i);
            arrayOfInts[i] = int.Parse(Console.ReadLine());
        }

        //find min and max
        for (int i = 0; i < arrayOfInts.Length; i++)
        {
            if (min > arrayOfInts[i])
            {
                min = arrayOfInts[i];
            }
            if (max < arrayOfInts[i])
            {
                max = arrayOfInts[i];
            }
        }

        Console.WriteLine("Min is {0} and Max is {1}", min, max);


        // alternaticve solution without array.
        /*  
        int max = int.MinValue;
        int min = int.MaxValue;
        int num;
        Console.Write("How many number would you like to enter: ");
        int numCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < numCount; i++)
        {
            do
            {
                Console.Write("Please enter number[{0}]: ", i);
            } while (!(int.TryParse(Console.ReadLine(), out num)));

            if (max < num)
            {
                max = num;
            }
            if (min > num)
            {
                min = num;
            }
            // Console.WriteLine(num + " ");
        }
        Console.WriteLine("Min is {0} and Max num = {1}; ", min, max);
        */
    }
}
