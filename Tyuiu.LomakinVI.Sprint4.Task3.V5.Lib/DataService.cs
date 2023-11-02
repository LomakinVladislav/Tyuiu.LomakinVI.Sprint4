using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LomakinVI.Sprint4.Task3.V5.Lib
{
    public class DataService : ISprint4Task3V5
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int summa = 0;

            for (int i = 0; i < rows; i++)
            {
                summa += array[i, 0];
            }

            return summa;
        }
    }
}
