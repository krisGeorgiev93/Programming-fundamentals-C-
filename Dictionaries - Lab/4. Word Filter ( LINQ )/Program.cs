using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Word_Filter___LINQ__
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            foreach (var currentWord in words)
            {
                if (currentWord.Length % 2 == 0)
                {
                    Console.WriteLine(currentWord);
                }
            }
        }
    }
}
