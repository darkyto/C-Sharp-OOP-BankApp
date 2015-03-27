namespace Shapes
{
    using System;

    public class ConsoleTests
    {
        static void Main(string[] args)
        {

            /* OK==== Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. ====OK
             * OK==== Define two new classes Triangle and Rectangle that implement the virtual method and return the surface ====OK 
             * OK==== of the figure (heightwidth for rectangle and heightwidth/2 for triangle). ====OK
             * OK==== Define class Square and suitable constructor so that at initialization  ====OK
             * OK==== height must be kept equal to width and implement the CalculateSurface() method. ====OK
             * OK==== Write a program that tests the behaviour of the CalculateSurface() method for  ====OK
             * OK==== different shapes (Square, Rectangle, Triangle) stored in an array. ====OK
             */
            Line('=', 50); Console.WriteLine("      Problem 005 - OOP Principles Part Two"); Line('=', 50);

            Line('-', 50);
            Triangle myTrangle = new Triangle(5 ,5);
            Console.WriteLine("Calculating surface area of triangle \nwith Width: {0} and Height: {1}", myTrangle.Width, myTrangle.Height);
            Console.WriteLine("Surface area : {0}", myTrangle.CalculateSurface()); Line('-', 50);

            Console.WriteLine("Test for creatng new Rectangle");
            Rectangle myRectangle = new Rectangle(2, 4);
            Console.WriteLine("Width {0} and Height {1}", myRectangle.Width, myRectangle.Height);
            Console.WriteLine(myRectangle.CalculateSurface()); Line('-', 50);

            Console.WriteLine("Test for new Square");
            Square mySquare = new Square(6);
            Console.WriteLine("Square side : {0}",mySquare.Width);
            Console.WriteLine("Square surface : {0}", mySquare.CalculateSurface()); Line('-', 50);

            Shape[] myShapes = new Shape[3];
            myShapes[0] = myRectangle;
            myShapes[1] = mySquare;
            myShapes[2] = myTrangle;

            foreach (var shape in myShapes)
            {
                Console.WriteLine("shapes width {0} and height {1}", shape.Width , shape.Height);
                Console.WriteLine("Surface area of the current shape : {0}", shape.CalculateSurface());
            }

        }
        public static void Line(char symbol, int lenght)
        {
            Console.WriteLine(new string(symbol,lenght));
        }
    }
}
