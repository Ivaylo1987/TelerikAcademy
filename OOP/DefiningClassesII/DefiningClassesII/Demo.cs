namespace DefiningClassesII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class Demo
    {
        static void Main()
        {
            // test 3D point class
            Point3D testPoint = new Point3D(7, 1, 4);
            Console.WriteLine(Point3D.StartPoint);
            Console.WriteLine(new string('-', 20));

            long distance = StaticDistance.CalcDistanceBetween3Dpoint(testPoint, Point3D.StartPoint);
            Console.WriteLine("Distance is {0}", distance);
            Console.WriteLine(new string('-', 20));

            // create a path with 3D points.
            Path lineOfPoint = new Path();

            lineOfPoint.AddPoint(Point3D.StartPoint);
            lineOfPoint.AddPoint(new Point3D(3, 2, 1));

            // read path form file
            Console.WriteLine("Read and write 3DPoints");
            Console.WriteLine(lineOfPoint);
            Path lineReadFromFile = PathStorage.ReadPathFromFile(@"..\..\input.txt");

            // wirite path to file
            Console.WriteLine(lineReadFromFile);
            PathStorage.WritePathToFile(@"..\..\output.txt", lineOfPoint);
            Console.WriteLine(new string('-', 20));

            GenericList<int> listOfInts = new GenericList<int>(4);

            for (int i = 0; i < 8; i++)
            {
                listOfInts.Add(i);
            }

            // remove at possition 3
            listOfInts.RemoveAt(3);
            Console.WriteLine(listOfInts);
            Console.WriteLine(new string('-', 20));

            // add 22 at possition 3
            listOfInts.InsertAt(3, 22);
            Console.WriteLine(listOfInts);
            Console.WriteLine(new string('-', 20));

            // create 2 matrixes
            Matrix<int> matrix = new Matrix<int>(2, 2);
            Matrix<int> secondMatrix = new Matrix<int>(2, 2);

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;

            secondMatrix[0, 0] = 5;
            secondMatrix[0, 1] = 6;
            secondMatrix[1, 0] = 7;
            secondMatrix[1, 1] = 8;

            // use overloaded operators
            Console.WriteLine(secondMatrix + matrix);
            Console.WriteLine(new string('-', 20));

            Console.WriteLine(secondMatrix - matrix);
            Console.WriteLine(new string('-', 20));

            Console.WriteLine(secondMatrix * matrix);
        }
    }
}
