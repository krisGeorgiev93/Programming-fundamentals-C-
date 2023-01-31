using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                // from char -- > to int // from int to - -> char
                char currentChar = (char)i; // "i" v char i mu vzemame stoinostta ot ASCII tablicata
                Console.Write(currentChar + " ");
            }
        }
    }
}
