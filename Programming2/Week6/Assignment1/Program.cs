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

            while(run)
            {
                Console.Clear();
                run = program.Start();
            }
        }

        bool Start()
        {
            Position position = new Position();
            ChessPiece[,] chessboard = new ChessPiece[8,8];
            InitChessboard(chessboard);
            DisplayChessboard(chessboard);
            PlayChess(chessboard);

            return ProgramTools.LoopProgram();
        }

        void InitChessboard(ChessPiece[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = null;
                }
            }
            PutChessPieces(chessboard);
        }

        void DisplayChessboard(ChessPiece[,] chessboard)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("1   ");
            Console.ResetColor();
            Console.WriteLine("A  B  C  D  E  F  G  H");
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                Console.Write($" {row + 1,-2}");
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    if((row+col) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    DisplayChessPiece(chessboard[row, col]);
                }
                Console.WriteLine();
                Console.ResetColor();
            }
        }

        void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order = { ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.King, ChessPieceType.Queen, ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook};
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    ChessPiece piece = new ChessPiece();
                    if (row <= 1)
                    {
                        piece.color = ChessPieceColor.White;
                    }
                    else if (row >= 6)
                    {
                        piece.color = ChessPieceColor.Black;
                    }
                    if (row == 1 || row == 6)
                    {
                        piece.type = ChessPieceType.Pawn;
                        chessboard[row, col] = piece;
                    }
                    else if (row == 0 || row == 7)
                    {
                        piece.type = order[col];
                        chessboard[row, col] = piece;
                    }
                }
            }
        }

        void DisplayChessPiece(ChessPiece chessPiece)
        {
            if(chessPiece == null)
            {
                Console.Write("   ");
            }
            else
            {
                if (chessPiece.color == ChessPieceColor.Black)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                string type = chessPiece.type.ToString().ToLower();
                if (type == "king" || type == "queen")
                {
                    type = chessPiece.type.ToString();
                }
                Console.Write($" {type[0]} ");
            }
        }

        Position ReadPosition(string question)
        {
            Position position = new Position();
            char[] validColums = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'};
            string positionString = ReadTools.ReadString(question).ToUpper();
            int row;
            char col = positionString[0];
            bool validRow = int.TryParse(positionString[1].ToString(), out row);

            while (!validRow || positionString.Length != 2 || !validColums.Contains(col) || row < 1 || row > 8)
            {
                Console.WriteLine("That's an invalid position!");
                positionString = ReadTools.ReadString("Enter a position: ");
                col = positionString[0];
                validRow = int.TryParse(positionString[1].ToString(), out row);
            }

            position.row = row - 1;
            position.column = Array.IndexOf(validColums, col);

            return position;
        }

        void PlayChess(ChessPiece[,] chessboard)
        {
            while(true)
            {
                Position fromPos = new Position();
                Position toPos = new Position();
                Console.WriteLine();
                Console.WriteLine();
                fromPos = ReadPosition("Enter a from-position: ");
                toPos = ReadPosition("Enter a to-position: ");
                if (CheckMove(chessboard, fromPos, toPos))
                {
                    DoMove(chessboard, fromPos, toPos);
                }
                DisplayChessboard(chessboard);
            }
        }

        bool CheckMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            if(chessboard[from.row, from.column] == null)
            {
                Console.WriteLine("There is no chess piece at from-position!");
                return false;
            }
            else if (!ValidMove(chessboard[from.row, from.column], from, to))
            {
                Console.WriteLine("That is not a valid move!");
                return false;
            }
            else if(chessboard[to.row, to.column] != null)
            {
                Console.WriteLine("There already is a chess piece at to-position!");
                return false;
            }
            return true;
        }

        void DoMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            chessboard[to.row, to.column] = chessboard[from.row, from.column];
            chessboard[from.row, from.column] = null;
        }

        bool ValidMove(ChessPiece chessPiece, Position from, Position to)
        {
            int hor = Math.Abs(from.column - to.column);
            int ver = Math.Abs(from.row - to.row);

            switch(chessPiece.type)
            {
                case ChessPieceType.Pawn:
                    return (hor == 0 && ver == 1); 
                case ChessPieceType.Rook:
                    return (hor * ver == 0);
                case ChessPieceType.Knight:
                    return (hor * ver == 2);
                case ChessPieceType.Bishop:
                    return (hor == ver);
                case ChessPieceType.King:
                    return (hor == 1 || ver == 1);
                case ChessPieceType.Queen:
                    return (hor * ver == 0 || hor == ver);
                default:
                    return false;
            }
        }
    }
}
