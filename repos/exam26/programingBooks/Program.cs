using System;

namespace programingBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerPage = double.Parse(Console.ReadLine());
            double pricePerCover = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double designerCost = double.Parse(Console.ReadLine());
            double percentageCovered = double.Parse(Console.ReadLine());


            double costsForPrinting = 899 * pricePerPage + 2 * pricePerCover;
            double discountedPrinting = costsForPrinting - (costsForPrinting * discount / 100);






            double combinedCosts = discountedPrinting + designerCost;
            double totalCosts = combinedCosts - (combinedCosts * percentageCovered / 100);

            Console.WriteLine($"Avtonom should pay {totalCosts:F2} BGN.");

        }
    }
}
