using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double productPrice = 0;

            if(city == "Sofia")
            {
                if(product == "coffee")
                {
                    productPrice = 0.50;
                   
                }else if(product == "water")
                {
                    productPrice = 0.80;
                }else if(product == "beer")
                {
                    productPrice = 1.20;
                }else if(product == "sweets")
                {
                    productPrice = 1.45;

                }else if(product == "peanuts")
                {
                    productPrice = 1.60;
                }

            }else if(city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    productPrice = 0.40;

                }
                else if (product == "water")
                {
                    productPrice = 0.70;
                }
                else if (product == "beer")
                {
                    productPrice = 1.15;
                }
                else if (product == "sweets")
                {
                    productPrice = 1.30;

                }
                else if (product == "peanuts")
                {
                    productPrice = 1.50;
                }
            }else if(city == "Varna")
            {
                if (product == "coffee")
                {
                    productPrice = 0.45;

                }
                else if (product == "water")
                {
                    productPrice = 0.70;
                }
                else if (product == "beer")
                {
                    productPrice = 1.10;
                }
                else if (product == "sweets")
                {
                    productPrice = 1.35;

                }
                else if (product == "peanuts")
                {
                    productPrice = 1.55;
                }
            }

            double total = productPrice * quantity;
            Console.WriteLine(total);



            //double coffee = 0;
            //double water = 0;
            //double beer = 0;
            //double sweets = 0;
            //double peanuts = 0;
            //double total = 0;


            //switch (city)
            //{
            //    case "Sofia":
            //        coffee = 0.50;
            //        water = 0.80;
            //        beer = 1.20;
            //        sweets = 1.45;
            //        peanuts = 1.60;
            //        break;
            //    case "Plovdiv":
            //        coffee = 0.40;
            //        water = 0.70;
            //        beer = 1.15;
            //        sweets = 1.30;
            //        peanuts = 1.50;
            //        break;
            //    case "Varna":
            //        coffee = 0.45;
            //        water = 0.70;
            //        beer = 1.10;
            //        sweets = 1.35;
            //        peanuts = 1.55;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid city");
            //        break;

                  
            //}
            
            //switch (product)
            //{
            //    case "coffee":
            //        total = coffee * quantity;
            //        Console.WriteLine(total);
            //        break;
            //    case "water":
            //        total = water * quantity;
            //        Console.WriteLine(total);
            //        break;
            //    case "beer":
            //        total = beer * quantity;
            //        Console.WriteLine(total);
            //        break;
            //    case "sweets":
            //        total = sweets * quantity;
            //        Console.WriteLine(total);
            //        break;
            //    case "peanuts":
            //        total = peanuts * quantity;
            //        Console.WriteLine(total);
            //        break;




            //}
           


        }
    }
}
