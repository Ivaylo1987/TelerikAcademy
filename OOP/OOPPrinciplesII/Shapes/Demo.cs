namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Demo
    {
        static void Main()
        {
            Shape[] shapes = 
            {
                new Rectangle(10, 4),
                new Triangle(10, 4),
                new Circle(4)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("I am {0} and my surface is: {1}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
