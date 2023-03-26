using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_New_List___Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> goodChildrens = new Dictionary<string, int>();
            Dictionary<string, int> presents = new Dictionary<string, int>();
            
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputParts = input.Split("->");
                if (inputParts[0] == "Remove")
                {
                    goodChildrens.Remove(inputParts[1]);
                    continue;
                }
                
                string name = inputParts[0];
                string typeOfPresent = inputParts[1];
                int amount = int.Parse(inputParts[2]);
                if (!goodChildrens.ContainsKey(name))
                {
                    goodChildrens.Add(name, 0);
                }
                goodChildrens[name] += amount;
                if (!presents.ContainsKey(typeOfPresent))
                {
                    presents.Add(typeOfPresent, 0);
                }
                presents[typeOfPresent] += amount;

                
            }
            Console.WriteLine("Children:");
            foreach (KeyValuePair<string, int> child in goodChildrens.OrderByDescending(child => child.Value).ThenBy(child => child.Key)) 
            {
                Console.WriteLine($"{child.Key} -> {child.Value}");
            }
            Console.WriteLine("Presents:");
            foreach (var present in presents)
            {
                Console.WriteLine($"{present.Key} -> {present.Value}");
            }
        }
    }
}
