using System;

class Trapezoid
{
    static void Main()
    {
        decimal sideA = decimal.Parse(Console.ReadLine());
        decimal sideB = decimal.Parse(Console.ReadLine());
        decimal height = decimal.Parse(Console.ReadLine());

        decimal area = ((sideA + sideB) * height) / 2;
        Console.WriteLine(" The area of the trapezoid is {0}", area);
    }
}