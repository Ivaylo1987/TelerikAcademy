using System;

class CompareArr
{
    static void Main()
    {
        /* Write a program that reads two arrays from the console and compares them element by element.
         */

        Console.Write("Please, enter Array size: ");
        string arrSize = Console.ReadLine();
        int n = int.Parse(arrSize);
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        Console.WriteLine("Please, enter elemetns for Array one. ");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write("Array1[{0}]: ", i);
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please, enter elemetns for Array two. ");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write("Array2[{0}]: ", i);
            arr2[i] = int.Parse(Console.ReadLine());
        }
       
        bool areEqual = true;
        for (int i = 0; i < n; i++)
        {
            if (arr1[i] != arr2[i])
            {
                areEqual = false;
                break;

            }
        }
        Console.WriteLine("Ara arrays equal: {0}", areEqual);
    }
}
