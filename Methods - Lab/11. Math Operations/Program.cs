using System;

namespace _11._Math_Operations
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            string operatorr = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());

            
           string result = GetTheResult(number1, operatorr, number2);

            Console.WriteLine(result);
            
        }

       static string GetTheResult(int number1, string operatorr, int number2)
        {

            double result = 0;
            if (operatorr == "/")
            {
                result = number1 / number2;              

            }
            else if (operatorr == "*")
            {
                result = number1 * number2;                

            }
            else if (operatorr == "+")
            {
                result = number1 + number2;               

            }
            else if (operatorr == "-")
            {
                result = number1 - number2;               

            }
            return result.ToString();
            
        }
    }
}
