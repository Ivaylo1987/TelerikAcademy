using System;

class QuadraticEquasion
{
    /* Write a program that reads the coefficients a, b and c of a quadratic equation
     * ax2+bx+c=0 and solves it (prints its real roots).
     */

    static void Main()
    {
        Console.WriteLine("Quadratic equation");
        Console.Write("Please, enter coefficient \"a\": ");
        int coefA = int.Parse(Console.ReadLine());

        Console.Write("Please, enter coefficient \"b\": ");
        int coefB = int.Parse(Console.ReadLine());

        Console.Write("Please, enter coefficient \"c\": ");
        int coefC = int.Parse(Console.ReadLine());

        int discrim = (coefB * coefB) - 4 * coefA * coefC;

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
