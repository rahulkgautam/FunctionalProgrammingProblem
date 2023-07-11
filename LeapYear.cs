using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgrammingProblems
{
    class LeapYear
    {
        public bool FindLeapYear(int year)
        {
            bool isLeapYear = false;
            if (year % 4 == 0)
            {
                if (year % 100 != 0 || year % 400 == 0)                
                    isLeapYear = true;                
            }
            return isLeapYear;
        }
    }
    
}
