using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgrammingProblems
{
    class VowelConsonant
    {
        public void CheckVowelConsonant(char inputValue)
        {
            if (inputValue=='a'||inputValue=='i' || inputValue == 'o' || inputValue == 'u' || inputValue == 'e')
                Console.WriteLine(inputValue + " Alphabet is vowel");
            else
                Console.WriteLine(inputValue + " Alphabet is Consonant");
        }
    }
}
