using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class HangmanGame
    {
        public string secretWord;
        public string guessedWord;
        public int attempts = 8;

        public void Init(string secretWord)
        {
            this.secretWord = secretWord;
            guessedWord = "";
            foreach (char letter in secretWord)
            {
                guessedWord += ".";
            }
        }

        public bool GuessLetter(char letter)
        {
            int counter = 0;
            string guessedWord = "";
            bool guessed = false;

            foreach (char secretLetter in secretWord)
            {
                if (letter == secretLetter)
                {
                    guessed = true;
                    guessedWord += letter;
                }
                else
                {
                    guessedWord += this.guessedWord[counter];
                }
                counter++;
            }
            if(!guessed)
            {
                attempts--;
            }
            this.guessedWord = guessedWord;
            return guessed;
        }

        public bool IsGuessed()
        {
            if(guessedWord == secretWord)
            {
                return true;
            }
            return false;
        }
    }
}
