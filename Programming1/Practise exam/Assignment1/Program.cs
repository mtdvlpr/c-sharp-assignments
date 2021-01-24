using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            string word2 = "";

            Console.Write("Enter a word: ");
            word = Console.ReadLine();

            foreach (char character in word)
            {
                word2 = character + word2;
            }

            if (word == word2)
            {
                Console.WriteLine(word + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(word + " is NOT a palindrome.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}
