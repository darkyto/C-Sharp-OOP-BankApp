namespace Shapes
{
    using System;

    public class Square : Rectangle
    {
        public Square(double width)
            : base(width, width)
        {

        }

        public override double CalculateSurface()
        {
            double result = this.Width * this.Width;
            return result;
        }
    }
}
