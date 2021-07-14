using System;

namespace whileLoop_and_shit__
{
    class Program
    {

        static void Main(string[] args)
        {

            double amount = 0;
            string input = (Console.ReadLine());

            

            while (input != "NoMoreMoney") 
            {
                double deposit = double.Parse(input);
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
                amount += deposit;
                Console.WriteLine($"Increase: {deposit:F2}");
                input = (Console.ReadLine());

            }
            Console.WriteLine($"Total: {amount:F2}");





        }
    }
}
