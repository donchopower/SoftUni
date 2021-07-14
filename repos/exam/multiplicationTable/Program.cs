using System;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string number = input.ToString();
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            int result = number1 * number2 * number3;

            for(int i = 1; i < number[0]; i++)
            {
                number1 = i;
                for(int j = 1; j < number[1]; j++)
                {
                    number2 = j;
                    for(int k = 1; k < number[2]; k++)
                    {
                        number3 = k;
                    }

                }

                Console.WriteLine($"{number1} * {number2} * {number3} = {result}");
            }

            
        }
    }
}
