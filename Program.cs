using System;

namespace FunctionalProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=========Vowel Consonant Problem===========");
                var evenOdd = new VowelConsonant();
                Console.WriteLine("Enter a Alphabet (a-z or A-Z)");
                char ch = Convert.ToChar(Console.ReadLine().ToLower());
                evenOdd.CheckVowelConsonant(ch);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter only Alphabet");
            }
            
        }
    }
}
