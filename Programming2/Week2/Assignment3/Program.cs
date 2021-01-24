using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            RegularCandies[,] playingField = new RegularCandies[10, 10];
            InitCandies(playingField);
            DisplayCandies(playingField);
            Console.WriteLine();
            if(ScoreRowPresent(playingField))
            {
                Console.WriteLine("Row score!");
            }
            else
            {
                Console.WriteLine("No row score.");
            }

            if (ScoreColumnPresent(playingField))
            {
                Console.WriteLine("Column score!");
            }
            else
            {
                Console.WriteLine("No column score.");
            }

            _ = Console.ReadKey();
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
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    candy = matrix[row, col];

                    if(candy == RegularCandies.JellyBean)
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
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        bool ScoreRowPresent(RegularCandies[,] matrix)
        {
            int counter = 0;
            RegularCandies candy = matrix[0,0];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(counter == 0)
                    {
                        counter = 1;
                        candy = matrix[row, col];
                    }
                    else if (candy == matrix[row,col])
                    {
                        counter++;
                        if(counter == 3)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        counter = 1;
                        candy = matrix[row, col];
                    }

                }
                counter = 0;
            }
            return false;
        }

        bool ScoreColumnPresent(RegularCandies[,] matrix)
        {
            int counter = 0;
            RegularCandies candy = matrix[0, 0];
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (counter == 0)
                    {
                        counter = 1;
                        candy = matrix[row, col];
                    }
                    else if (candy == matrix[row, col])
                    {
                        counter++;
                        if (counter == 3)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        counter = 0;
                        candy = matrix[row, col];
                    }

                }
                counter = 0;
            }
            return false;
        }
    }
}
