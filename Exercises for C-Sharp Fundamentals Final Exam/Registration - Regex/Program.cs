using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Registration___Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"U\$(?<userName>[A-Z][a-z]{2,})U\$P@\$(?<password>[A-z]{5,}[0-9]{1,})P@\$";
            List<string> validRegistrations = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                if (match.Success)
                {                   
                        string userName = match.Groups["userName"].Value;
                        string password = match.Groups["password"].Value;

                        validRegistrations.Add(userName);

                        Console.WriteLine("Registration was successful");
                        Console.WriteLine($"Username: {userName}, Password: {password}");                    
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }


            Console.WriteLine($"Successful registrations: {validRegistrations.Count}");
            
        }
    }
}
