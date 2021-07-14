using System;

namespace Godzilla_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double numOfActors = int.Parse(Console.ReadLine());
            double clothingPricePerActor = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double clothingPrice = numOfActors * clothingPricePerActor;
            if(numOfActors > 150)
            {
                clothingPrice *= 0.90;
            }

            double moneyNeeded = decor + clothingPrice;

            if(moneyNeeded > budget)
            {
                Console.WriteLine($"Not enough money!\nWingard needs {moneyNeeded - budget:F2} leva more.");

            }
            else
            {
                Console.WriteLine($"Action!\nWingard starts filming with {budget - moneyNeeded:F2} leva left.");
            }


        }
    }
}
