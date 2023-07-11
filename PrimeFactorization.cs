using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgrammingProblems
{
    class PrimeFactorization
    {
        public void FindPrimeFactor(int number)
        {
            Console.WriteLine($"Prime factors of " + number);
            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
            }
            if (number > 1)
                Console.WriteLine(number);
        }
    }
    
}
