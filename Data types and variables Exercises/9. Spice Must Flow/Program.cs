using System;

namespace _9._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYields = int.Parse(Console.ReadLine());
            int totalYields = 0;
            int daysCounter = 0;
            
            while (startYields >= 100)
            {
                daysCounter++;
                totalYields += startYields - 26;
                startYields -= 10;
               
            }
            if (startYields > 26 && daysCounter > 0) 
            {
                totalYields -= 26;
            }
            
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalYields);
        }
    }
}
