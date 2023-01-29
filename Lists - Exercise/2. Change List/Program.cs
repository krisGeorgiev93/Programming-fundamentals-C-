using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split();
                if (commandArgs[0] == "Delete")
                {
                    int element = int.Parse(commandArgs[1]);
                    numbers.RemoveAll((x => x == element)); // zadavame uslovieto 
                }
                else if (commandArgs[0] == "Insert")
                {
                    int element = int.Parse(commandArgs[1]);
                    int position = int.Parse(commandArgs[2]);
                    numbers.Insert(position, element);

                }
            }
            Console.WriteLine(string.Join(" ", numbers));


        }

    }
}

