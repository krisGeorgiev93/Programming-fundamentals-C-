using System;
using System.Collections.Generic;
using System.Linq;
namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split(", ");
                string commandType = commandArgs[0];
                if (commandType == "Add")
                {
                    string cardName = commandArgs[1];
                    if (!cards.Contains(cardName))
                    {
                        cards.Add(cardName);
                        Console.WriteLine("Card successfully added");
                    }
                    else
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                }
                if (commandType == "Remove")
                {
                    string cardName = commandArgs[1];
                    if (cards.Contains(cardName))
                    {
                        cards.Remove(cardName);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                if (commandType == "Remove At")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index >= 0 && index < cards.Count)
                    {
                        cards.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                if (commandType == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string cardName = commandArgs[2];
                    if (index>=0 && index<cards.Count)
                    {
                        if (!cards.Contains(cardName))
                        {
                            cards.Insert(index, cardName);
                            Console.WriteLine("Card successfully added");
                        }
                        else
                        {
                            Console.WriteLine("Card is already added");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ",cards));
        }
    }
}
