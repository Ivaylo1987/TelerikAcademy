using System;

class VariableNumActions
{
    /* Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
     * Use variable number of arguments.
     */
    static int MinValue(params int[] numbers)
    {
        int min = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }

        return min;
    }

    static int MaxValue(params int[] numbers)
    {
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }

        return max;
    }

    static int Average(params int[] numbers)
    {
        return Sum(numbers) / numbers.Length;
    }

    static int Sum(params int[] numbers) 
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    static int Product(params int[] numbers) 
    {
        int product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }

        return product;
    }

    static void Main()
    {
        int min = MinValue(-1, 3, 4, 17, 100, 0, 2);
        int max = MaxValue(-1, 3, 4, 17, 100, 0, 2);
        int average = Average(-1, 3, 4, 17, 100, 0, 2);
        int sum = Sum(-1, 3, 4, 17, 100, 0, 2);
        int product = Product(-1, 3, 4, 17, 100, 0, 2);

        Console.WriteLine("Min: {0}, Max: {1}, Average: {2}, Sum: {3}, produst: {4}", min, max, average, sum, product);
    }
}
