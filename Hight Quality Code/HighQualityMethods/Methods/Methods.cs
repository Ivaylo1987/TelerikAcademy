namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
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

        public static string NumberToDigit(int number)
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

        public static int FindMax(params int[] elements)
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

        public static void PrintAsTwoSymbolDecimal(object number)
        {
            if (number == null)
            {
                throw new ArgumentNullException("Number cannot be null");
            }

            Console.WriteLine("{0:f2}", number);
        }

       public static void PrintAsPercentage(object number)
        {
            if (number == null)
            {
                throw new ArgumentNullException("Number cannot be null");
            }

            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintRightAlignedByEight(object number)
        {
            if (number == null)
            {
                throw new ArgumentNullException("Number cannot be null");
            }

            Console.WriteLine("{0,8}", number);
        }

        // double is not a nullable type so no need for checks.
        public static bool ArePointsVertical(double x1, double y1, double x2, double y2)
        {
            return x1 == x2;
        }

       public static bool ArePointsHorizontal(double x1, double y1, double x2, double y2)
        {
            return y1 == y2;
        }

       public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsTwoSymbolDecimal(1.3);
            PrintAsPercentage(0.75);
            PrintRightAlignedByEight(2.30);

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + ArePointsHorizontal(3, -1, 3, 2.5));
            Console.WriteLine("Vertical? " + ArePointsVertical(3, -1, 3, 2.5));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia";
            peter.BirthDay = new DateTime(1992, 03, 17);

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.BirthDay = new DateTime(1993, 11, 3);
            stella.OtherInfo = "From Vidin, gamer, high results";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella.BirthDay));
        }
    }
}
