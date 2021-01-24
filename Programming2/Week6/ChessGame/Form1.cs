using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTools;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChessGame chessGame = new ChessGame();

        private void Form1_Load(object sender, EventArgs e)
        {
            chessGame.InitChessboard();
            DisplayChessPieces(chessGame);
        }


        void DisplayChessPieces(ChessGame chessGame)
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>();
            pairs.Add(0, "A"); pairs.Add(1, "B"); pairs.Add(2, "C"); pairs.Add(3, "D"); pairs.Add(4, "E"); pairs.Add(5, "F"); pairs.Add(6, "G"); pairs.Add(7, "H");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Label label = (Label) Controls.Find(pairs[col] + (row+1), true)[0];
                    ChessPiece chessPiece = chessGame.chessboard[row, col];

                    if (chessPiece == null)
                    {
                        label.Text = "";
                    }
                    else
                    {
                        if (chessPiece.color == ChessPieceColor.Black)
                        {
                            label.ForeColor = Color.Black;
                        }
                        else
                        {
                            label.ForeColor = Color.White;
                        }
                        string type = chessPiece.type.ToString().ToLower();
                        if (type == "king" || type == "queen")
                        {
                            type = chessPiece.type.ToString();
                        }
                        label.Text = type[0].ToString();
                    }
                }
            }
        }

        bool CheckPosition(string positionString)
        {
            int row;
            char col = positionString[0];
            Position position = new Position();
            char[] validColums = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            bool validRow = int.TryParse(positionString[1].ToString(), out row);

            return (validRow && validColums.Contains(col) && row >= 1 && row <= 8);
        }

        bool CheckMove(ChessGame chessGame, Position from, Position to)
        {
            if (chessGame.chessboard[from.row, from.column] == null)
            {
                MessageBox.Show("There is no chess piece at from-position!", "From-position error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFrom.Clear();
                txtFrom.Focus();
                return false;
            }
            else if (chessGame.chessboard[from.row, from.column].color != chessGame.turn)
            {
                MessageBox.Show("That is not your chess piece!", "From-position error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFrom.Clear();
                txtFrom.Focus();
                return false;
            }
            else if (!chessGame.ValidMove(chessGame.chessboard[from.row, from.column], from, to))
            {
                MessageBox.Show("That is not a valid move!", "Move error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFrom.Focus();
                return false;
            }
            else if (!chessGame.AvailableMove(chessGame.chessboard[from.row, from.column], from, to))
            {
                MessageBox.Show("There are pieces in the way!", "Move error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFrom.Focus();
                return false;
            }
            else if (chessGame.chessboard[to.row, to.column] != null && chessGame.chessboard[to.row, to.column].color == chessGame.turn)
            {
                MessageBox.Show("There already is a chess piece of your color at the to-position!", "Move error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFrom.Focus();
                return false;
            }
            return true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFrom.Text) || !CheckPosition(txtFrom.Text.ToUpper()))
            {
                MessageBox.Show("That is not a valid from-position!", "From-position error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFrom.Clear();
                txtFrom.Focus();
            }
            else if (String.IsNullOrEmpty(txtTo.Text) || !CheckPosition(txtTo.Text.ToUpper()))
            {
                MessageBox.Show("That is not a valid to-position!", "To-position error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTo.Clear();
                txtTo.Focus();
            }
            else
            {
                Position fromPos = new Position();
                Position toPos = new Position();
                string[] validColums = { "A", "B", "C", "D", "E", "F","G", "H" };

                fromPos.row = int.Parse(txtFrom.Text[1].ToString()) - 1;
                fromPos.column = Array.IndexOf(validColums, txtFrom.Text[0].ToString().ToUpper());
                toPos.row = int.Parse(txtTo.Text[1].ToString()) - 1;
                toPos.column = Array.IndexOf(validColums, txtTo.Text[0].ToString().ToUpper());

                if(CheckMove(chessGame, fromPos, toPos))
                {
                    chessGame.DoMove(fromPos, toPos);
                    DisplayChessPieces(chessGame);
                    lblMsg.Text = $"{chessGame.turn}'s turn";
                    txtFrom.Clear();
                    txtTo.Clear();
                    txtFrom.Focus();

                    if(chessGame.checkmate)
                    {
                        txtFrom.Enabled = false;
                        txtTo.Enabled = false;
                        btnPlay.Enabled = false;
                        lblMsg.Text = $"Congratulations {chessGame.turn}!\nYou won this match!";
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chessGame.InitChessboard();
            DisplayChessPieces(chessGame);

            txtFrom.Enabled = true;
            txtTo.Enabled = true;
            btnPlay.Enabled = true;

            txtFrom.Clear();
            txtTo.Clear();
            txtFrom.Focus();
            lblMsg.Text = "White's turn";
        }
    }
}
