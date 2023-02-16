using System;

namespace Santa_s_New_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalCost = 0;
            int totalSpirit = 0;

            int ornamentSetPrice = 2;
            int treeSkirtPrice = 5;
            int treeGarlandsPrice = 3;
            int treeLightsPrice = 15;



            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 2 == 0)
                {

                    totalCost += ornamentSetPrice * quantity;
                    totalSpirit += 5;

                }
                if (i % 3 == 0)
                {
                    totalCost += treeGarlandsPrice * quantity;

                    totalCost += treeSkirtPrice * quantity;
                    totalSpirit += 13;
                }
                if (i % 5 == 0)
                {
                    totalCost += treeLightsPrice * quantity;
                    totalSpirit += 17;
                    if (i % 3 == 0)
                    {
                        totalSpirit += 30;
                    }
                }
                if (i % 10 == 0)
                {
                    totalSpirit -= 20;
                    totalCost += (treeSkirtPrice + treeGarlandsPrice + treeLightsPrice);                    
                }


            }
            if (days % 10 == 0)
            {
                totalSpirit -= 30;
            }
            Console.WriteLine(totalCost);
            Console.WriteLine(totalSpirit);
        }
    }
}
