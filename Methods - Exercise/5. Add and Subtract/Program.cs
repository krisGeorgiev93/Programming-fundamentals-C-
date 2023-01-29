using System;

namespace _5._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = GetSum(num1, num2);
            int subtract = GetSubtract(sum, num3);
            Console.WriteLine(subtract);
        }
        private static int GetSum(int num1, int num2)
        {
            int resultSum = num1 + num2;
            return resultSum;            
        }

        private static int GetSubtract(int sum, int num3)
        {
            int subtract = sum - num3;
            return subtract;
        }

        
    }
}
