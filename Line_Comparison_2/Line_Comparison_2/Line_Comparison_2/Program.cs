using System;

namespace Line_Comparison_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Value of x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());

            double LINE_1_LENGTH;
            double LINE_2_LENGTH;
            LINE_1_LENGTH = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            LINE_2_LENGTH = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of Line 1: " + LINE_1_LENGTH);
            Console.WriteLine("Length of Line 2: " + LINE_2_LENGTH);
            if (LINE_1_LENGTH == LINE_2_LENGTH)
            {
                Console.WriteLine("Length of Both Lines are Equal");
            }
            else
            {
                Console.WriteLine("Length of Both Lines are Noth Equal");
            }
        }
    }
}
