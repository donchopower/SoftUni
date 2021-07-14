using System;

namespace _05._Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int counterDays = 1;
            int counterHeight = 5364;

            while (text != "END")
            {
                int climbedMeters = int.Parse(Console.ReadLine());
                if (text == "Yes")
                {
                    counterDays++;
                }

                if (counterDays > 5)
                {
                    break;
                }

                counterHeight += climbedMeters;

                if (counterHeight >= 8848)
                {
                    break;
                }

                text = Console.ReadLine();
            }
            if (counterHeight >= 8848)
            {
                Console.WriteLine($"Goal reached for {counterDays} days!");
            }
            else
            {
                Console.WriteLine($"Failed!");
                Console.WriteLine($"{counterHeight}");
            }
        }
    }
}
