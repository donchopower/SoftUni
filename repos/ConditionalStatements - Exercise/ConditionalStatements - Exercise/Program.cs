using System;

namespace ConditionalStatements___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int sumTime = time1 + time2 + time3;

            int timeInMins = sumTime / 60;
            int timeInSeconds = sumTime % 60;

            Console.WriteLine($"{timeInMins}:{timeInSeconds:D2}");

            //if(timeInSeconds >= 10)
            //{
            //    Console.WriteLine($"{timeInMins}:{timeInSeconds}");
            //}
            //else
            //{
            //    Console.WriteLine($"{timeInMins}:0{timeInSeconds}");
            //        }

        }
    }
}
