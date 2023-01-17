using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;
            // za vsqka porychka shte chetem :
            for (int i = 1; i <= countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                price = (days * capsulesCount) * pricePerCapsule;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
