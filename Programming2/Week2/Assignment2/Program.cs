using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
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
            int[,] matrix = new int[10, 10];
            InitMatrixRandom(matrix, 1, 100);
            DisplayMatrix(matrix);

            Console.WriteLine();
            Console.Write("Enter a number to search for: ");
            int num = int.Parse(Console.ReadLine());
            Position pos = new Position();
            Position posBack = new Position();
            pos = SearchNumber(matrix, num);
            posBack = SearchNumberBackWards(matrix, num);
            Console.WriteLine("Number {0} is found (first) at position [{1},{2}]", num, pos.row, pos.column);
            Console.WriteLine("Number {0} is found (last) at position [{1},{2}]", num, posBack.row, posBack.column);

            _ = Console.ReadKey();
        }

        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            int n = 0;
            Random rnd = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    n = rnd.Next(min, max + 1);
                    matrix[row, col] = n;
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

        Position SearchNumber(int[,] matrix, int number)
        {
            Position position = new Position();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row,col] == number)
                    {
                        position.row = row;
                        position.column = col;
                        return position;
                    }
                }
            }
            return position;
        }

        Position SearchNumberBackWards(int[,] matrix, int number)
        {
            Position position = new Position();
            for (int row = matrix.GetLength(0)-1; row >= 0; row--)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    if (matrix[row, col] == number)
                    {
                        position.row = row;
                        position.column = col;
                        return position;
                    }
                }
            }
            return position;
        }
    }
}
