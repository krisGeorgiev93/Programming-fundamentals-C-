using System;
using System.Collections.Generic;

namespace Need_for_Speed_III___Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double[]> cars = new Dictionary<string, double[]>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputParts = input.Split("|");
                string carName = inputParts[0];
                int mileage = int.Parse(inputParts[1]);
                int fuel = int.Parse(inputParts[2]);

                cars.Add(carName, new double[2]);
                cars[carName][0] = mileage;
                cars[carName][1] = fuel;


            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandParts = command.Split(" : ");
                string commandType = commandParts[0];
                string car = commandParts[1];

                if (commandType == "Drive")
                {
                    int distance = int.Parse(commandParts[2]);
                    int fuelNeeded = int.Parse(commandParts[3]);

                    if (cars[car][1] >= fuelNeeded)
                    {
                        cars[car][0] += distance;
                        cars[car][1] -= fuelNeeded;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
                        if (cars[car][0] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            cars.Remove(car);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }

                }
                if (commandType == "Refuel")
                {
                    int fuel = int.Parse(commandParts[2]);

                    int currentTank = int.Parse(cars[car][1].ToString());

                    cars[car][1] += fuel;
                    if (cars[car][1] > 75)
                    {
                        cars[car][1] = 75;
                        Console.WriteLine($"{car} refueled with {75 - currentTank} liters");

                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }

                if (commandType == "Revert")
                {
                    int kilometers = int.Parse(commandParts[2]);
                    cars[car][0] -= kilometers;
                    if (cars[car][0] > 10000)
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        cars[car][0] = 10000;
                    }

                }

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }

        }
    }
}
