using System;

namespace FunctionalProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // read in one command-line argument
            int n = Convert.ToInt32(args[0]);
            int i = 0;                // count from 0 to N
            int powerOfTwo = 1;       // the ith power of two

            // repeat until i equals n
            while (i <= n)
            {
               Console.WriteLine(i + " " + powerOfTwo);   // print out the power of two
                powerOfTwo = 2 * powerOfTwo;                // double to get the next one
                i = i + 1;
            }
        }
    }
}
