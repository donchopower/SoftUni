using System;
using System.Linq;

namespace invalidNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            bool isValid = (number >= 100 && number <= 200) || number == 0;

            if (!isValid)
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
