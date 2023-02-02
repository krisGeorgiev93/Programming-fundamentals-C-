using System;

namespace _6._Middle_Characters
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetMiddleCharacter(input));
        }

        static string GetMiddleCharacter(string input)
        {
            int len = input.Length;
            string result = "";

            if (len % 2 == 1) // проверяваме дали дължината на стринга е четна или нечетна 
                // aString в този случей имаме дължина 7 като делим на 2 и получаваме 3.5 ( буква "r" ) е среда на стринга
            {
                result = input[input.Length / 2].ToString();
            }
            else
            { //If the length of the string is even, there are two middle characters.
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            } // вземаме средната буква и една преди нея ( затова делим и вадим 1 ) 

            return result;
        }

    }
}
