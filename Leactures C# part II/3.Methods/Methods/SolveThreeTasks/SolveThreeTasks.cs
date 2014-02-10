using System;

class SolveThreeTasks
{
    /* Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
     */

    //Reverse Method from problem 7. 
    static int Reverse(string numberToReverse)
    {
        char[] arr = numberToReverse.ToCharArray();
        Array.Reverse(arr);
        string result = new string(arr);

        return Convert.ToInt32(result);
    }

    //Validate data. Check if negative or 0.
    static bool ValidateData(int numberToValidate) 
    {
        if (numberToValidate <= 0)
        {
           return false;
        }
        return true;
    }

    //Validate if not zero.
    static bool ValidateForZiro(int numberToValidate)
    {
        if (numberToValidate == 0)
        {
            return false;
        }
        return true;
    }

    //Option 3 method.
    static void SolveSimpleEquation()
    {
        bool isValidNumber;
        Console.Write("Please, enter value for \"a\": ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, enter value for \"b\": ");
        int b = int.Parse(Console.ReadLine());

        isValidNumber = ValidateForZiro(a);

        decimal result = 0;
        if (isValidNumber)
        {
            result = -b / (decimal)a;
            Console.WriteLine("X = {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid value for a! Should not be 0.");
        }
    }

    //Option 2 method.
    static void SequenceAverate()
    {
        bool isValidNumber;
        Console.Write("Please, enter the number of the integers: ");
        int numbersCount = int.Parse(Console.ReadLine());

        int sum = 0;
        isValidNumber = ValidateData(numbersCount);   //Validate count. Must be > 0.

        if (isValidNumber)
        {
            int[] numbers = new int[numbersCount];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number[{}]: ", i);
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            Console.Write("Average is: ", sum / numbersCount);   //Print average
        }
        else
        {
            Console.WriteLine("Invalid number count. Should be > 0.");
        }
    }

    //Option 1 method.
    static void ReverseANumber()
    {
        Console.WriteLine("Please enter a number: ");
        string strNumber = Console.ReadLine();

        bool isValidNumber = ValidateData(int.Parse(strNumber));   //Validate the number.
        if (isValidNumber)
        {
            Console.WriteLine(Reverse(strNumber));   //If valdiated reverse and print.
        }
        else
        {
            Console.WriteLine("Invalid number! Number should not be negative or zero.");
        }
    }

    static void Main()
    {
        Console.WriteLine("Please, enter 1 to Reverses the digits of a number.");
        Console.WriteLine("Please, enter 2 to Calculates the average of a sequence of integers.");
        Console.WriteLine("Please, enter 3 to Solves a linear equation a * x + b = 0.");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                ReverseANumber();
                break;
            case 2:
                SequenceAverate();
                break;
            case 3:
                SolveSimpleEquation();
                break;
        }
    }
}
