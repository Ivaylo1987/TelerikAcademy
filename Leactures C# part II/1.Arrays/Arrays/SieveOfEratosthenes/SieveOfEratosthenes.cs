using System;

class SieveOfEratosthenes
{
    /* Write a program that finds all prime numbers in the range [1...10 000 000].
     * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
     */
    static void Main()
    {
        int n = 1000; // for testing purposes
        bool[] arr = new bool[n];

        //initialize all true (all prime);
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = true;
        }

        //Sieve of Eratosthenes
        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i]) //true
            {
                for (int j = 2; (j * i) < arr.Length; j++)
                {
                    arr[j * i] = false;

                }
            }
        }

        //Print those that are prime(true).
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i])
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
