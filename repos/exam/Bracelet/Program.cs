using System;

namespace Bracelet
{
    class Program
    {
        static void Main(string[] args)
        {
            double dailyAllowance = double.Parse(Console.ReadLine());
            double dailySales = double.Parse(Console.ReadLine());
            double totalExpenses = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double allowanceSaved = dailyAllowance * 5;
            double totalSales = dailySales * 5;
            double totalProfit = (allowanceSaved + totalSales) - totalExpenses;

            if (totalProfit >= giftPrice)
            {
                Console.WriteLine($"Profit: {totalProfit:F2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {Math.Abs(totalProfit - giftPrice):F2} BGN.");
            }
        }
    }
}
