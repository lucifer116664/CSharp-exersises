using System;

namespace Exersise1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b, arythmeticalMean;
            Console.WriteLine("Enter first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            bool isWright = int.TryParse(Console.ReadLine(), out b);
            if (isWright)
            {
                arythmeticalMean = (a + b) / 2;
                Console.WriteLine("The arythmetical mean of " + a + " and " + b + " = " + arythmeticalMean);
            }
            else
            {
                Console.WriteLine("Wrong meaning of the second number!!!");
            }
        }
    }
}
