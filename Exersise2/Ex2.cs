using System;

namespace Exersise2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float a, b, c;
            string str;
            bool isWright;

        wrongDataA: //label for goto (wrong data in variable "a")

            Console.WriteLine("Enter first number:");
            str = Console.ReadLine();
            isWright = float.TryParse(str, out a);
            if (isWright)
            {

            wrongDataB: //label for goto (wrong data in variable "b")

                Console.WriteLine("Enter second number:");
                str = Console.ReadLine();
                isWright = float.TryParse(str, out b);
                if (isWright)
                {

                wrongDataC: //label for goto (wrong data in variable "c")

                    Console.WriteLine("Enter third number:");
                    str = Console.ReadLine();
                    isWright = float.TryParse(str, out c);
                    if (isWright)
                    {
                        float sum = a + b + c;
                        double product = (double) a * b * c;

                        Console.WriteLine("The sum of numbers you've entered is " + sum + " and the product is " + product);
                    }
                    else
                    {
                        Console.WriteLine("WRONG DATA!!! Try again:");
                        goto wrongDataC;
                    }
                }
                else
                {
                    Console.WriteLine("WRONG DATA!!! Try again:");
                    goto wrongDataB;
                }
            }
            else
            {
                Console.WriteLine("WRONG DATA!!! Try again:");
                goto wrongDataA;
            }
        }
    }
}
