using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());


            int trashedHeadsedCounter = 0;
            int trashedMouseCounter = 0;
            int trashedKeyboardCounter = 0;
            int trashedDisplayCounter = 0;

            trashedHeadsedCounter = lostGames / 2;
            trashedMouseCounter = lostGames / 3;
            trashedKeyboardCounter = lostGames / 6;
            trashedDisplayCounter = lostGames / 12;
            double expenses = (trashedHeadsedCounter * headsetPrice) + (trashedKeyboardCounter * keyboardPrice) + (trashedMouseCounter * mousePrice) + (trashedDisplayCounter * displayPrice);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

        }
    }
}
