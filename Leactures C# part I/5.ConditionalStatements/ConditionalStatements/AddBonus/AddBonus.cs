using System;

class AddBonus
{
    static void Main()
    {
        /* Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input.
         * If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000.
         * If it is zero or if the value is not a digit, the program must report an error.
		 * Use a switch statement and at the end print the calculated new value in the console.
         */

        Console.Write("Please, enter current soce: ");
        int currentScore = int.Parse(Console.ReadLine());

        Console.Write("Please, enter option for bonus [1..9]: ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
            case 2:
            case 3:
                currentScore *= 10;
                Console.WriteLine(currentScore);
                break;

            case 4:
            case 5:
            case 6:
                currentScore *= 100;
                Console.WriteLine(currentScore);
                break;

            case 7:
            case 8:
            case 9:
                currentScore *= 1000;
                Console.WriteLine(currentScore);
                break;

            default:
                Console.WriteLine("bo0m!"); //error
                break;
        }
    }
}
