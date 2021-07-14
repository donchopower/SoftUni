using System;

namespace PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double gpuPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            double ramPieces = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double cpuPriceInBgn = cpuPrice * 1.57;
            double gpuPriceInBgn = gpuPrice * 1.57;
            double ramPriceInBgn = ramPrice * 1.57;
            double totalRamPrice = ramPriceInBgn * ramPieces;

            double cpuPriceWithDiscount = cpuPriceInBgn - cpuPriceInBgn * percentDiscount;
            double gpuPriceWithDiscount = gpuPriceInBgn - gpuPriceInBgn * percentDiscount;
      

            double total = cpuPriceWithDiscount + gpuPriceWithDiscount + totalRamPrice;



            Console.WriteLine($"Money needed - {total:F2} leva.");

           
        }
    }
}
