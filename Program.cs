using System;

namespace FunctionalProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number and find prime factors:");
                int number = Convert.ToInt32(Console.ReadLine());
                var primeFactor=new PrimeFactorization();
                primeFactor.FindPrimeFactor(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter Only Number");
            }

            

        }
    }
}
