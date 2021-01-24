using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
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
            int[,] matrix = new int[11, 11];
            InitMatrixLinear(matrix);
            DisplayMatrixWithCross(matrix);

            _ = Console.ReadKey();
        }

        void InitMatrix2D(int[,] matrix)
        {
            int n = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = n;
                    n++;
                }
            }
        }

        void DisplayMatrix(int[,] matrix)
        {
            int n = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    n = matrix[row, col];
                    Console.Write(" {0,3}", n);
                }
                Console.WriteLine();
            }
        }

        void InitMatrixLinear(int[,] matrix)
        {
            int row = 0;
            int col = 0;

            for (int n = 1; n <= matrix.Length; n++)
            {
                matrix[row, col] = n;
                col++;

                if (col % matrix.GetLength(1) == 0)
                {
                    col = 0;
                    row++;
                }
            }
        }

        void DisplayMatrixWithCross(int[,] matrix)
        {
            int n = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(row == col)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if(row + col + 1 == matrix.GetLength(1))
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }

                    n = matrix[row, col];
                    Console.Write(" {0,3}", n);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
