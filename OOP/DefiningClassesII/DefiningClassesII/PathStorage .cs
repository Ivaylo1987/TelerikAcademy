namespace DefiningClassesII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    public static class PathStorage
    {
        // Fields
        private static Path pathLine;

        // Constructor
        static PathStorage()
        {
            pathLine = new Path();
        }

        // Methods
        public static Path ReadPathFromFile(string pathToFile)
        {
            if (File.Exists(pathToFile))
            {
                var reader = File.OpenText(pathToFile);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var numbers = line.Split(' ').Select( st => int.Parse(st)).ToArray();
                    pathLine.AddPoint(new Point3D(numbers[0], numbers[1], numbers[2]));
                }

                return pathLine;
            }
            else
            {
                throw new FileNotFoundException("File is not found!");
            }
        }

        public static void WritePathToFile(string pathToFile, Path path)
        {
                File.WriteAllText(pathToFile, path.ToString());
        }
    }
}
