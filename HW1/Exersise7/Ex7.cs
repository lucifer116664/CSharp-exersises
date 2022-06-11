using System;
using System.Linq;

namespace Exersise7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] arr = new int[numberOfElements];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter {i} element:\t");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Here is the elements in reverse sequence:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

            //int sumOfPairElements = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        sumOfPairElements += arr[i];
            //    }
            //}
            Console.WriteLine("The sum of pair elements in your array = " + arr.Where(i => i % 2 == 0).Sum());

            //int leastValue = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < leastValue)
            //    {
            //        leastValue = arr[i];
            //    }
            //}
            Console.WriteLine("The least element in your array = " + arr.Min());
        }
    }
}