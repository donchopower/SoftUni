using System;

namespace goldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());



            double meanGold = 0;
            
            double gold = 0;


            for(int i = 0; i < locations; i++)
            {
                gold = 0;
                double meanGoldExpected = double.Parse(Console.ReadLine());
                int digDays = int.Parse(Console.ReadLine());

                for (int j = 0; j < digDays; j++)
                {
                    double dailyGold = double.Parse(Console.ReadLine());
                    gold += dailyGold;
                }

                meanGold = gold / digDays;

                if(meanGold >= meanGoldExpected)
                {
                    Console.WriteLine($"Good job! Average gold per day: {meanGold:F2}.");
                }
                else
                {
                    Console.WriteLine($"You need {Math.Abs(meanGoldExpected - meanGold):F2} gold.");
                }
            }



        }
    }
}
