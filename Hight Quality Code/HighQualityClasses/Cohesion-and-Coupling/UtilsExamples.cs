using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileNameUtils.GetFileExtension("example"));
            Console.WriteLine(FileNameUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameUtils.GetFileExtension("example.new.pdf"));
                              
            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                PointUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                PointUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            var cube = new Cuboid(3, 4, 5);
            cube.Width = 3;
            cube.Height = 4;
            cube.Depth = 5;

            Console.WriteLine("Volume = {0:f2}", cube.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", cube.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", cube.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", cube.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", cube.CalcDiagonalYZ());
        }
    }
}
