using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgrammingProblems
{
    class LargeNumber
    {
        public void FindAmongThreeLarge(double num1,double num2, double num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                    Console.Write(num1 + " First Number is the largest!");
                else
                    Console.Write(num3 + " Third Number is the largest!");
            }
            else if (num2 > num3)
                Console.Write(num2 + " Second Number is the largest!");
            else
                Console.Write(num3 + " Third Number is the largest!");
        }
    }
}
