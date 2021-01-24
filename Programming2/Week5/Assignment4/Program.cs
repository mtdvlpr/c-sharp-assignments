using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Program program = new Program();

            while (run)
            {
                Console.Clear();
                run = program.Start();
            }
        }

        bool Start()
        {
            LingoGame lingoGame = new LingoGame();

            lingoGame.Init();
            Console.Clear();
            PlayLingo(lingoGame);

            return ProgramTools.LoopProgram();
        }

        void PlayLingo(LingoGame lingoGame)
        {
            while(lingoGame.attempt <= 5 && !lingoGame.GuessedWord())
            {
                string playerWord = ReadPlayerWord(lingoGame);
                lingoGame.CheckWord(playerWord);
                DisplayResults(lingoGame);
            }
            if(lingoGame.GuessedWord())
            {
                Console.WriteLine("You have guessed the word!");
            }
            else
            {
                Console.WriteLine("You didn't guess the word in time...");
                Console.WriteLine($"The correct word was: {lingoGame.lingoWord}.");
            }
        }

        string ReadPlayerWord(LingoGame lingoGame)
        {
            string playerWord = ReadTools.ReadString($"Enter a ({lingoGame.lingoWord.Length}-letter) word, attempt {lingoGame.attempt}: ");
            while (playerWord.Length != lingoGame.lingoWord.Length)
            {
                Console.WriteLine($"'{playerWord}' is not a {lingoGame.lingoWord.Length}-letter word.");
                playerWord = ReadTools.ReadString($"Enter a ({lingoGame.lingoWord.Length}-letter) word, attempt {lingoGame.attempt}: ");
            }
            return playerWord;
        }

        void DisplayResults(LingoGame lingoGame)
        {
            for (int i = 0; i < lingoGame.lingoWord.Length; i++)
            {
                if(lingoGame.letterResults[i] == LetterState.Correct)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if(lingoGame.letterResults[i] == LetterState.WrongPosition)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                Console.Write(lingoGame.playerWord[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
