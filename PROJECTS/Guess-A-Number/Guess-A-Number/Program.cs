using System;
using static System.Net.Mime.MediaTypeNames;

namespace GuessANumber
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);
            int playerAttemps = 4;

            while (true)
            {

                Console.WriteLine("Guess a number (1-100). You have to guess in 5 tries so be careful!");
                string playerInput = Console.ReadLine();

                bool isValid = int.TryParse(playerInput, out int playerNumber);

                if (isValid)
                {
                    if (playerAttemps == 0)
                    {
                        Console.WriteLine($"You lose. You have {playerAttemps} attempts left. The number you couldn't guess was {computerNumber}");
                        Console.WriteLine("If you want to try again, write [R]estart. Otherwise press any key to exit.");
                        string restartCommand = Console.ReadLine();
                        if (restartCommand == "Restart" || restartCommand == "R")
                        {
                            Console.WriteLine("A new game begins");
                            playerAttemps = 4;
                            computerNumber = randomNumber.Next(1, 101);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Game over!");
                            break;
                        }
                    }

                    if (playerNumber == computerNumber && playerNumber >= 1 && playerNumber <= 100)
                    {
                        Console.WriteLine($"You guess it! Attemps left {playerAttemps}");
                        break;
                    }
                    else if (playerNumber > computerNumber && playerNumber >= 1 && playerNumber <= 100)
                    {
                        Console.WriteLine($"Too High, Try again. Attemps left {playerAttemps}");
                        playerAttemps--;
                    }
                    else if (playerNumber < computerNumber && playerNumber >= 1 && playerNumber <= 100)
                    {
                        Console.WriteLine($"Too Low, Try again. Attemps left {playerAttemps}");
                        playerAttemps--;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, Try again...");
                    }
                }

            }
        }
    }
}