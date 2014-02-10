using System;

class TriangleSurf
{
    /* Write methods that calculate the surface of a triangle by given:
     * Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
     */

    static void SurfaceBySideAndHeight(double side, double height)
    {
        double surf = 0;
        surf = (side * height) / 2;
        Console.WriteLine(surf);
    }

    static void SurfaceByThreeSide(double sideA, double sideB, double sideC)
    {
        double surf = 0;
        double semiPerim = (sideA + sideB + sideC) / 2;

        surf = Math.Sqrt(semiPerim * (semiPerim - sideA) * (semiPerim - sideB) * (semiPerim - sideC));

        Console.WriteLine(surf);
    }

    static void SurfaceByAngleAndTwoSides(double sideA, double sideB, double angle)
    {
        double surf = 0;
        surf = (sideB * sideB * Math.Sin(angle)) / 2;
        Console.WriteLine(surf);
    }

    static void Main()
    {
        SurfaceByAngleAndTwoSides(12, 4 , 60 * Math.PI / 180);   //Degrees to radians degree * Pi / 180.
        SurfaceBySideAndHeight(3, 5);
        SurfaceByThreeSide(10, 18, 10);

    }
}
