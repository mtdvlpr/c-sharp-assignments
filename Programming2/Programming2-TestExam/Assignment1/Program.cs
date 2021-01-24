using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment1
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
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            sentence = ShuffleWords(sentence);
            Console.WriteLine("The new sentence has become: " + sentence);

            return ProgramTools.LoopProgram();
        }

        string ShuffleWord(string word)
        {
            if(word.Length <= 3)
            {
                return word;
            }
            string newWord = "" + word[0];
            string remainingWord = word.Substring(1, word.Length - 2);
            while(remainingWord.Length > 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, remainingWord.Length);
                newWord += remainingWord[index];
                remainingWord = remainingWord.Remove(index, 1);
            }
            newWord += word[word.Length - 1];
            return newWord;
        }

        string ShuffleWords(string sentence)
        {
            string newSentence = "";
            sentence = sentence.Replace(".", "");
            sentence = sentence.Replace(",", "");
            string[] words = sentence.Split(' ');
            foreach (string word in words) 
            {
                newSentence += ShuffleWord(word) + " ";
            }
            return newSentence;
        }
    }
}
