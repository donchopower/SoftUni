using System;

namespace grandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double liters = 0;
            double degrees = 0;

            for(int i = 0; i < days; i++)
            {
                double dailyLiters = double.Parse(Console.ReadLine());
                liters += dailyLiters;
                double dailyDegrees = double.Parse(Console.ReadLine());
                degrees = degrees + dailyLiters * dailyDegrees;
            
                
            }
            double totalDegrees = degrees / liters;

            Console.WriteLine($"Liters: {liters:F2}");
            Console.WriteLine($"Degrees: {totalDegrees:F2}");
            if(totalDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if(totalDegrees >= 38 && totalDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if(totalDegrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }

        }
    }
}
