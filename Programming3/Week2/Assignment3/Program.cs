using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment3
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
            string player1Name = ReadTools.ReadString("Player 1 (name): ");
            string player2Name = ReadTools.ReadString("Player 2 (name): ");
            Player player1 = new Player(player1Name);
            Player player2 = new Player(player2Name);

            WarCardGame war = new WarCardGame(player1, player2);
            PlayTheGame(war);

            return ProgramTools.LoopGame();
        }

        void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();
            while (!war.EndOfGame())
            {
                war.NextCard();
            }
            Console.WriteLine();
            if(war.player1.cards.Count == 0)
            {
                Console.WriteLine($"Congratulations {war.player2.name}, you won!");
            }
            else
            {
                Console.WriteLine($"Congratulations {war.player1.name}, you won!");
            }
        }
    }
}