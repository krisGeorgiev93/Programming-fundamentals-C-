using System;

namespace RockPaperScissors
{

    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            Console.WriteLine("Choose between [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine().ToLower();


            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = scissors;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again");
                return;
            }

            Console.WriteLine(playerMove);

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";

            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = "Rock";
                    break;
                case 2:
                    computerMove = "Paper";
                    break;
                case 3:
                    computerMove = "Scissors";
                    break;
            }

            Console.WriteLine($"The computer chose {computerMove}.");

            if ((playerMove == rock && computerMove == scissors) || playerMove == paper && computerMove == rock || playerMove == scissors && computerMove == paper)
            {
                Console.WriteLine("You win, looks like today is your lucky day.");
            }
            else if ((playerMove == scissors && computerMove == rock) || playerMove == rock && computerMove == paper || playerMove == paper && computerMove == scissors)
            {
                Console.WriteLine("You lose, sorry better luck next time.");
            }
            else
            {
                Console.WriteLine("This game was a draw, the battle is not over.");
            }
        }
    }
}