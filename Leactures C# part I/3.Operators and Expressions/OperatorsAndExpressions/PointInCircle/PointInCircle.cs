using System;

class PointInCircle
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int radius = 5;

        // Formula used (x-a)2 + (y-b)2 < r2
        bool isInCircle = ((x * x) + (y * y) <= (radius * radius);

        if (isInCircle)
        {
            Console.WriteLine("Point ({0}, {1}) is in circle (0, 3)", x, y);
        }
        else
        {
            Console.WriteLine("Point ({0}, {1}) is NOT in circle (0, 5)", x, y);
        }
    }
}
