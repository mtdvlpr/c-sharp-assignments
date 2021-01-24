using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyCrushLogic
{
    public class CandyCrusher
    {
        public static bool ScoreRowPresent(RegularCandies[,] matrix, out Position position)
        {
            int counter = 0;
            position = new Position();
            RegularCandies candy = matrix[0, 0];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
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
                            position.row = row;
                            position.column = col - 2;
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

        public static bool ScoreColumnPresent(RegularCandies[,] matrix, out Position position)
        {
            int counter = 0;
            position = new Position();
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
                            position.row = row - 2;
                            position.column = col;
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
    }
}
