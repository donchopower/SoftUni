using System;

namespace metricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            float numberIn = float.Parse(Console.ReadLine());
            string convertFrom = Console.ReadLine();
            string convertTo = Console.ReadLine();


            if(convertFrom == "mm" && convertTo == "cm")
            {
                Console.WriteLine($"{numberIn /= 10:F3}");
            }
            else if(convertFrom == "mm" && convertTo == "m")
            {
                Console.WriteLine($"{numberIn /= 1000:F3}");
            }

            if(convertFrom == "cm" && convertTo == "mm")
            {
                Console.WriteLine($"{numberIn *= 10:F3}");
            }
            else if(convertFrom == "cm" && convertTo == "m")
            {
                Console.WriteLine($"{numberIn /= 100:F3}");
            }

            if(convertFrom == "m" && convertTo == "cm")
            {
                Console.WriteLine($"{numberIn *= 100:F3}");
            }
            else if(convertFrom == "m" && convertTo == "mm")
            {
                Console.WriteLine($"{numberIn *= 1000:F3}");
            }

        }
    }
}
