using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());

            double result = RaiseToPower(baseNumber, powerNumber);
            Console.WriteLine(result);
            
        }

        private static double RaiseToPower(double baseNumber, double powerNumber)
        {
            double result = 0d;
            result = Math.Pow(baseNumber, powerNumber);
            return result;
        }
    }
}
