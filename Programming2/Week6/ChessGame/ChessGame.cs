using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class ChessGame
    {
        public ChessPiece[,] chessboard = new ChessPiece[8,8];
        public ChessPieceColor turn;
        public bool checkmate = false;

        public void InitChessboard()
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = null;
                }
            }
            PutChessPieces();
            turn = ChessPieceColor.White;
        }

        public void PutChessPieces()
        {
            ChessPieceType[] order = { ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.Queen, ChessPieceType.King, ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook };
            for (int row = 7; row >= 0; row--)
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

        public void DoMove(Position from, Position to)
        {
            if (IsCheckmate(to))
            {
                checkmate = true;
            }
            else if (turn == ChessPieceColor.White)
            {
                turn = ChessPieceColor.Black;
            }
            else
            {
                turn = ChessPieceColor.White;
            }
            chessboard[to.row, to.column] = chessboard[from.row, from.column];
            chessboard[from.row, from.column] = null;
            
        }

        public bool ValidMove(ChessPiece chessPiece, Position from, Position to)
        {
            int hor = Math.Abs(to.column - from.column);
            int ver = Math.Abs(to.row - from.row);

            switch (chessPiece.type)
            {
                case ChessPieceType.Pawn:
                    return ((hor == 0 && ver == 1) || ((from.row == 1 || from.row == 6) && hor == 0 && ver == 2) || (hor == 1 && ver == 1 && chessboard[to.row, to.column] != null));
                case ChessPieceType.Rook:
                    return (hor * ver == 0);
                case ChessPieceType.Knight:
                    return (hor * ver == 2);
                case ChessPieceType.Bishop:
                    return (hor == ver);
                case ChessPieceType.King:
                    return ((hor == 1 && ver == 0) || (ver == 1 && hor == 0) || (ver == 1 && hor == 1));
                case ChessPieceType.Queen:
                    return (hor * ver == 0 || hor == ver);
                default:
                    return false;
            }
        }

        public bool AvailableMove(ChessPiece chessPiece, Position from, Position to)
        {
            int hor = to.column - from.column;
            int ver = to.row - from.row;

            switch (chessPiece.type)
            {
                case ChessPieceType.Pawn:
                    return (chessboard[to.row, to.column] == null || (ver != 0 && chessboard[to.row, to.column] != null));
                case ChessPieceType.Rook:
                    return RookMoves(from, to);
                case ChessPieceType.Knight:
                    return true;
                case ChessPieceType.Bishop:
                    return BishopMoves(from, to);
                case ChessPieceType.King:
                    return true;
                case ChessPieceType.Queen:
                    if(Math.Abs(hor) == Math.Abs(ver))
                    {
                        return BishopMoves(from, to);
                    }
                    else
                    {
                        return RookMoves(from, to);
                    }
                default:
                    return false;
            }
        }

        bool IsCheckmate(Position to)
        {
            return (chessboard[to.row, to.column] != null && chessboard[to.row, to.column].type == ChessPieceType.King);
        }

        bool BishopMoves(Position from, Position to)
        {
            int hor = to.column - from.column;
            int ver = to.row - from.row;
            int fromRow = from.row;
            if (ver > 0)
            {
                if (hor > 0)
                {

                    for (int col = from.column + 1; col < to.column; col++)
                    {
                        fromRow++;
                        if (chessboard[fromRow, col] != null)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    for (int col = from.column + 1; col < to.column; col--)
                    {
                        fromRow++;
                        if (chessboard[fromRow, col] != null)
                        {
                            return false;
                        }
                    }
                    return true;
                }

            }
            else
            {
                if (hor > 0)
                {
                    for (int col = from.column + 1; col < to.column; col++)
                    {
                        fromRow--;
                        if (chessboard[fromRow, col] != null)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    for (int col = from.column + 1; col < to.column; col--)
                    {
                        fromRow--;
                        if (chessboard[fromRow, col] != null)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
        }

        bool RookMoves(Position from, Position to)
        {
            int hor = to.column - from.column;
            int ver = to.row - from.row;
            if (to.row == from.row)
            {
                if (hor > 0)
                {
                    for (int col = from.column + 1; col < to.column; col++)
                    {
                        if (chessboard[from.row, col] != null)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    for (int col = to.column + 1; col < from.column; col++)
                    {
                        if (chessboard[from.row, col] != null)
                        {
                            return false;
                        }
                    }
                    return true;
                }

            }
            else
            {
                if (ver > 0)
                {
                    for (int row = from.row + 1; row < to.row; row++)
                    {
                        if (chessboard[row, from.column] != null)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    for (int row = to.row + 1; row < from.row; row++)
                    {
                        if (chessboard[row, from.column] != null)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
        }
    }
}
