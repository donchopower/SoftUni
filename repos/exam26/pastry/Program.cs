using System;

namespace pastry
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double orderedProducts = double.Parse(Console.ReadLine());
            int orderDate = int.Parse(Console.ReadLine());

            double discount = 0;

            double productPrice = 0;
            double priceSoFar = 0;
            double totalPrice = 0;
            double extraDiscount = 0;


            if (orderDate <= 15)
            {
                switch (product)
                {
                    case "Cake":
                        productPrice = 24;
                        break;
                    case "Souffle":
                        productPrice = 6.66;
                        break;
                    case "Baklava":
                        productPrice = 12.60;
                        break;
                }

            }
            else
            {
                switch (product)
                {
                    case "Cake":
                        productPrice = 28.70;
                        break;
                    case "Souffle":
                        productPrice = 9.80;
                        break;
                    case "Baklava":
                        productPrice = 16.98;
                        break;
                }
            }


           priceSoFar = orderedProducts * productPrice;


            if (orderDate <= 22)
            {

                if (priceSoFar >= 200)
                {

                    discount = priceSoFar * 0.25;

                }
                else if (priceSoFar >= 100)
                {

                    discount = priceSoFar * 0.15;
                }

               

            }
            totalPrice = priceSoFar - discount;

            if (orderDate <= 15)
            {
                extraDiscount = totalPrice * 0.10;
                Console.WriteLine($"{(totalPrice - extraDiscount):F2}");
            }
            else
            {
                Console.WriteLine($"{totalPrice:F2}");
            }


        }
    }
}
