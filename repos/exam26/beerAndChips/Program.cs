using System;

namespace beerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            double beers = double.Parse(Console.ReadLine());
            double chips = double.Parse(Console.ReadLine());

            double beerPrice = 1.20;

            double totalBeerPrice = beers * beerPrice;

            double chipsPrice = totalBeerPrice * 0.45;
            double totalChipsPrice = Math.Ceiling(chips * chipsPrice);

            double totalCosts = totalBeerPrice + totalChipsPrice;

            if(totalCosts <= budget)
            {
                Console.WriteLine($"{name} bought a snack and has {(budget-totalCosts):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {Math.Abs(budget-totalCosts):F2} more leva!");
            }
        }
    }
}
