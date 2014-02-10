using System;

class CircleAreaAndPerimeter
{
    /*Write a program that reads the radius r of a circle and prints its perimeter and area.
     */
    static void Main()
    {
        Console.Write("Please enter the circle radius: ");
        decimal radius = decimal.Parse(Console.ReadLine());

        decimal CirclePerimeter = 2 * (decimal)Math.PI * radius;
        decimal circleArea = (decimal)Math.PI * radius * radius;

        Console.WriteLine("Circle Area is: {0:0.00}", circleArea);
        Console.WriteLine("Circle Perimeter is: {0:0.00}", CirclePerimeter);

    }
}