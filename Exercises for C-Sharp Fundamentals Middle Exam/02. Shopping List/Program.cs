using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("!").ToList();

            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string [] commandArgs = command.Split();
                string commandType = commandArgs[0];
                string commandItem = commandArgs[1];
                if (commandType == "Urgent")
                {
                    if (items.Contains(commandItem))
                    {
                        continue;
                    }
                    else
                    {
                        items.Insert(0, commandItem);
                    }
                }
                if (commandType == "Unnecessary")
                {
                    if (items.Contains(commandItem))
                    {
                        items.Remove(commandItem);
                    }                    
                }
                if (commandType == "Correct")
                {
                    string oldItem = commandArgs[1];
                    string newItem = commandArgs[2];

                    if (items.Contains(oldItem))
                    { //така вземаме индекса на дадения продукт --->
                        int index = items.Select((item, i) => new { Item = item, Index = i })
                            .First(x => x.Item == oldItem).Index;

                        items.Insert(index, newItem);
                        items.Remove(oldItem);
                    }                  
                }
                if (commandType == "Rearrange")
                {
                    if (items.Contains(commandItem))
                    {
                        items.Remove(commandItem);
                        items.Add(commandItem);
                    }
                }
            }
            Console.WriteLine(string.Join(", ",items));

        }
    }
}
