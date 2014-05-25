namespace VariablesExpressionsConstants
{
    //Task 1
    using System;

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Size GetRotatedSize(Size size, double angleOfRotation)
        {
            var newWidth = (Math.Abs(Math.Cos(angleOfRotation)) * size.Width) + (Math.Abs(Math.Sin(angleOfRotation)) * size.Height);
            var newHeight = (Math.Abs(Math.Sin(angleOfRotation)) * size.Width) + (Math.Abs(Math.Cos(angleOfRotation)) * size.Height);
            var result = new Size(newWidth, newHeight);

            return result;
        }
    }
}
