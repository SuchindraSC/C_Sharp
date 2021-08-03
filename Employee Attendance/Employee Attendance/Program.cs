using System;

namespace Employee_Attendance
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random rand = new Random();
            int present = rand.Next(0,2);
            if (present == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
           
        }
    }
}
