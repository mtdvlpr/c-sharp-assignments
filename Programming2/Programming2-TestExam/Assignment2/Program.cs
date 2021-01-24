using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment2
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
            int[,] matrix = new int[5, 10];
            matrix = FillMatrix(matrix);
            DisplayMatrix(matrix);
            Console.WriteLine();
            int num = ReadTools.ReadInt("Enter a search number: ");

            while(!numberPresent(matrix, num))
            {
                Console.WriteLine("That number is not present in the matrix, try another one.");
                num = ReadTools.ReadInt("Enter a search number: ");
            }
            matrix = shiftmatrix(matrix, num);
            Console.WriteLine();
            Console.WriteLine("Shifting rows...");
            Console.WriteLine();
            DisplayMatrix(matrix);

            return ProgramTools.LoopProgram();
        }

        bool numberPresent(int[,] matrix, int number)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == number)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        int[,] shiftRow(int[,] matrix, int row, int column)
        {
            int[] TempRow = new int[10];

            for (int col = 0; col <= matrix.GetLength(1) - column; col++)
            {
                TempRow[col] = matrix[row, col + column - 1];
            }
            int i = 1;
            for (int col = matrix.GetLength(1) - column + 1; col < matrix.GetLength(1); col++)
            {
                TempRow[col] = matrix[row, i];
                i++;
            }

            for (int col = 0; col < TempRow.Length; col++)
            {
                matrix[row, col] = TempRow[col];
            }

            return matrix;
        }

        int[,] shiftmatrix(int[,] matrix, int number)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row,col] == number)
                    {
                        matrix = shiftRow(matrix, row, col);
                        break;
                    }
                }
            }
            return matrix;
        }

        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row,col].ToString("00"));
                }
                Console.WriteLine();
            }
        }

        int[,] FillMatrix(int[,] matrix)
        {
            Random rnd = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rnd.Next(1, 100);
                }
            }
            return matrix;
        }
    }
}