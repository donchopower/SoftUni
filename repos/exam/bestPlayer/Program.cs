using System;

namespace bestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int bestScore = 0;
            int maxValue = -1;
            string bestPlayer = String.Empty;
            bool hatTrick = false;

            while(input != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if(goals > maxValue)
                {
                    bestPlayer = input;
                    bestScore = goals;
                    maxValue = goals;
                    if(goals >= 3)
                    {
                        hatTrick = true;
                    }

                    if(goals >= 10)
                    {
                        break;
                    }

                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            if(hatTrick == true)
            {
                Console.WriteLine($"He has scored {bestScore} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestScore} goals.");
            }

        }
    }
}
