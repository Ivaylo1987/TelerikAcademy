using System;

class QuadraticEquation
{
    static void Main()
    {
        /* Write a program that enters the coefficients a, b and c of a quadratic equation
         * a*x2 + b*x + c = 0 and calculates and prints its real roots.
         * Note that quadratic equations may have 0, 1 or 2 real roots.
         */

        Console.WriteLine("Quadratic equation");
        Console.Write("Please, enter coefficient \"a\": ");
        int coefA = int.Parse(Console.ReadLine());

        Console.Write("Please, enter coefficient \"b\": ");
        int coefB = int.Parse(Console.ReadLine());

        Console.Write("Please, enter coefficient \"c\": ");
        int coefC = int.Parse(Console.ReadLine());

        //calculate discirminant
        int discrim = (coefB * coefB) - 4 * coefA * coefC;

        //calculate roots if any
        if (discrim < 0)
        {
            Console.WriteLine("Equation has no real roots.");
        }
        else if (discrim == 0)
        {
            double result = -(coefB / (double)(2 * coefA));

            Console.WriteLine("Equasion has one root = {0}", result);
        }
        else
        {
            double firstRoot = (double)(-coefB + Math.Sqrt(discrim)) / (2 * coefA);
            double secondRoot = (double)(-coefB - Math.Sqrt(discrim)) / (2 * coefA);

            Console.WriteLine("Equasion has two roots: {0} and {1}", firstRoot, secondRoot);
        }
    }
}
