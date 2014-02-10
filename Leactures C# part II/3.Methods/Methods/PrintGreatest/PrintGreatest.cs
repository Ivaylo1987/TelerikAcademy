using System;

class PrintGreatest
{
    /* Write a method GetMax() with two parameters that returns the bigger of two integers.
     * Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
     */

    static int GetMax(int firstNum, int secondNum) 
    {
        if (firstNum >= secondNum)
        {
            return firstNum;
        }
        else
        {
            return secondNum;
        }
    }

    static void Main()
    {
        Console.Write("Please, enter first number: ");
        int firstValue = int.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        int secondtValue = int.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        int thirdValue = int.Parse(Console.ReadLine());

        int temp = GetMax(firstValue, secondtValue);

        Console.WriteLine("The greatest number is {}", GetMax(temp, thirdValue));
    }
}
