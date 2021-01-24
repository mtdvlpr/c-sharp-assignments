using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
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
            Position position = new Position();
            int[,] chessboard = new int[8, 8];
            InitChessboard(chessboard);
            position = PositionTower(chessboard);
            PossibleKnightMoves(chessboard, position);
            DisplayChessboard(chessboard);

            _ = Console.ReadKey();
        }

        void InitChessboard(int[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = 0;
                }
            }
        }

        void DisplayChessboard(int[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    string symbol = "";
                    if(chessboard[row, col] == 0)
                    {
                        symbol = ".";
                    }
                    else if(chessboard[row,col] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        symbol = "*";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        symbol = "*";
                    }
                    Console.Write(" {0}", symbol);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        Position PositionKnight(int[,] chessboard)
        {
            Position position = new Position();
            Random rnd = new Random();
            int row = rnd.Next(0, 8);
            int col = rnd.Next(0, 8);
            chessboard[row, col] = 1;
            position.row = row;
            position.column = col;
            return position;
        }

        void PossibleKnightMoves (int[,] chessboard, Position position)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    // 1 up and 2 left/right
                    if (row == position.row - 1 && (col == position.column - 2 || col == position.column + 2))
                    {
                        chessboard[row, col] = 2;
                    }

                    // 2 up and 1 left/right
                    if (row == position.row - 2 && (col == position.column - 1 || col == position.column + 1))
                    {
                        chessboard[row, col] = 2;
                    }

                    // 1 down and 2 left/right
                    if (row == position.row + 1 && (col == position.column - 2 || col == position.column + 2))
                    {
                        chessboard[row, col] = 2;
                    }

                    // 2 down and 1 left/right
                    if (row == position.row + 2 && (col == position.column - 1 || col == position.column + 1))
                    {
                        chessboard[row, col] = 2;
                    }
                }
            }
        }

        Position PositionTower(int[,] chessboard)
        {
            Position position = new Position();
            Random rnd = new Random();
            int row = rnd.Next(0, 8);
            int col = rnd.Next(0, 8);
            chessboard[row, col] = 1;
            position.row = row;
            position.column = col;
            return position;
        }

        void PossibleTowerMoves(int[,] chessboard, Position position)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    if ((row == position.row && col != position.column) || (col == position.column && row != position.row))
                    {
                        chessboard[row, col] = 2;
                    }
                }
            }
        }

        Position PositionBishop(int[,] chessboard)
        {
            Position position = new Position();
            Random rnd = new Random();
            int row = rnd.Next(0, 8);
            int col = rnd.Next(0, 8);
            chessboard[row, col] = 1;
            position.row = row;
            position.column = col;
            return position;
        }

        void PossibleBishopMoves(int[,] chessboard, Position position)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    if ((row == position.row && col != position.column) || (col == position.column && row != position.row))
                    {
                        chessboard[row, col] = 2;
                    }
                }
            }
        }
    }
}
