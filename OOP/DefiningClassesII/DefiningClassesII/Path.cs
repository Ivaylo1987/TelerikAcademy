namespace DefiningClassesII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Path
    {
        // Constructors
        public Path() 
        {
            this.PathLine = new List<Point3D>();
        }

        // Properties
        public List<Point3D> PathLine { get; set; }

        // Methods
        // Add a point
        public void AddPoint (Point3D pointToAdd)
        {
            this.PathLine.Add(pointToAdd);
        }


        public override string ToString()
        {
            return string.Join(" ", PathLine);
        }
    }
}
