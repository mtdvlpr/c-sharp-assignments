using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment4
{
    class LingoGame
    {
        public string lingoWord;
        public string playerWord;
        public LetterState[] letterResults;
        public int attempt = 1;

        public void Init()
        {
            this.lingoWord = ReadTools.ReadString("Enter a lingo word: ").ToUpper();
        }

        public void CheckWord(string playerWord)
        {
            this.playerWord = playerWord.ToUpper();
            letterResults = new LetterState[lingoWord.Length];
            List<char> refLetters = new List<char>();
            for (int i = 0; i < lingoWord.Length; i++)
            {
                if(lingoWord[i] != this.playerWord[i])
                {
                    refLetters.Add(this.lingoWord[i]);
                }
            }
            for (int i = 0; i < lingoWord.Length; i++)
            {
                if (lingoWord[i] == this.playerWord[i])
                {
                    letterResults[i] = LetterState.Correct;
                }
                else if(refLetters.Contains(this.playerWord[i]))
                {
                    letterResults[i] = LetterState.WrongPosition;
                    refLetters.Remove(this.playerWord[i]);
                }
                else
                {
                    letterResults[i] = LetterState.Incorrect;
                }
            }
            attempt++;
        }

        public bool GuessedWord()
        {
            return lingoWord == playerWord;
        }
    }
}
