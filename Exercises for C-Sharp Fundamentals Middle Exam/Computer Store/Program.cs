using System;

namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            double totalPrice = 0;
            double taxes = 0;
            double discountPrice = 0;

            while (input != "special" && input != "regular")
            {                
                double priceWithoutTax = double.Parse(input); 
                if (priceWithoutTax < 0) 
                {
                    Console.WriteLine("Invalid price!"); 
                }
                else
                {
                    totalPrice += priceWithoutTax; 
                    taxes += priceWithoutTax * 0.20;
                }

                input = Console.ReadLine();

            }

            if (totalPrice + taxes > 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                if (input == "special")
                {
                    discountPrice += (totalPrice + taxes) * 0.10;
                    double totalPriceWithDiscount = (totalPrice + taxes) - discountPrice;
                    Console.WriteLine($"Total price: {totalPriceWithDiscount:F2}$");
                }
                else
                {
                    Console.WriteLine($"Total price: {totalPrice + taxes:F2}$");
                }
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
