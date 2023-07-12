using System;

namespace FunctionalProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter First Number");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Third Number");
                double thirdNumber = Convert.ToDouble(Console.ReadLine());

                var largeNumber = new LargeNumber();
                largeNumber.FindAmongThreeLarge(firstNumber, secondNumber, thirdNumber);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter only Number");
            }
      }

    }
    
}
