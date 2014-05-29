namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        public Rectangle(double width, double height)
        {
            if (width < 0 || height < 0)
            {
                throw new ArgumentOutOfRangeException("Width and hight should not be negative.");
            }

            this.Height = height;
            this.Width = width;
        }

        public virtual double Width { get; private set; }

        public virtual double Height { get; private set; }

        public override double CalcPerimeter()
        {
            var result = (this.Height + this.Width) * 2;
            return result;
        }

        public override double CalcSurface()
        {
            var result = this.Height * this.Width;
            return result;
        }
    }
}
