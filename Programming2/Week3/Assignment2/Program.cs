
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Program program = new Program();

            while(run)
            {
                Console.Clear();
                run = program.Start();
            }
        }

        bool Start()
        {
            HangmanGame hangman = new HangmanGame();
            List<string> words = new List<string>();
            words = ListOfWords();
            string secretWord = SelectWord(words);
            hangman.Init(secretWord);
            if(PlayHangman(hangman))
            {
                Console.WriteLine("You guessed the word!");
            }
            else
            {
                Console.WriteLine("You didn't guess the word...");
                Console.WriteLine($"The secret word was: {hangman.secretWord}");
            }

            return LoopProgram();

        }

        bool LoopProgram()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Do you want to play again? ");
            string answer = Console.ReadLine();
            while (answer != "yes" && answer != "no")
            {
                Console.WriteLine("Answer with 'yes' or 'no' please.");
                Console.Write("Do you want to play again? ");
                answer = Console.ReadLine();
            }
            if (answer == "no")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        char ReadLetter(List<char> blacklistLetters)
        {
            char letter = '.';
            int stop = 0;
            while(stop != 1)
            {
                Console.Write("Enter a letter: ");
                if (char.TryParse(Console.ReadLine(), out letter))
                {
                    if(blacklistLetters.Contains(letter))
                    {
                        Console.WriteLine($"{letter} has already been guessed!");
                    }
                    else
                    {
                        return letter;
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid letter!");
                }
            }
            return letter;
        }

        void DisplayLetters(List<char> letters)
        {
            Console.Write("Entered letters:");
            for (int i = 0; i < letters.Count; i++)
            {
                Console.Write($" {letters[i]}");
            }
            Console.WriteLine();
        }

        void DisplayWord(string word)
        {
            foreach (char letter in word)
            {
                Console.Write($" {letter}");
            }
            Console.WriteLine();
        }


        bool PlayHangman(HangmanGame hangman)
        {
            int stop = 0;
            List<char> enteredLetters = new List<char>();

            while(stop != 1)
            {
                //DisplayWord(hangman.secretWord);
                DisplayWord(hangman.guessedWord);
                Console.WriteLine();
                char letter = ReadLetter(enteredLetters);
                hangman.GuessLetter(letter);
                int attempts = hangman.attempts;
                enteredLetters.Add(letter);
                DisplayLetters(enteredLetters);
                Console.WriteLine($"Attemps left: {attempts}");
                Console.WriteLine();

                if (hangman.IsGuessed() || attempts == 0)
                {
                    DisplayWord(hangman.guessedWord);
                    Console.WriteLine();
                    break;
                }
            }
            if(hangman.IsGuessed())
            {
                return true;
            }
            return false;
        }

        List<string> ListOfWords()
        {
            List<string> ListOfWords = new List<string>();
            ListOfWords.Add("gigantic");
            ListOfWords.Add("calendar");
            ListOfWords.Add("announce");
            ListOfWords.Add("tasty");
            ListOfWords.Add("friend");
            ListOfWords.Add("clammy");
            ListOfWords.Add("wail");
            ListOfWords.Add("boast");
            ListOfWords.Add("tiger");
            ListOfWords.Add("ludicrous");
            ListOfWords.Add("muscle");
            ListOfWords.Add("rings");
            ListOfWords.Add("basketball");
            ListOfWords.Add("measure");
            ListOfWords.Add("obsolete");
            ListOfWords.Add("eyes");
            ListOfWords.Add("vacuous");
            ListOfWords.Add("strong");
            ListOfWords.Add("descriptive");
            ListOfWords.Add("contain");

            return ListOfWords;
        }

        string SelectWord(List<string> words)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, words.Count);
            return words[num];
        }
    }
}
