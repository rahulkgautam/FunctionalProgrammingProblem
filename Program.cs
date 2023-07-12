using System;

namespace FunctionalProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=========Even odd number Problem===========");
                var evenOdd = new EvenOdd();
                Console.WriteLine("Enter a Number");
                int number = Convert.ToInt32(Console.ReadLine());
                evenOdd.CheckEvenOddNumber(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter only Number");
            }
            
        }
    }
}
