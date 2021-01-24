using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;
using System.IO;

namespace Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Program program = new Program();

            while(run)
            {
                run = program.Start();
            }
        }

        bool Start()
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            if (SetLanguage())
            {
                words = ReadWords("..//..//dictionaryNL.csv", "nl");
            }
            else
            {
                words = ReadWords("..//..//dictionaryENG.csv", "eng");
            }
            TranslateWords(words);

            return ProgramTools.LoopProgram();
        }

        Dictionary<string, string> ReadWords(string filename, string lang)
        {
            StreamReader reader = new StreamReader(filename);
            Dictionary<string, string> words = new Dictionary<string, string>();

            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] word = line.Split(';');

                if(lang == "nl")
                {
                    words.Add(word[0], word[1]);
                }
                else
                {
                    words.Add(word[1], word[0]);
                }
                
            }
            reader.Close();
            return words;
        }

        bool SetLanguage()
        {
            Console.Write("Which language do you want to translate (nl or eng)? ");
            string answer = Console.ReadLine();
            while (answer != "nl" && answer != "eng")
            {
                Console.WriteLine("Answer with 'nl' or 'eng' please.");
                Console.Write("Which language do you want to translate (nl or eng)? ");
                answer = Console.ReadLine();
            }
            if (answer == "nl")
            {
                return true;
            }
            return false;
        }

        void TranslateWords(Dictionary<string, string> words)
        {
            string word = ReadTools.ReadString("Enter a word: ");

            while(word != "stop")
            {
                if (words.ContainsKey(word))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{word} => {words[word]}");
                    Console.ResetColor();
                }
                else if (word == "listall")
                {
                    ListAllWords(words);
                }
                else
                {
                    Console.WriteLine($"Word '{word}' was not found.");
                }
                word = ReadTools.ReadString("Enter a word: ");
            }
        }

        void ListAllWords(Dictionary<string, string> words)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (KeyValuePair<string, string> word in words)
            {
                Console.WriteLine($"{word.Key} => {word.Value}");
            }
            Console.ResetColor();
        }
    }
}
