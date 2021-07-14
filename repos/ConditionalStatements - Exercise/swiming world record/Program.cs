using System;

namespace swiming_world_record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double meterSwamInSeconds = double.Parse(Console.ReadLine());


            double timeToSwim = distance * meterSwamInSeconds;
            double delay = Math.Floor(distance / 15) * 12.5;


            double totalTime = timeToSwim + delay;

            if(totalTime >= recordInSeconds)
            {

                Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
        }
    }
}
