using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cntPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.0;
            double pricePerPerson = 0.0;

            if (typeGroup == "Students")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 8.45;

                    if (cntPeople >= 30)
                    {
                        price = (cntPeople * pricePerPerson);
                        price = price - (price * 0.15);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(cntPeople * pricePerPerson):f2}");
                    }
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 9.80;

                    if (cntPeople >= 30)
                    {
                        price = (cntPeople * pricePerPerson);
                        price = price - (price * 0.15);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(cntPeople * pricePerPerson):f2}");
                    }
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 10.46;

                    if (cntPeople >= 30)
                    {
                        price = (cntPeople * pricePerPerson);
                        price = price - (price * 0.15);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(cntPeople * pricePerPerson):f2}");
                    }
                }
            }
            else if (typeGroup == "Business")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 10.90;

                    if (cntPeople >= 100)
                    {
                        // price = (cntPeople * pricePerPerson);
                        // price = price - (price * 0.1);
                        // Not 10% !!!

                        cntPeople -= 10;
                        price = (cntPeople * pricePerPerson);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(cntPeople * pricePerPerson):f2}");
                    }
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 15.60;

                    if (cntPeople >= 100)
                    {
                        // price = (cntPeople * pricePerPerson);
                        // price = price - (price * 0.1);
                        // Not 10% !!!

                        cntPeople -= 10;
                        price = (cntPeople * pricePerPerson);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(cntPeople * pricePerPerson):f2}");
                    }
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 16;

                    if (cntPeople >= 100)
                    {
                        // price = (cntPeople * pricePerPerson);
                        // price = price - (price * 0.1);
                        // Not 10% !!!

                        cntPeople -= 10;
                        price = (cntPeople * pricePerPerson);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(cntPeople * pricePerPerson):f2}");
                    }
                }
            }
            else if (typeGroup == "Regular")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 15;

                    if (cntPeople >= 10 && cntPeople <= 20)
                    {
                        price = (cntPeople * pricePerPerson);
                        price = price - (price * 0.05);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(cntPeople * pricePerPerson):f2}");
                    }
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 20;
                    if (cntPeople >= 10 && cntPeople <= 20)
                    {
                        price = (cntPeople * pricePerPerson);
                        price = price - (price * 0.05);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(cntPeople * pricePerPerson):f2}");
                    }
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 22.50;

                    if (cntPeople >= 10 && cntPeople <= 20)
                    {
                        price = (cntPeople * pricePerPerson);
                        price = price - (price * 0.05);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Total price: {(cntPeople * pricePerPerson):f2}");
                    }
                }
            }
        }
    }
}