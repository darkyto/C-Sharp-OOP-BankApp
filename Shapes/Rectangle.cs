namespace Shapes
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }
        public override double CalculateSurface()
        {
            double result = this.Width * this.Height;
            return result;
        }
    }
}
