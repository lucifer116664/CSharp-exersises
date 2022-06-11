using System;

namespace Exersise5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int min, max, pair = 0, unpair = 0;
            bool isWright;
            wrongNumber1:
            Console.WriteLine("Enter the minimal value of the numbers range:");
            isWright = int.TryParse(Console.ReadLine(), out min);
            if (isWright)
            {
                wrongNumber2:
                Console.WriteLine("Enter the maximal value of the numbers range:");
                isWright = int.TryParse(Console.ReadLine(), out max);
                if (isWright)
                {
                    while (min != max + 1)
                    {
                        if (min % 2 == 0)
                        {
                            pair++;
                        }
                        else
                        {
                            unpair++;
                        }
                        min++;
                    }
                    Console.WriteLine("There is " + pair + " pair and " + unpair + " unpair numbers.");
                }
                else
                {
                    Console.WriteLine("Wrong data!!! Try again.");
                    goto wrongNumber2;
                }
            }
            else
            {
                Console.WriteLine("Wrong data!!! Try again.");
                goto wrongNumber1;
            }
        }
    }
}
