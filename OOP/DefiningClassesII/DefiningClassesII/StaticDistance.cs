namespace DefiningClassesII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class StaticDistance
    {
        public static long CalcDistanceBetween3Dpoint(Point3D first, Point3D second)
        {
            long result = (long)Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2) + Math.Pow(first.Z - second.Z, 2));

            return result;
        }
    }
}
