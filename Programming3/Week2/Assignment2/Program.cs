using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Program program = new Program();
            while (run)
            {
                run = program.Start();
            }
        }

        bool Start()
        {
            DeckOfCards deck = new DeckOfCards();
            Console.WriteLine("Ordered:");
            deck.Print();

            Console.WriteLine();
            Console.WriteLine("Randomised:");

            deck.Shuffle();
            deck.Print();

            return ProgramTools.LoopProgram();
        }
    }
}
