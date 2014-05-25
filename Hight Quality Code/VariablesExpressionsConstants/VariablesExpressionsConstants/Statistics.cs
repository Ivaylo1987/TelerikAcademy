namespace VariablesExpressionsConstants
{
    using System;
    
    public class Statistics // Example class to implement the methods in Task 2
    {
        private double FindMaxElement(double[] source)
        {
            var max = source[0];

            for (int i = 1; i < source.Length; i++)
            {
                if (max < source[i])
                {
                    max = source[i];
                }
            }

            return max;
        }

        private double FindMinElement(double[] source)
        {
            var min = source[0];
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < min)
                {
                    min = source[i];
                }
            }

            return min;
        }

        private double FindAverage(double[] source)
        {
            var sum = 0.0;
            for (int i = 0; i < source.Length; i++)
            {
                sum += source[i];
            }

            return sum / source.Length;
        }

        public void PrintStatistics(double[] source)
        {
            Console.Write("Max element is: ");
            Console.WriteLine(this.FindMaxElement(source));

            Console.WriteLine("Min element is: ");
            Console.WriteLine(this.FindMinElement(source));

            Console.Write("Average is: ");
            Console.WriteLine(this.FindAverage(source));
        }
    }
}
