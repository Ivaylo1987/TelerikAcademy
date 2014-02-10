using System;

class RactangleArea
{
    static void Main()
    {
        Console.Write("Please, enter height: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Please, enter width: ");
        int width = int.Parse(Console.ReadLine());
        int racArea = height * width;
        Console.WriteLine("Ractangle area is {0}." , racArea);
    }
}
