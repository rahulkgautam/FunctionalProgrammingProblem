using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgrammingProblems
{
    class EvenOdd
    {
        public void CheckEvenOddNumber(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine(number + " is a Even Number");
            else
                Console.WriteLine(number+" is a Odd Number");
        }
    }
}
