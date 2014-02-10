using System;

class NumberReader
{
    /* Write a method ReadNumber(int start, int end) that enters an integer 
 * number in given range [start…end]. If an invalid number or non-number
 * text is entered, the method should throw an exception. Using this method
 * write a program that enters 10 numbers:
 * a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

    static int ReadNumber(int start, int end)
    {
        if (start > end)
        {
            throw new ArgumentException("Start is bigger than end!");
        }

        int number = int.Parse(Console.ReadLine());

        if (number > end || number < start)
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }

    static void Main()
    {
        int min = -15;
        int max = 515;
        try
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number in the range of [ {0} , {1} ]", min, max);
                max = ReadNumber(min, max);
            }

        }
        catch (FormatException form)
        {
            Console.WriteLine(form.Message);
        }
        catch (ArgumentOutOfRangeException outOfRange)
        {
            Console.WriteLine(outOfRange.Message);
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
    }
}
