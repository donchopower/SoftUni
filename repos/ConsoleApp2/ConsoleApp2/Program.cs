
using System;

namespace FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pricePerKgPerMackerel = decimal.Parse(Console.ReadLine());
            decimal pricePerKgPerSpratFish = decimal.Parse(Console.ReadLine());
            double bonitoInKg = double.Parse(Console.ReadLine());
            double horseMackerelInKg = double.Parse(Console.ReadLine());
            double musselsInKg = double.Parse(Console.ReadLine());

            decimal pricePerBonitoPerKg = pricePerKgPerMackerel * (decimal)1.6;
            decimal sumPerBonito = pricePerBonitoPerKg * (decimal)bonitoInKg;
            decimal pricePerHorseMackerelPerKg = pricePerKgPerSpratFish * (decimal)1.8;
            decimal sumPerHorseMackerel = pricePerHorseMackerelPerKg * (decimal)horseMackerelInKg;
            decimal pricePerMusselsPerKg = 7.50M;
            decimal sumPerMassels = pricePerMusselsPerKg * (decimal)musselsInKg;

            decimal totalFundsNeeded = (sumPerBonito + sumPerHorseMackerel) + sumPerMassels;

            //Console.Write(Math.Round(totalFundsNeeded, 2));
            Console.Write($"{totalFundsNeeded:F2}");
        }
    }
}
