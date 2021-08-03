using System;

namespace Employee_Part_Time_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int FULL_TIME_HOUR = 12;
            int PART_TIME_HOUR = 8;
            int WAGE_PER_HOUR = 20;
            int DAILY_WAGE = 0;
            Random rand = new Random();
            int present = rand.Next(0, 3);
            if (present == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                DAILY_WAGE = FULL_TIME_HOUR * WAGE_PER_HOUR;
            }
            else if (present == IS_PART_TIME)
            {
                Console.WriteLine("Employee is present but for part time work");
                DAILY_WAGE = PART_TIME_HOUR * WAGE_PER_HOUR;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Daily Wage of a Employee is "+DAILY_WAGE);
        }
    }
}
