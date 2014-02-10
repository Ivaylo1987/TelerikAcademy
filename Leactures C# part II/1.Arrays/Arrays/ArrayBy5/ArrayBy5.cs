using System;

class ArrayBy5
{
    /* Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
     * Print the obtained array on the console.
     */
    static void Main(string[] args)
    {
        int[] myArr = new int[20];

        for (int i = 0; i < myArr.Length; i++)
        {
            myArr[i] = i * 5;
        }
        Console.WriteLine(string.Join(", ", myArr));
    }
}
