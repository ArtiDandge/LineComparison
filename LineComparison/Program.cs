using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparison project !");
            double LengthOfLineOne;
            double LengthOfLineTwo;
            Random Number = new Random();
            double x1 = Number.Next(0, 3);
            double x2 = Number.Next(0, 3);
            double y1 = Number.Next(0, 3);
            double y2 = Number.Next(0, 3);
            double x3 = Number.Next(0, 3);
            double x4 = Number.Next(0, 3);
            double y3 = Number.Next(0, 3);
            double y4 = Number.Next(0, 3);
            LengthOfLineOne = (Math.Sqrt((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            LengthOfLineTwo = (Math.Sqrt((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3)));
            Console.WriteLine("End Points for X1 is : " + x1 + " and for Y1 is : " + y1);
            Console.WriteLine("End Points for X2 is : " + x2 + " and for Y2 is : " + y2);
            Console.WriteLine("Length of the Line is :" + LengthOfLineOne);
            Console.WriteLine("Length of the Line is :" + LengthOfLineTwo);
            if (LengthOfLineOne.Equals(LengthOfLineTwo))
            {
                Console.WriteLine("Lines are Equal");

            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }
        }
    }
}
