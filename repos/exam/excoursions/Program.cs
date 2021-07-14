using System;

namespace excoursions
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaExcoursions = int.Parse(Console.ReadLine());
            int mountainExcoursions = int.Parse(Console.ReadLine());

            int seaPrice = 680;
            int mountainPrice = 499;

            int profit = 0;

            int seaCounter = 0;
            int mountainCounter = 0;

            string input = Console.ReadLine();

            while (true)
            {
                if(input == "sea")
                {
                    if(seaCounter < seaExcoursions)
                    {

                        seaCounter++;
                        profit += seaPrice;

                    }
                }

                if(input == "mountain")
                {

                    if(mountainCounter < mountainExcoursions)
                    {
                        mountainCounter++;
                            profit += mountainPrice;
                    }
                }

                if(seaCounter == seaExcoursions && mountainCounter == mountainExcoursions)
                {
                    Console.WriteLine($"Good job! Everything is sold.");
                    Console.WriteLine($"Profit: {profit} leva.");
                    break;
                }

                Console.WriteLine($"Profit: {profit} leva.");
                input = Console.ReadLine();




            }

        }
    }
}
