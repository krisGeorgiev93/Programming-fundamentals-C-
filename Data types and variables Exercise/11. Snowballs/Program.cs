using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger maxValue = BigInteger.Zero;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;


            for (int i = 0; i < n ; i++)
            {
                //1 iteration --> 1 snowball 
                // for each snowball  --> 3 lines

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                // double snowballVelue = Math.Pow((snowballSnow / snowballTime), snowballQuality); // ako se polzvat malki chisla
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality); // shtom ima vdigane na stepen vinagi BIG INTEGER !

                if (snowballValue > maxValue) // tyrsim the BIGGEST VALUE 
                {
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality = snowballQuality;
                    maxValue = snowballValue;
                }
            }
            Console.WriteLine($"{maxSnow} : { maxTime} = { maxValue} ({ maxQuality})");
        }
    }
}
