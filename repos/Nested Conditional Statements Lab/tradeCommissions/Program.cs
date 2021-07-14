using System;

namespace tradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double deposits = double.Parse(Console.ReadLine());

            bool isShit = (deposits >= 0 && deposits <= 500);
            bool notFired = (deposits > 500 && deposits <= 1000);
            bool okayish = (deposits > 1000 && deposits <= 10000);
            bool forPromotion = (deposits > 10000);

            double commission = 0;

            if(city == "Sofia")
            {
                if (isShit)
                {
                    commission = deposits * 5 / 100;
                }else if (notFired)
                {
                    commission = deposits * 7 / 100;
                }else if (okayish)
                {
                    commission = deposits * 8 / 100;
                
                }else if (forPromotion)
                {
                    commission = deposits * 12 / 100;
                }
                else
                {
                    Console.WriteLine("error");
                }
                if (commission > 0)
                {
                    Console.WriteLine($"{commission:F2}");
                }
            }
            else if(city == "Varna")
            {
                if (isShit)
                {
                    commission = deposits * 4.5 / 100;
                }
                else if (notFired)
                {
                    commission = deposits * 7.5 / 100;
                }
                else if (okayish)
                {
                    commission = deposits * 10 / 100;

                }
                else if (forPromotion)
                {
                    commission = deposits * 13 / 100;
                }
                else
                {
                    Console.WriteLine("error");
                }
                if (commission > 0)
                {
                    Console.WriteLine($"{commission:F2}");
                }
            }
            else if (city == "Plovdiv")
            {
                if (isShit)
                {
                    commission = deposits * 5.5 / 100;
                }
                else if (notFired)
                {
                    commission = deposits * 8 / 100;
                }
                else if (okayish)
                {
                    commission = deposits * 12 / 100;

                }
                else if (forPromotion)
                {
                    commission = deposits * 14.5 / 100;
                }
                else
                {
                    Console.WriteLine("error");
                }
                if(commission > 0)
                {
                    Console.WriteLine($"{commission:F2}");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
