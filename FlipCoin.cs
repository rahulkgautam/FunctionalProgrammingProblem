using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgrammingProblems
{
    class FlipCoin
    {
        public static void FlipCoinAndCalculatePercentage()
        {
            Console.WriteLine("Flip Coin program and calculate Percentage of heads and Tails");
            double heads = 0;
            double tails = 0;
            double percentageOfHeads, percentageOfTails;

            Console.WriteLine("Enter number of times to flip coins");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Random random = new Random();
                double flipCoin = random.NextDouble();
                if (flipCoin > 0.5)
                    tails++;
                else
                    heads++;
            }
            Console.WriteLine("Head count " + heads);
            Console.WriteLine("Tails count " + tails);

            percentageOfHeads = (heads / number) * 100;
            Console.WriteLine("heads percentage: " + percentageOfHeads+"%");
            percentageOfTails = (tails / number) * 100;
            Console.WriteLine("tails percentage: " + percentageOfTails+"%");
        }
    }
}
