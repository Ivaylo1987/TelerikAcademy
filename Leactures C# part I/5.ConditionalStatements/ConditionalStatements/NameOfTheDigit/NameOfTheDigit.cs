using System;

class NameOfTheDigit
{
    static void Main()
    {
        /* Write program that asks for a digit and depending on the input
         * shows the name of that digit (in English) using a switch statement.
         */

        Console.Write("Please, enter a digit [0..9]: ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            default:
                Console.WriteLine("bo0m!");
                break;
        }
    }
}
