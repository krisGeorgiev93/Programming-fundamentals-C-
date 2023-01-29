using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalInputs = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < totalInputs; i++)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split();
                string name = inputArray[0];

                if (inputArray.Length == 3)
                {
                    if (!names.Contains(name))
                    {
                        names.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else if (inputArray.Length == 4)
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

           
        }
    }
}
