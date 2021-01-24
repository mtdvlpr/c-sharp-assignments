using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyTools;
using CandyCrushLogic;

namespace Assignment2
//{
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
            RegularCandies[,] playingField;

            if (File.Exists("playingField.txt"))
            {
                playingField = ReadPlayingField("playingField.txt");
            }
            else
            {
                playingField = new RegularCandies[10, 10];
                InitCandies(playingField);
                WritePlayingField(playingField, "playingField.txt");
            }
            DisplayCandies(playingField);
            Console.WriteLine();
            Position pos = new Position();
            if (CandyCrusher.ScoreRowPresent(playingField, out pos))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Row score!");
                Console.ResetColor();
                Console.WriteLine($"First position: ({pos.column}, {pos.row})");
            }
            else
            {
                Console.WriteLine("No row score.");
            }
            Console.WriteLine();
            if (CandyCrusher.ScoreColumnPresent(playingField, out pos))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Column score!");
                Console.ResetColor();
                Console.WriteLine($"First position: ({pos.column}, {pos.row})");
            }
            else
            {
                Console.WriteLine("No column score.");
            }

            if(RemoveSaveFile())
            {
                File.Delete("playingField.txt");
                Console.WriteLine("Your safe file has been succesfully deleted.");
            }

            return ProgramTools.LoopProgram();
        }

        bool RemoveSaveFile()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Do you want to delete your safe file? ");
            string answer = Console.ReadLine();
            while (answer != "yes" && answer != "no")
            {
                Console.WriteLine("Answer with 'yes' or 'no' please.");
                Console.Write("Do you want to delete your safe file? ");
                answer = Console.ReadLine();
            }
            if (answer == "yes")
            {
                Console.Write("Are you sure? ");
                answer = Console.ReadLine();
                while (answer != "yes" && answer != "no")
                {
                    Console.WriteLine("Answer with 'yes' or 'no' please.");
                    Console.Write("Are you sure you want to delete your safe file? ");
                    answer = Console.ReadLine();
                }
                if (answer == "yes")
                {
                    return true;
                }
            }
            return false;
        }

        void WritePlayingField(RegularCandies[,] playingField, string filename)
        {
            RegularCandies candy;
            StreamWriter writer = new StreamWriter(filename);

            writer.WriteLine(playingField.GetLength(0));
            writer.WriteLine(playingField.GetLength(1));
            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                for (int col = 0; col < playingField.GetLength(1); col++)
                {
                    candy = playingField[row, col];
                    writer.Write((int)candy + " ");
                }
                writer.WriteLine();
            }
            writer.Close();
        }

        RegularCandies[,] ReadPlayingField(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            try
            {
                int rows = int.Parse(reader.ReadLine());
                int cols = int.Parse(reader.ReadLine());
                RegularCandies[,] playingField = new RegularCandies[rows, cols];

                for (int row = 0; row < playingField.GetLength(0); row++)
                {
                    string line = reader.ReadLine();
                    string[] numberStrings = line.Split(' ');
                    for (int col = 0; col < playingField.GetLength(1); col++)
                    {
                        int num = int.Parse(numberStrings[col]);
                        playingField[row, col] = (RegularCandies)num;
                    }
                }
                reader.Close();

                return playingField;
            }
            catch
            {
                reader.Close();
                Console.WriteLine("Something went wrong with the save file...");
                Console.WriteLine("A new playingfield has been created.");
                Console.WriteLine();

                RegularCandies[,] playingField = new RegularCandies[10, 10];
                InitCandies(playingField);
                WritePlayingField(playingField, "playingField.txt");

                return playingField;
            }
        }

        void InitCandies(RegularCandies[,] matrix)
        {
            int num;
            Random rnd = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    num = rnd.Next(0, 6);
                    matrix[row, col] = (RegularCandies)num;
                }
            }
        }

        void DisplayCandies(RegularCandies[,] matrix)
        {
            RegularCandies candy;
            string symbol = "#";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" 0");
            Console.ResetColor();
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                Console.Write($" {col}");
            }
            Console.WriteLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write($" {row}");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    candy = matrix[row, col];

                    if (candy == RegularCandies.JellyBean)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (candy == RegularCandies.Lozenge)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (candy == RegularCandies.LemonDrop)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (candy == RegularCandies.GumSquare)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (candy == RegularCandies.LollipopHead)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }

                    Console.Write(" {0}", symbol);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
