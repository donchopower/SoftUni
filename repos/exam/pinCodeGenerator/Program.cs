using System;

namespace pinCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumMax = int.Parse(Console.ReadLine());
            int secondNumMax = int.Parse(Console.ReadLine());
            int thirdNumMax = int.Parse(Console.ReadLine());

            //int firstNum = 0;
            //int secondNum = 0;
            //int thirdNum = 0;

            for (int i = 0; i < firstNumMax; i++)
            {
                if (i != 0 && i % 2 == 0)
                {
                    //firstNum = i;
                }

                for (int j = 0; j < secondNumMax; j++)
                {

                    if (j != 0 && j % 2 != 0 && j / j == 1)
                    {
                        //secondNum = j;
                    }

                    for (int k = 0; k < thirdNumMax; k++)
                    {
                        if ((k != 0 && k % 2 == 0) && (i != 0 && i % 2 == 0) && (j != 0 && j / j == 1 && j % 2 == 0))
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }


                }

            }

            // Console.WriteLine($"{firstNum} {secondNum} {thirdNum}");
        }
    }
}
