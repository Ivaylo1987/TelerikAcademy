using System;

class Combinations
{

    /* Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
     * Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
     */

    static int n; //Static variable = not recomended but in this case usefull.

    static void GenerateCombinations(int[] arr, int index, int nextCombinationNumber) //Void method for generating combinations
    {
        if (index == arr.Length)
        {
            Console.WriteLine(String.Join(" ", arr)); //Print if bottom of recursion is reached
            return;
        }
        else
        {
            for (int i = nextCombinationNumber; i <= n; i++)
            {
                arr[index] = i;
                GenerateCombinations(arr, index + 1, i + 1); //To make Combinations, next combination digit = last combination digit + 1
            }
        }
    }

    static void Main()
    {
        Console.Write("Please, enter N: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Please, enter K: ");
        int k = int.Parse(Console.ReadLine());

        int[] combArr = new int[k];

        GenerateCombinations(combArr, 0, 1);
    }
}
