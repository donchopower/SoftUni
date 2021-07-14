using System;

namespace fruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] fruits = new string[] { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
            bool isFruit = Array.IndexOf(fruits, input) >= 0;

            string[] vegetables = new string[] { "tomato", "cucumber", "pepper", "carrot" };
            bool isVegetable = Array.IndexOf(vegetables, input) >= 0;

            if (isFruit || isVegetable)
            {
                if (isVegetable)
                {
                    Console.WriteLine("vegetable");
                }
                else { 
                Console.WriteLine("fruit");
                }
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
