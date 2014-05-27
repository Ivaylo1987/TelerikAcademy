using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Triagle must have positive side lengths!");
            }

            if (a + b <= c ||
                a + c <= b ||
                c + b <= b)
            {
                throw new ArgumentException("These values do not form a triangle.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default: throw new ArgumentException("Invalid value is provided!");
            }
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Elements value cannot be null.");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("Provide at least one argument.");
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (max < elements[i])
                {
                    max = elements[i];
                }
            }

            return max;
        }

        static void PrintAsTwoSymbolDecimal(object number)
        {
            if (number == null)
            {
                throw new ArgumentNullException("Number cannot be null");
            }

            Console.WriteLine("{0:f2}", number);
        }

        static void PrintAsPercentage(object number)
        {
            if (number == null)
            {
                throw new ArgumentNullException("Number cannot be null");
            }

            Console.WriteLine("{0:p0}", number);
        }

        static void PrintRightAlignedByEight(object number)
        {
            if (number == null)
            {
                throw new ArgumentNullException("Number cannot be null");
            }

            Console.WriteLine("{0,8}", number);
        }

        //This one is refactered to the upper 3 methods.

        //static void PrintAsNumber(object number, string format)
        //{
        //    if (format == "f")
        //    {
        //        Console.WriteLine("{0:f2}", number);
        //    }

        //    if (format == "%")
        //    {
        //        Console.WriteLine("{0:p0}", number);
        //    }

        //    if (format == "r")
        //    {
        //        Console.WriteLine("{0,8}", number);
        //    }
        //}

        static bool isVertical(double x1, double y1, double x2, double y2)
        {
            return x1 == x2;
        }

        static bool isHorizontal(double x1, double y1, double x2, double y2)
        {
            return y1 == y2;
        }

        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            if (x1 == null ||
                x2 == null ||
                y1 == null ||
                y2 == null)
            {
                throw new ArgumentNullException("Values should not be null");
            }

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsTwoSymbolDecimal(1.3);
            PrintAsPercentage(0.75);
            PrintRightAlignedByEight(2.30);

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + isHorizontal(3, -1, 3, 2.5));
            Console.WriteLine("Vertical? " + isVertical(3, -1, 3, 2.5));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
