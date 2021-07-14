using System;

namespace workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kilometers = double.Parse(Console.ReadLine());
            double totalKm = kilometers;



            for(int i = 0; i < days; i++)
            {
                int percentage = int.Parse(Console.ReadLine());

                kilometers = kilometers + kilometers * percentage / 100;
                totalKm += kilometers;
               


            }

            if(totalKm >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKm - 1000)} more   kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalKm)} more kilometers");
            }
        }
    }
}
