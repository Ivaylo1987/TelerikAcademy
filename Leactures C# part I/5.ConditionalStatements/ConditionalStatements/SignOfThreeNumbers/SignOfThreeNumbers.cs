using System;

class SignOfThreeNumbers
{
    static void Main()
    {
        /* Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
         * Use a sequence of if statements.
         */

        Console.Write("Please, enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        // If any of the numbers is 0 -> the product is 0.
        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The product of the three numbers is 0.");
        }
        else
        {
            if (firstNumber * secondNumber > 0)      // If product of 1 and 2 is positive.
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            else                                     //If product of 1 and 2 is negative.
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
        }
    }
}
