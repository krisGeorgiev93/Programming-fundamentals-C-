using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // vynshniq cikyl predstavq redovete
            for (int row = 1; row <= n; row++)
            {
                // vlojeniq cikyl predstavq kolonkite
                for (int col = 1; col <= row; col++) // nomera na reda opredelq kolko koloni shte ima v dadeniq red ( 2ri red 2 koloni / 3ti red 3 ...)
                {
                    Console.Write($"{row} "); // pechatame nomera na reda
                }
                // minava na nov red
                Console.WriteLine();
            }
        }
    }
}
