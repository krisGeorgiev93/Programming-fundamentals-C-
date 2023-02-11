using System;

namespace _4._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++) // tozi for otgovarq za redovete 
            {
                PrintColumns(i);
            }

            for (int i = input - 1; i >= 1; i--) // vtorite redove ( sled polovinata)
            {
                PrintColumns(i);

                //1
                //1 2
                //1 2 3
                //1 2
                //1
            }
        }

        private static void PrintColumns(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
}
