using System;

namespace working_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            bool targetStringInArray = Array.IndexOf(days, day) >= 0;
            int[] workingHours = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, };
            bool hourInArray = Array.IndexOf(workingHours, time) >= 0;

            if (targetStringInArray)

            {
                if (hourInArray)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }


        }
    }
}

