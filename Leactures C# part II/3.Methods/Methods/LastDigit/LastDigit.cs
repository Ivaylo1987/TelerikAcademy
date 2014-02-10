using System;

class LastDigit
{
    /* Write a method that returns the last digit of given integer as an English word.
     * Examples: 512  "two", 1024  "four", 12309  "nine".
     */
    static string LastDigitName(int numberToCheck) 
    {
        int lastDigit = numberToCheck % 10;
        string result = string.Empty;

        switch (lastDigit)
        {
            case 0:
                result = "Zero";
                break;
            case 1:
                result = "One";
                break;
            case 2:
                result = "Two";
                break;
            case 3:
                result = "Three";
                break;
            case 4:
                result = "Four";
                break;
            case 5:
                result = "Five";
                break;
            case 6:
                result = "Six";
                break;
            case 7:
                result = "Seven";
                break;
            case 8:
                result = "Eight";
                break;
            case 9:
                result = "Ninene";
                break;
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Please, enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(LastDigitName(number));
    }
}
