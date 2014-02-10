using System;

/*Write a program that safely compares floating-point numbers with precision of 0.000001.
 * Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
 */
class Comparison
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        bool result;
        //double a = 5.00000001;
        //double b = 5.00000003;
        result = (Math.Abs(a - b) < 0.000001);
        Console.WriteLine(result);
    }
}
