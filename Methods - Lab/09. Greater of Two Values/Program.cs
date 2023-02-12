using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            if (type == "int")
            {
                int firtstInt = int.Parse(value1);
                int secondInt = int.Parse(value2);
                int result = GetMax(firtstInt, secondInt);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(value1);
                char secondChar = char.Parse(value2);
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string result = GetMax(value1, value2);
                Console.WriteLine(result);
            }

        }
        static string GetMax(string a, string b)
        {
            int result = a.CompareTo(b);
            if (result > 0)
            {
                return a;
            }
            return b;
        }


        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }





    }

}