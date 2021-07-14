using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double tripPrice = double.Parse(Console.ReadLine());
            double puzzles = double.Parse(Console.ReadLine());
            double dolls = double.Parse(Console.ReadLine());
            double teddyBears = double.Parse(Console.ReadLine());
            double minions = double.Parse(Console.ReadLine());
            double trucks = double.Parse(Console.ReadLine());

            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double teddyBearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double totalOrderedToys = puzzles + dolls + teddyBears + minions + trucks;
            double subtotal = puzzles * puzzlePrice + dolls * dollPrice + teddyBears * teddyBearPrice + minions * minionPrice + trucks * truckPrice;
            double discount = 0;

            if(totalOrderedToys >= 50)
            {
                discount = subtotal * 0.25;
                
            }

            double total = subtotal - discount;
            double rent = total * 0.10;
            double moneyLeft = total - rent;
           
            

            if (moneyLeft >= tripPrice)
            {
                Console.WriteLine($"Yes! {(moneyLeft - tripPrice):F2} lv left.");

            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(moneyLeft - tripPrice):F2} lv needed.");
            }
            

           



        }
    }
}


//if (totalorderedtoys >= 50)
//{
//    double discount = subtotal * 0.25;

//    double totalbill = subtotal - discount;

//    double moneyleft = totalbill - (totalbill * 0.10);



//       if (moneyleft >= tripprice)
//        {
//        console.writeline($"yes! {moneyleft} lv left.");
//    }
//    else
//    {
//        console.writeline($"not enough money! {moneyleft} lv needed.");
//    }

//}
//else
//{
//    double total = subtotal - tripprice;
//    if (total >= tripprice)
//    {
//        console.writeline($"yes! {total} lv left.");
//    }
//    else
//    {
//        console.writeline($"not enough money! {total} lv needed.");
//    }
//}