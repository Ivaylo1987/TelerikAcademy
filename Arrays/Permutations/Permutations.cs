using System;

class Permutations
{
    /* * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
     * Example: n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
     */

    //global variables not recomended but usefull in the case
    static int n; 
    static bool[] numberUsed;

    static void GeneratePermutations(int[] arr, int index)    //Method that generates permutations
    {
        if (index == arr.Length)
        {
            Console.WriteLine(String.Join(" ", arr));        //Print.
            return;
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                if (!numberUsed[i])                          //If number is NOT used so far use it.
                {
                    arr[index] = i;
                    numberUsed[i] = true;
                    GeneratePermutations(arr, index + 1);
                    numberUsed[i] = false;
                }
            }
        }

    }

    static void Main()
    {
        Console.Write("Please, enter N: ");
        n = int.Parse(Console.ReadLine());

        int[] permArr = new int[n];
        numberUsed = new bool[n + 1];      //Initialize bool array for the used digits. numberUsed[0] is never used.

        GeneratePermutations(permArr, 0);
    }
}
