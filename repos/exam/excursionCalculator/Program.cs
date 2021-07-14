using System;

namespace excursionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double tourists = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double pricePerPerson = 0;

            if(tourists <= 5)
            {
                switch (season)
                {
                    case "spring":
                        pricePerPerson = 50;
                        break;
                    case "summer":
                        pricePerPerson = 48.50;
                        break;
                    case "autumn":
                        pricePerPerson = 60;
                        break;
                    case "winter":
                        pricePerPerson = 86;
                        break;
                }


            }
            else
            {
                switch (season)
                {
                    case "spring":
                        pricePerPerson = 48;
                        break;
                    case "summer":
                        pricePerPerson = 45;
                        break;
                    case "autumn":
                        pricePerPerson = 49.50;
                        break;
                    case "winter":
                        pricePerPerson = 85;
                        break;
                }
            }

            double totalPrice = pricePerPerson * tourists;
            if(season == "summer")
            {

                totalPrice = totalPrice - ((totalPrice * 15) / 100);

            }else if(season == "winter")
            {
                totalPrice = totalPrice + ((totalPrice * 8) / 100);
            }

            Console.WriteLine($"{totalPrice:F2} leva.");

        }
    }
}
