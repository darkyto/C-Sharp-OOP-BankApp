namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class ConsoleTests
    {
        private const char dv = '-';

        static void Main(string[] args)
        {
            Line(dv, 50);
            Console.WriteLine("         PROBLEM 3 - Testing Range Exceptions!");
            Line(dv, 50);

            /* Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
             * It should hold error message and a range definition [start … end].
             * 
             * Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
             * by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
             */
            Console.WriteLine("Enter a number OUT of range to provoke the custom exception");
            int num = int.Parse(Console.ReadLine());
            if (num < 0 || num > 100)
            {
                throw new InvalidRangeException<int>("\nExcetion messgage : Out of RANGE!", 0 , 100);
            }

            Line(dv, 50);
            Console.WriteLine("Now TEST with a date (pre-declared range 05-01-2015 05-15-2015)");

            var firstDate = new DateTime(2015, 05, 01);
            var secondDate = new DateTime(2015, 05, 15);

            Console.WriteLine("Entere a date in format \"dd/MM/yyyy\"");
            var date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy" , CultureInfo.InvariantCulture);

            if (firstDate < date || secondDate > date)
            {
                throw new InvalidRangeException<DateTime>("\nEntered date OUT OF RANGE!",firstDate, secondDate);
            }

        }
        public static void Line(char symbol, int lenght)
        {
            Console.WriteLine(new string(symbol,lenght));
        }
    }
}
