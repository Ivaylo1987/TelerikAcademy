using System;

class CalculateTheSum
{
    /* Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
     */
    static void Main()
    {
        double tempSum = 0;
        double sum = 1;
        int counter = 2;

        while (Math.Abs(sum - tempSum) >= 0.001)
        {
            tempSum = sum;
            if (counter % 2 == 0)
            {
                sum += 1 / (double)counter;
            }
            else
            {
                sum += -(1 / (double)counter);
            }
            counter++;
        }
        Console.WriteLine(sum);
    }
}
