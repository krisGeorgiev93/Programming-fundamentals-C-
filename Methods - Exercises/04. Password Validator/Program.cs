using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();
            bool isLenghtValid = IsPasswordLenghtValid(inputPassword);
            bool isPassAlphaNumeric = IsPasswordAlphaNumeric(inputPassword);
            bool hasTwoDigits = IsPasswordContaingAtLeastTwoDigits(inputPassword);

            if (!isLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPassAlphaNumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!hasTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLenghtValid && isPassAlphaNumeric && hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }


        }

        static bool IsPasswordContaingAtLeastTwoDigits(string password) // password e копие на inputPassword
        {
            int digitsCount = 0;
            foreach  (char currChar in password)
            {
                if (char.IsDigit(currChar))
                {
                    digitsCount++;
                }
            }
            return digitsCount >= 2;
        }

        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach (char currCh in password)
            {
                if (!Char.IsLetterOrDigit(currCh)) // с този метод проверяваме дали паролата е само от цифри и букви
                {
                    return false; // ако намери нещо различно от буква или цифра връщаме false
                }               
            }
            return true; //в противен случей връщаме вярно 

        }

        static bool IsPasswordLenghtValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10; // правим проверка дали паролата е между 6 и 10 символа
            return isValid; // ако е вярно връщаме в мейн метода isValid
        }
    }
}
