using System;

namespace puppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKG = int.Parse(Console.ReadLine());
            int foodInGrams = foodInKG * 1000;
            int foodEaten = 0;
            string input = Console.ReadLine();
            
           

            while(input != "Adopted")
            {
                int portions = int.Parse(input);
                foodEaten = foodEaten + portions;
                input = Console.ReadLine();
                
            }
            if(foodEaten <= foodInGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGrams - foodEaten} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodInGrams - foodEaten)} grams more.");
            }
          


        }
    }
}
