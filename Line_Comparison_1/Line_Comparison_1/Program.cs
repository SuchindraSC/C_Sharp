using System;

namespace Line_Comparison_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 4;
            int y1 = 5;
            int x2 = 7;
            int y2 = 9;
            double LENGTH_OF_LINE;
            LENGTH_OF_LINE = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The Length of Line = " + LENGTH_OF_LINE);
        }
    }
}
