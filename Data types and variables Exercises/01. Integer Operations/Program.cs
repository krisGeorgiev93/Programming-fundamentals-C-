using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            int addOperation = number1 + number2;
            int divideOperation = addOperation / number3;
            int multiplyOperation = divideOperation * number4;
            Console.WriteLine(multiplyOperation);

        }
    }
}
