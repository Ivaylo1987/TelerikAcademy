using System;

class Variations
{
    /* Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
     * Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
     */

    static int n;    //Static variable = not recomended but in this case usefull.

    static void GenerateVariations(int[] varArr, int index)   //Void method to generate variations.
    {
        if (index == varArr.Length)
        {
            Console.WriteLine(String.Join(" ", varArr));     //Print when bottom of recursion is reached.
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            varArr[index] = i;
            GenerateVariations(varArr, index + 1);
        }
    }

    static void Main()
    {
        Console.Write("Please, entar N: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Please entar K: ");
        int k = int.Parse(Console.ReadLine());

        int[] varArr = new int[k];
        GenerateVariations(varArr, 0);
    }
}
