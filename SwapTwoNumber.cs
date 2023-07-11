using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgrammingProblems
{
    class SwapTwoNumber
    {
        public void SwapNumber(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Before swapping: firstNumber = " + firstNumber + ", secondNumber = " + secondNumber);
            // Swap the numbers
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("After swapping: firstNumber = " + firstNumber + ", secondNumber = " + secondNumber);
        }
    }   
    
}
