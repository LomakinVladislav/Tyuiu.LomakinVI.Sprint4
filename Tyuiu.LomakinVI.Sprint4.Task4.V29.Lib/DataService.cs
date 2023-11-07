using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LomakinVI.Sprint4.Task4.V29.Lib
{
    public class DataService : ISprint4Task4V29
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int summa = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        summa += matrix[i, j];
                    }
                }
            }

            return summa;
        }
    }
}
