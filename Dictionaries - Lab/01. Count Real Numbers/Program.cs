using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> number = new SortedDictionary<double, int>();

            double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var currentNumber in inputNumbers)
            {
                if (!number.ContainsKey(currentNumber))
                {
                    number.Add(currentNumber, 0); 
                }
                number[currentNumber] += 1;
            }
            foreach (var item in number)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
