using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int timer = 0;
            string[] words = new string[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Enter a word: ");
                word = Console.ReadLine();

                if (word.Length > 0)
                {
                    words[i] = word;
                    timer++;
                }
                else
                {
                    i = 20;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < timer; i++)
            {
                if (words[i].Length % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine(words[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine("End of progam");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();

        }
    }
}
