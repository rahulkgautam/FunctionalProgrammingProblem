using System;

namespace FunctionalProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the First Number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second Number:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                var swipTwoNumber = new SwapTwoNumber();
                swipTwoNumber.SwapNumber(firstNumber,secondNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter Only Number");
            }

            

        }
    }
}
