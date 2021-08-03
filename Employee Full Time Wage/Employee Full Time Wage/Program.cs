using System;

namespace Employee_Full_Time_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME_HOURS = 8;
            int IS_FULL_TIME = 1;
            int PER_HOUR_WAGE = 20;
            int DAILY_WAGE = 0;
            Random rand = new Random();
            int present = rand.Next(0,2);
            if (present == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                DAILY_WAGE = FULL_TIME_HOURS * PER_HOUR_WAGE;
            }
            else
            {
                Console.WriteLine("Employee is Absent!");
            }
            Console.WriteLine("Daily Wage of Employee is "+DAILY_WAGE);
        }
    }
}
