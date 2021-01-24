using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerAssignment2
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
            int[,] matrix = new int[5, 10]; // 5 rows, 10 columns
            FillMatrix(matrix);
            DisplayMatrix(matrix);
            Console.WriteLine();
            Console.Write("Enter a new number: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            ShiftMatrix(matrix, number);
            Console.WriteLine();
            DisplayMatrix(matrix);
            // wait for user
            Console.ReadKey();
        }

        void FillMatrix(int[,] matrix)
        {
            Random rnd = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rnd.Next(1, 100);
                }
            }
        }
        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0:00} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        void ShiftMatrix(int[,] matrix, int number)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // search number in row
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == number)
                    {
                        Console.WriteLine("shift row {0} starting from column {1}...",
                        row + 1, col + 1);
                        ShiftRow(matrix, row, col);
                        break;
                    }
                }
            }
        }
        void ShiftRow(int[,] matrix, int row, int column)
        {
            int[] temp = new int[matrix.GetLength(1)];
            // store shifted numbers in temp array
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                temp[col] = matrix[row, column];
                column = (column + 1) % matrix.GetLength(1);
            }
            // store numbers in temp-array back to matrix
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = temp[col];
            }
        }

    }
}
