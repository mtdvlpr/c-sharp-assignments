using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyTools;

namespace Assignment3
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
            Console.Write("Enter a word (to search): ");
            string searchTerm = Console.ReadLine();
            while (searchTerm.Length < 1)
            {
                Console.Write("Enter a word (to search): ");
                searchTerm = Console.ReadLine();
            }
            int numWord = SearchWordInFile("..//..//tweets-donaldtrump-2018.txt", searchTerm, out int numLines);
            Console.WriteLine("Word occurence: " + numWord);
            Console.WriteLine("Number of lines containing the word: " + numLines);

            return ProgramTools.LoopProgram();
        }

        bool WordInLine(string line, string word)
        {
            line = line.ToLower();
            word = word.ToLower();
            return line.Contains($"{word}");
        }

        int SearchWordInFile(string filename, string word, out int num)
        {
            num = 0;
            int numWord = 0;
            StreamReader reader = new StreamReader(filename);

            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (WordInLine(line, word))
                {
                    num++;
                    numWord += DisplayWordInLine(line, word);
                    Console.WriteLine();
                }
            }
            reader.Close();

            return numWord;
        }

        int DisplayWordInLine(string line, string word)
        {
            int num = 0;
            int index = 0;
            while (WordInLine(line, word))
            {
                index = line.IndexOf(word, StringComparison.CurrentCultureIgnoreCase);
                Console.Write(line.Substring(0, index));

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(line.Substring(index, word.Length));
                Console.ResetColor();

                num++;
                line = line.Substring(index + word.Length);
            }
            Console.WriteLine(line);
            return num;
        }
    }
}
