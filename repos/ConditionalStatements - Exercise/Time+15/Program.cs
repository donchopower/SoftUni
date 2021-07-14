using System;

namespace Time_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());


            minutes += 15;

            if(minutes > 59)
            {
                hours += 1;
                minutes = minutes % 60;
                if(hours > 23)
                {
                    hours = 0;
                }
          
               
            }
            //if(hours > 23)
            //{
            //    hours = 0;
            //}
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
