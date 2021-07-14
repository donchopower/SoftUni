using System;

namespace skiVacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysSpent = double.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string score = Console.ReadLine();

            double roomCost = 0;
            double discount = 0;
            double scoreTax = 0;
            double total = 0;

            if (roomType == "room for one person")
            {
                roomCost = 18;
                total = (daysSpent - 1) * roomCost;
                if (score == "positive")
                {
                    scoreTax = total * 25 / 100;
                    total += scoreTax;
                }
                else if (score == "negative")
                {
                    scoreTax = total * 10 / 100;
                    total -= scoreTax;

                }
                Console.WriteLine($"{total:F2}");
            }


            else if (roomType == "apartment")
            {
                roomCost = 25;
                total = roomCost * (daysSpent - 1);


                if (daysSpent < 10)
                {
                    discount = total - total * 0.70;
                    total -= discount;
                }
                else if (daysSpent >= 10 && daysSpent <= 15)
                {
                    discount = total - total * 0.65;
                    total -= discount;
                }
                else if (daysSpent > 15)
                {
                    discount = total - total * 0.50;
                    total -= discount;
                }


                if (score == "positive")
                {
                    scoreTax = total * 25 / 100;
                    total += scoreTax;
                }
                else if (score == "negative")
                {
                    scoreTax = total * 10 / 100;
                    total -= scoreTax;
                }
                Console.WriteLine($"{total:F2}");
            }

            else if (roomType == "president apartment")
            {
                roomCost = 35;
                total = roomCost * (daysSpent - 1);


                if (daysSpent < 10)
                {
                    discount = total - total * 0.90;
                    total -= discount;
                }
                else if (daysSpent >= 10 && daysSpent <= 15)
                {
                    discount = total - total * 0.85;
                    total -= discount;
                }
                else if (daysSpent > 15)
                {
                    discount = total - total * 0.80;
                    total -= discount;
                }


                if (score == "positive")
                {
                    scoreTax = total * 25 / 100;
                    total += scoreTax;
                }
                else if (score == "negative")
                {
                    scoreTax = total * 10 / 100;
                    total -= scoreTax;
                }
                Console.WriteLine($"{total:F2}");
            }
        }
    }
}
