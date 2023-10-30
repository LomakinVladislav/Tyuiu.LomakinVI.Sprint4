using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LomakinVI.Sprint4.Task0.V14.Lib
{
    public class DataService : ISprint4Task0V14
    {
        public int GetSumOddArrEl(int[] array)
        {
            int summ = 0;

            foreach (int item in array)
            {
                if (item % 2 != 0)
                {
                    summ += item;
                }
            }

            return summ;
        }
    }
}
