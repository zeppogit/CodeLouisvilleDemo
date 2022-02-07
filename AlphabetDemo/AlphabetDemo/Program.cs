using System;
namespace AlphabetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrintAlphabet());
            Console.WriteLine(PrintAlphabetBackwards());
            Console.WriteLine(PrintAlphabetSkipOneLetter(3));
        }

        static string PrintAlphabet()
        {
            string alphabet = string.Empty;
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                alphabet += alpha;
            }
            return alphabet;
        }

        static string PrintAlphabetBackwards()
        {
            string alphabet = string.Empty;
            for (char alpha = 'Z'; alpha >= 'A'; alpha--)
            {
                alphabet += alpha;
            }
            return alphabet;
        }

        static string PrintAlphabetSkipOneLetter(int numSkipped)
        {
            string alphabet = string.Empty;
            for (char alpha = 'A'; alpha <= 'Z'; alpha = (char)(alpha + numSkipped))
            {
                alphabet += alpha;
            }
            return alphabet;
        }
    }
}

