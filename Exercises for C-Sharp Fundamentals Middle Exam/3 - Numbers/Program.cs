﻿using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            double average = 0;

            if (arr.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            average = arr.Sum() / (double)arr.Count();
            var matchingNumbersCount = arr.Where(x => x > average).ToArray().Count();

            if (matchingNumbersCount == 0)
            {
                Console.WriteLine("No");
            }
            else if (arr.Count < 5)
            {
                Console.WriteLine("Less than 5 numbers");
            }

            else
            {
                var result = arr.OrderByDescending(x => x).Where(x => x > average).Take(5).ToList();

                Console.WriteLine(string.Join(" ", result));
            }

        }
    }
}