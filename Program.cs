using System;

namespace FunctionalProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the dividend:");
                int dividend = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the divisor:");
                int divisor = Convert.ToInt32(Console.ReadLine());
                var quotientAndRemainder = new QuotientAndRemainder();
                quotientAndRemainder.CalculateQuotientAndRemainder(dividend,divisor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter Only Number");
            }

            

        }
    }
}
