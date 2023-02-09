using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] letters = Console.ReadLine().Split(" ").ToArray();

            for (int i = letters.Length - 1; i >= 0; i--)
            {
                string currLetter = letters[i];
                Console.Write(letters[i] + " ");
            }
        }
    }
}

