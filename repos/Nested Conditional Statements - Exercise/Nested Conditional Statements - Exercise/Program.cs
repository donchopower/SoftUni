using System;

namespace Nested_Conditional_Statements___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double total = 0;

            if(ticketType == "Premiere")
            {
                ticketPrice = 12;

                total = ticketPrice * (rows * columns);
            }else if(ticketType == "Normal")
            {
                ticketPrice = 7.50;
                total = ticketPrice * (rows * columns);
            }else if(ticketType == "Discount")
            {
                ticketPrice = 5;
                total = ticketPrice * (rows * columns);
            }
            Console.WriteLine($"{total}");



        }
    }
}
