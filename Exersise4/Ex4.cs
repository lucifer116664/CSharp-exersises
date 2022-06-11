using System;

namespace HW2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num;

            wrongData: //label for goto

            Console.WriteLine("Enter the number:");
            bool isWright = int.TryParse(Console.ReadLine(), out num);
            if (isWright)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("This number is pair.");
                }
                else
                {
                    Console.WriteLine("This number is unpair.");
                }
            }
            else
            {
                Console.WriteLine("WRONG DATA!!! Try again:");
                goto wrongData;
            }

        }
    }
}
