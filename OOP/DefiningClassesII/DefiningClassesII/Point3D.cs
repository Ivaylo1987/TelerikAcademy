namespace DefiningClassesII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Point3D
    {
        // Fields
        private static readonly Point3D startPoint = new Point3D(0, 0 ,0);

        // Constructor
        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // Properties
        public static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        // Methods
        public override string ToString()
        {
            return "(" + this.X + " " + this.Y + " " + this.Z + ")";
        }
    }
}
