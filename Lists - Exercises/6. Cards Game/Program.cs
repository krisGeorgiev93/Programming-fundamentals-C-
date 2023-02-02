using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if (firstPlayer[0] > secondPlayer[0]) // 1вия играч прибира и двете карти и ги адваме най отзад в ЛИСТА 
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                }
                else if (firstPlayer[0] < secondPlayer[0]) 
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                }
                // ако са равни премахваме и двете карти 
                firstPlayer.Remove(firstPlayer[0]); // премахжаме картата [0] която е отишла вече най отзад
                secondPlayer.Remove(secondPlayer[0]); // премахваме и губещата карта на 2рия играч 

                if (firstPlayer.Count == 0) // когато първия играч остане с 0 карти 2рия печели
                {
                    int sum = secondPlayer.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondPlayer.Count == 0) // когато 2рия играч остане с 0 карти 1вия печели
                {
                    int sum = firstPlayer.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}