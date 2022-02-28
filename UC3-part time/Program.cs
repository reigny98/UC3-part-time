using System;

namespace UC3_part_time
{
    internal class Program
    {
        static void Main(string[] args)
        { 
             //constants
        int IS_FULL_TIME = 1;
        int IS_PART_TIME = 2;
        int EMP_RATE_PER_HOUR = 20;
        //Variables
        int empHrs = 0;
        int empWages = 0;
        Random random = new Random();
        //computation
        int check = random.Next(0, 3);
            if (check == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if (check == IS_PART_TIME) 
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
        empWages = empHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Emp Wages :" +empWages);

        }
    }
}
