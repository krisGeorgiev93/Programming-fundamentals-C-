using System;
using System.Linq;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

            Dictionary<string, int> data = new Dictionary<string, int>();
            while (resource != "stop")
            {
                if (!data.ContainsKey(resource))
                {
                    data[resource] = 0;
                }
                int quantity = int.Parse(Console.ReadLine());
                data[resource] += quantity;

                resource = Console.ReadLine();
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
