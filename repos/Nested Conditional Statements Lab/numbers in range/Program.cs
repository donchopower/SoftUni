﻿using System;

namespace numbers_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());


            //if(number >= -100 && number <= 100 && number != 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            if(number >= -100 && number <= 100)
            {
                if(number != 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
