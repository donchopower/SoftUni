using System;

namespace ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfComputers = double.Parse(Console.ReadLine());

            int individualRating = 0;




         
            double sales = 0;
            double meanRating = 0;
            double rating = 0;
            double possibleSales = 0;


            for(int i = 0; i < numberOfComputers; i++)
            {
                int ratingInput = int.Parse(Console.ReadLine());
              
                individualRating = ratingInput % 10;
                int inputSales = ratingInput / 10;
                possibleSales = inputSales;
               

                switch (individualRating)
                {
                    case 2:
                        possibleSales = 0;
                        break;
                    case 3:
                        possibleSales /= 2;
                        break;
                    case 4:
                        possibleSales = possibleSales * 70 / 100;
                        break;
                    case 5:
                        possibleSales = possibleSales * 85 / 100;
                        break;
                    case 6:
                        possibleSales = possibleSales;
                        break;

                        

                }

                sales += possibleSales;
                rating += individualRating;

            }





            meanRating = rating / numberOfComputers;
            Console.WriteLine($"{sales:F2}");
            Console.WriteLine($"{meanRating:F2}");


                



        }
    }
}
