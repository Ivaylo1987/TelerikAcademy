using System;

class GreaterNumber
{
    /* Write a program that gets two numbers from the console and prints the greater of them.
     * Don’t use if statements.
     */

    static void Main()
    {
        int result;

        Console.Write("Please, enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        result = (firstNumber > secondNumber) ? firstNumber : secondNumber;
        Console.WriteLine(result);
    }
}
