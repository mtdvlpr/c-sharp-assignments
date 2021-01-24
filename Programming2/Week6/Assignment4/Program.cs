using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment4
{
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
            ChessGame chessGame = new ChessGame();
            Console.WriteLine("This chess game does not allow En Passant or Castling.\nThe game is won by capturing the king instead of getting checkmate.\nTherefore you can put your own king in check.\n");
            chessGame.InitChessboard();
            DisplayChessboard(chessGame);
            PlayChess(chessGame);


            return ProgramTools.LoopGame();
        }

        void DisplayChessboard(ChessGame chessGame)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("1   ");
            Console.ResetColor();
            Console.WriteLine("A  B  C  D  E  F  G  H");
            for (int row = 7; row >= 0; row--)
            {
                Console.Write($" {row + 1,-2}");
                for (int col = 0; col < chessGame.chessboard.GetLength(1); col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    DisplayChessPiece(chessGame.chessboard[row, col]);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        void DisplayChessPiece(ChessPiece chessPiece)
        {
            if (chessPiece == null)
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
                Console.ResetColor();
            }
        }

        Position ReadPosition(string question)
        {
            Position position = new Position();
            string[] validColums = { "A", "B", "C", "D", "E", "F", "G", "H" };
            string positionString = ReadTools.ReadString(question).ToUpper();
            int row;
            string col = positionString[0].ToString();
            bool validRow = int.TryParse(positionString[1].ToString(), out row);

            while (!validRow || positionString.Length != 2 || !validColums.Contains(col) || row < 1 || row > 8)
            {
                Console.WriteLine("That's an invalid position!");
                positionString = ReadTools.ReadString(question).ToUpper();
                col = positionString[0].ToString();
                validRow = int.TryParse(positionString[1].ToString(), out row);
            }

            position.row = row - 1;
            position.column = Array.IndexOf(validColums, col.ToUpper());

            return position;
        }

        bool CheckMove(ChessGame chessGame, Position from, Position to)
        {
            if (chessGame.chessboard[from.row, from.column] == null)
            {
                Console.WriteLine("There is no chess piece at from-position!");
                return false;
            }
            else if (chessGame.chessboard[from.row, from.column].color != chessGame.turn)
            {
                Console.WriteLine("That is not your chess piece!");
                return false;
            }
            else if (!chessGame.ValidMove(chessGame.chessboard[from.row, from.column], from, to))
            {
                Console.WriteLine("That is not a valid move!");
                return false;
            }
            else if (!chessGame.AvailableMove(chessGame.chessboard[from.row, from.column], from, to))
            {
                Console.WriteLine("There are pieces in the way!");
                return false;
            }
            else if (chessGame.chessboard[to.row, to.column] != null && chessGame.chessboard[to.row, to.column].color == chessGame.turn)
            {
                Console.WriteLine("There already is a chess piece of your color at the to-position!");
                return false;
            }
            return true;
        }

        void PlayChess(ChessGame chessGame)
        {
            while (!chessGame.checkmate)
            {
                Position fromPos = new Position();
                Position toPos = new Position();
                Console.WriteLine($"\n{chessGame.turn}'s turn:");
                fromPos = ReadPosition("Enter a from-position: ");
                toPos = ReadPosition("Enter a to-position: ");
                while (!CheckMove(chessGame, fromPos, toPos))
                {
                    fromPos = ReadPosition("Enter a from-position: ");
                    toPos = ReadPosition("Enter a to-position: ");
                }
                chessGame.DoMove(fromPos, toPos);
                Console.WriteLine();
                DisplayChessboard(chessGame);
            }
            Console.WriteLine($"\nCongratulations {chessGame.turn}, you won!");
        }
    }
}
