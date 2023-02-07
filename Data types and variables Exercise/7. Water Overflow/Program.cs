using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLines = int.Parse(Console.ReadLine());            

            int waterTank = 255;
            int addedWater = 0;
            for (int i = 1; i <= totalLines; i++)
            {
            int quantities = int.Parse(Console.ReadLine());

                if (quantities > waterTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    addedWater += quantities;
                    waterTank -= quantities;
                }
            }
            Console.WriteLine(addedWater);
        }
    }
}
