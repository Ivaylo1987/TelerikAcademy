using System;

class SortThreeValues
{
    static void Main()
    {
        /* Sort 3 real values in descending order using nested if statements.
         */

        Console.Write("Please, enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        //swap without a temp variable
        if (firstNumber > secondNumber)
        {
            secondNumber = secondNumber + firstNumber;
            firstNumber = secondNumber - firstNumber;
            secondNumber = secondNumber - firstNumber;
        }
        if (secondNumber > thirdNumber)
        {
            thirdNumber = thirdNumber + secondNumber;
            secondNumber = thirdNumber - secondNumber;
            thirdNumber = thirdNumber - secondNumber;
        }

        Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
    }
}
