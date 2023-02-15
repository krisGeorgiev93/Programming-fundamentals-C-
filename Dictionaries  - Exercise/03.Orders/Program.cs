using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> items = new Dictionary<string, double[]>();

            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] commandArgs = command.Split();
                string product = commandArgs[0];
                double price = double.Parse(commandArgs[1]);
                double quantity = double.Parse(commandArgs[2]);

                if (!items.ContainsKey(product))
                {
                    items.Add(product, new double[2]);
                }
                items[product][0] = price;
                items[product][1] += quantity;
            }
            foreach (var product in items)
            {
                double totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }


        }
    }
}