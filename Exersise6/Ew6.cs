using System;

namespace Exersise6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int height;
            Console.WriteLine("Enter the height and the width:");
            height = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            ////////////////////////////
            for (int i = 0; i < height; i++)
            {
                for (int j= height; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            ////////////////////////////
            for (int i = 0; i < height; i++)
            {
                for (int j= height; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            ////////////////////////////
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
