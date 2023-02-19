using System;
using System.Linq;
using System.Collections.Generic;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayForOnePerson = double.Parse(Console.ReadLine());
            double foodPerDayForOnePerson = double.Parse(Console.ReadLine());

            double totalWater = numberOfPlayers * daysOfAdventure * waterPerDayForOnePerson;
            double totalFood = numberOfPlayers * daysOfAdventure * foodPerDayForOnePerson;

            for (int i = 1; i <= daysOfAdventure; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;
                if (groupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    return;
                }
                
                if (i % 2 == 0)
                {
                    groupEnergy += groupEnergy * 0.05;
                    totalWater -= totalWater * 0.30;
                }
                if (i % 3 == 0)
                {
                    totalFood -= (totalFood / numberOfPlayers);
                    groupEnergy += (groupEnergy * 0.10);

                }
               
            }            
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");            
        }
    }
}
