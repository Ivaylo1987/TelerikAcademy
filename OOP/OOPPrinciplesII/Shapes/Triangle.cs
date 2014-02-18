namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(int height, int width)
            : base(height, width)
        {

        }

        public override decimal CalculateSurface()
        {
            return this.height * this.width / 2;
        }
    }
}
