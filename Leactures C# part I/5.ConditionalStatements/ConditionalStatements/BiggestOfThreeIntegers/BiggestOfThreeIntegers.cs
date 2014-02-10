using System;

class BiggestOfThreeIntegers
{
    static void Main()
    {
        /* Write a program that finds the biggest of three integers using nested if statements.
         */

        Console.Write("Please, enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        // Numbers are all equal.
        if ((firstNumber == secondNumber) && (secondNumber == thirdNumber))
        {
            Console.WriteLine("Numbers are equal.");
            return;
        }

        //Defining the bigger int.
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("Number {0} is the biggest int.", firstNumber);
            }
            else if (firstNumber == thirdNumber)
            {
                Console.WriteLine("Number {0} is the biggest int.", firstNumber);
            }
            else
            {
                Console.WriteLine("Number {0} is the biggest int.", thirdNumber);
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("Number {0} is the biggest int.", secondNumber);
            }
            else if (secondNumber == thirdNumber)
            {
                Console.WriteLine("Number {0} is the biggest int.", secondNumber);
            }
            else
            {
                Console.WriteLine("Number {0} is the biggest int.", thirdNumber);
            }
        }

    }
}
