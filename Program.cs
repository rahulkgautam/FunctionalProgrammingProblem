using System;

namespace FunctionalProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Functional Programming Problems");
                var leapYear = new LeapYear();
                Console.WriteLine("Enter a year (4-digit):");
                int year = Convert.ToInt32(Console.ReadLine());
                bool isLeapYear = leapYear.FindLeapYear(year);

                if (isLeapYear)
                    Console.WriteLine(year + " is a leap year.");
                else
                    Console.WriteLine(year + " is not a leap year.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please Enter only Number (4-Digit) Year");
            }

        }
    }
}
