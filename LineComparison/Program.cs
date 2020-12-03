using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparison project !");
            double LengthOfLine;
            Random Number = new Random();
            double x1 = Number.Next(0, 3);
            double x2 = Number.Next(0, 3);
            double y1 = Number.Next(0, 3);
            double y2 = Number.Next(0, 3);
            LengthOfLine = (Math.Sqrt((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("End Points for X1 is : " + x1 + " and for Y1 is : " + y1);
            Console.WriteLine("End Points for X2 is : " + x2 + " and for Y2 is : " + y2);
            Console.WriteLine("Length of the Line is :" + LengthOfLine);
        }
    }
}
