using System;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = userName.Length-1; i >= 0; i--)
            {
                char currentChar = userName[i];
                password += currentChar;
            }

            int totalTries = 0;
            string enteredPassword;
            while ((enteredPassword = Console.ReadLine()) != password) // Chetene vyv WHILE LOOP
            {
                totalTries++;

                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                
            }

            //Correct password OR BLOCKED USER
            if (totalTries < 4)
            {
                //Correct password
                Console.WriteLine($"User {userName} logged in.");
            }

        }
    }
}
