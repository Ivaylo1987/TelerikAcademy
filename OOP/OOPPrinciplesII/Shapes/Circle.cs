namespace Shapes
{
    using System;

    class Circle : Shape
    {
        public Circle(int radius)
            : base(radius, radius)
        {
        }

        public override decimal CalculateSurface()
        {
            return (decimal)(this.height * this.height * Math.PI);
        }
    }
}
