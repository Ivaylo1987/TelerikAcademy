using System;

class SubsetSum
{
    static void Main()
    {
        /* We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
         * Example: 3, -2, 1, 1, 8  1+1-2=0.
         */

        int[] numArray = new int[5] { 3, -2, 1, 1, 8 }; //{ 3, 1, -7, 35, 22 }; - to test when there is no 0 sum.
        int sum = 0;
        bool zeroSumFound = false;
        int count = 0;
        int startIndex = 0;
        int endIndex = 0;

        //check if sum exists.
        for (int i = 0; i < numArray.Length; i++)
        {
            for (int j = i; j < numArray.Length; j++)
            {
                sum += numArray[j];
                count++;
                if (sum == 0)
                {
                    zeroSumFound = true;
                    startIndex = i;
                    endIndex = startIndex + count - 1;
                    break;
                }
            }
            //if (zeroSumFound)
            //{
            //    break;
            //}
            //if it doesn't exist
            if (!zeroSumFound)
            {
                Console.WriteLine("No such sum in the array.");
            }
            //else exists -> print with comas on the right places.
            else
            {
                bool letterPrinted = false;
                for (int k = startIndex; k <= endIndex; k++)
                {
                    if (letterPrinted)
                    {
                        Console.Write(", ");
                    }
                    Console.Write("{0}", numArray[k]);
                    letterPrinted = true;
                }
                Console.WriteLine();
            }

            sum = 0;
            count = 0;
        }

         
    }
}
