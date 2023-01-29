using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            long fact = long.Parse(Console.ReadLine());
            long devision = long.Parse(Console.ReadLine());
            long sum = fact;

            double num1 = GetFactorial(fact);
            double num2 = GetFactorial(devision);

            Console.WriteLine($"{num1 / num2:f2}");
        }

        private static double GetFactorial(long number)
        {
            for (long i = number - 1; i >= 1; i--)  // така се изчисляват факториали
            { // 5! = 5*4*3*2*1....
                number = number * i; // ПРИМЕР 5! = 5-1 = 4 * 5 = 20 ----> 20 * 3 = 60 ---> 60 * 2 = 120 --> 120 * 1 = 120.
            }

            return number;
        }
    }
}