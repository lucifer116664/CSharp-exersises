using System;

namespace Exersise3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int menu = 0;
            do
            {
                double dollars, gryvnias;
                string str;
                Console.WriteLine("Enter \"1\" if you want to convert dollars in gryvnias;\nEnter \"2\" if you want to convert gryvnias in dollars;\nEnter \"0\" if you want to quit.");
                str = Console.ReadLine();
                menu = int.Parse(str);
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("How many dollars?");
                        str = Console.ReadLine();
                        dollars = Convert.ToDouble(str);
                        gryvnias = dollars * 30;
                        Console.WriteLine("It is " + gryvnias + " gryvnias.");
                        break;
                    case 2:
                    tryAgain: //label for goto
                        Console.WriteLine("How many gryvnias?");
                        str = Console.ReadLine();
                        bool forTryParse = double.TryParse(str, out gryvnias);
                        if (forTryParse)
                        {
                            dollars = gryvnias / 30;
                            Console.WriteLine("It is " + dollars + " dollars.");
                        }
                        else
                        {
                            Console.WriteLine("ERROR!!!");
                            goto tryAgain;
                        }
                        break;
                    case 0:
                        Console.WriteLine("Have a nice day!!!");
                        break;
                    default:
                        Console.WriteLine("You've entered wrong number. Try again.");
                        break;
                }
            } while (menu != 0);
        }
    }
}

