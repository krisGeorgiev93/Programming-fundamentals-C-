using System;
using System.Linq;

namespace _2.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaitingForLift = int.Parse(Console.ReadLine()); 
            int[] wagon = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int peopleOnTheCurrentWagon = 0;
            int peopleonTheLift = 0;
            bool NoMorePeople = false;

            for (int i = 0; i < wagon.Length; i++)
            {
                while (wagon[i] < 4)
                {
                    wagon[i]++;
                    peopleOnTheCurrentWagon++;
                    if (peopleonTheLift + peopleOnTheCurrentWagon == peopleWaitingForLift)
                    {
                        NoMorePeople = true;
                        break;
                    }
                }
                peopleonTheLift += peopleOnTheCurrentWagon;
                if (NoMorePeople)
                {
                    break;
                }
                peopleOnTheCurrentWagon = 0;
            }

            if (peopleWaitingForLift > peopleonTheLift)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaitingForLift - peopleonTheLift} people in a queue!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (peopleWaitingForLift < wagon.Length * 4 && wagon.Any(w => w < 4)) // we check if there are free space in the lift
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (wagon.All(w => w == 4) && NoMorePeople == true) // When the lift is full and there are no more people waiting
            {
                Console.WriteLine(string.Join(" ", wagon));
            }
        }
    }
}