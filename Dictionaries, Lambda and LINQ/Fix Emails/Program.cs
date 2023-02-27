using System;
using System.Linq;
using System.Collections.Generic;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dataBook = new Dictionary<string, string>();

            string name = Console.ReadLine();
            while (name != "stop")
            {
                string email = Console.ReadLine();
                string[] emailSplitted = email.Split(".");
                if (emailSplitted[1] != "us" && emailSplitted[1] != "uk")
                {
                    dataBook.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach (var item in dataBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
