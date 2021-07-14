using System;

namespace fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double productPrice = 0;

            bool isWeekday = (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday");
            bool isWeekend = (day == "Saturday" || day == "Sunday");


            if (!isWeekday && !isWeekend)
            {
                Console.WriteLine("error");
            }
            else if (isWeekday)
            {
                switch (fruit)
                {
                    case "banana":
                        productPrice = 2.50;
                        break;
                    case "apple":
                        productPrice = 1.20;
                        break;
                    case "orange":
                        productPrice = 0.85;
                        break;
                    case "grapefruit":
                        productPrice = 1.45;
                        break;
                    case "kiwi":
                        productPrice = 2.70;
                        break;
                    case "pineapple":
                        productPrice = 5.50;
                        break;
                    case "grapes":
                        productPrice = 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;


                }


            }

            else if (isWeekend)
            {
                switch (fruit)
                {
                    case "banana":
                        productPrice = 2.70;
                        break;
                    case "apple":
                        productPrice = 1.25;
                        break;
                    case "orange":
                        productPrice = 0.90;
                        break;
                    case "grapefruit":
                        productPrice = 1.60;
                        break;
                    case "kiwi":
                        productPrice = 3.00;
                        break;
                    case "pineapple":
                        productPrice = 5.60;
                        break;
                    case "grapes":
                        productPrice = 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }


              



            }
            double total = productPrice * quantity;
            if(productPrice != 0) { 
            Console.WriteLine($"{total:F2}");
            }
        }
        
    }
}
