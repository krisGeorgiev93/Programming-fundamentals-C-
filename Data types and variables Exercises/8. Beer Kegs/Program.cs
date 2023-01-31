using System;

namespace _8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volume = 0;

            string biggestModel = string.Empty;
            double MaxVolume = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                string modelOfCeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.PI * (radius * radius) * height; // (radius * radius) --> radius na 2ra
                if (volume > MaxVolume)
                {
                    biggestModel = modelOfCeg;
                    MaxVolume = volume;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
