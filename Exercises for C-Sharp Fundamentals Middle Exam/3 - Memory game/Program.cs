using System;
using System.Collections.Generic;
using System.Linq;

namespace _3___Memory_game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfElements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            int movesCounter = 0;
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string [] index = input.Split();
                int firstIndex = int.Parse(index[0]);
                int secondIndex = int.Parse(index[1]);

                movesCounter++;

                if (firstIndex >= 0 && secondIndex >= 0 && firstIndex < listOfElements.Count 
                    && secondIndex < listOfElements.Count && firstIndex != secondIndex)
                {
                    if (listOfElements[firstIndex] == listOfElements[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {listOfElements[firstIndex]}!");
                        if (firstIndex > secondIndex)
                        {
                            listOfElements.RemoveAt(firstIndex);
                            listOfElements.RemoveAt(secondIndex);
                        }
                        else
                        {
                            listOfElements.RemoveAt(secondIndex);
                            listOfElements.RemoveAt(firstIndex);
                        }
                        
                        if (listOfElements.Count <= 0)
                        {
                            Console.WriteLine($"You have won in {movesCounter} turns!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    listOfElements.Insert(listOfElements.Count / 2, $"-{movesCounter}a");
                    listOfElements.Insert(listOfElements.Count / 2, $"-{movesCounter}a");

                }
            }
            if (input == "end")
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ",listOfElements));
            }
        }
    }
}
