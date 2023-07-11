using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgrammingProblems
{
    class HarmonicNumber
    {
        public void PrintHarmonicNumber(int n)
        {             
            if (n == 0)
            {
                Console.WriteLine("Invalid input. N should not be zero.");
                return;
            }
            for (int i = 1; i <= n; i++)
                Console.Write($"1/{i} + ");
        }
    }
    
}
