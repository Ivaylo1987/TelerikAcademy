using System;

class HandleExceptionSqrt
{
    /* Write a program that reads an integer number and calculates and prints its square root.
     * If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye".
     * Use try-catch-finally.
     */
    static double SquareRoot(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException("The provided number is invalid");
        }

        return Math.Sqrt(number);
    }

    static void Main()
    {
        try
        {
            SquareRoot(-1);
        }
        catch (ArgumentOutOfRangeException exp)
        {

            Console.WriteLine(exp.Message);
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }

}
