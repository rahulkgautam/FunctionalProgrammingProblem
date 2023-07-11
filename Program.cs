using System;

namespace FunctionalProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the value of N:");
                int n = Convert.ToInt32(Console.ReadLine());
                var harmonic =new HarmonicNumber();
                harmonic.PrintHarmonicNumber(n);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please Enter only Number");
            }

           
        }
    }
}
