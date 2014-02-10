using System;

class PointInCircleAndRactangle
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());

        int circleCenterX = 1;
        int circleCenterY = 1;
        int radius = 3;

        int racLeftX = -1;
        int racRightX = 5;
        int racUpY = 1;
        int racDownY = -1;

        // Formula for Circle - (x-a)2 + (y-b)2 < r2
        bool isInCircle = ((x - circleCenterX) * (x - circleCenterX)) + ((y - circleCenterY) * (y - circleCenterY)) <= (radius * radius);

        //Formula for ractangle - (Y more than upY or less than downY) or (X less than leftX or more than rightX)
        bool isOutOfRac = (y > racUpY) || (y < racDownY) || (x < racLeftX) || (x > racRightX);

        if (isInCircle && isOutOfRac)
        {
            Console.WriteLine("Point ({0}, {1}) is in circle and out of ractangle. ", x, y);
        }
        else
        {
            Console.WriteLine("Point ({0}, {1}) is NOT in circle and out of ractangle. ", x, y);
        }
        
    }
}
