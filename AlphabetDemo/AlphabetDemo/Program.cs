using System;
namespace AlphabetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the alphabet printer. \n\n ");

            int choice = 0;
            do
            {
                Console.WriteLine("\n\nIf you would like to print the alphabet, enter 1.\nIf you would like to print the alphabet backwards, enter 2. \nIf you would like to only print every 'nth' letter of the alphabet, enter 3. \n\nEnter 4 to exit the program.");

                choice = Int32.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine(PrintAlphabet());
                            break;

                        case 2:
                            Console.WriteLine(PrintAlphabetBackwards());
                            break;

                        case 3:
                            Console.WriteLine("Enter a value for 'n' and this will now print every 'nth' letter of the alphabet. \n");

                            int nth = Int32.Parse(Console.ReadLine());

                            Console.WriteLine(PrintAlphabetSkipLetters(nth));
                            break;

                    case 4:
                            Console.WriteLine("Goodbye!");
                            break;

                    default:
                            break;
                    }
            } while (choice != 4);
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

        static string PrintAlphabetSkipLetters(int numSkipped)
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