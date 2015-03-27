namespace Shapes
{
    using System;
    using System.Text;

    public class Triangle : Shape
    {

        public Triangle(double width, double height) 
            : base(width,height)
        {

        }
        public override double CalculateSurface()
        {
            double result = (this.Width * this.Height)/2;
            return result;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < this.Width; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
