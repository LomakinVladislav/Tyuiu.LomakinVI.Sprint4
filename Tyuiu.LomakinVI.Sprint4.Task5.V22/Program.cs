using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LomakinVI.Sprint4.Task5.V22.Lib;

namespace Tyuiu.LomakinVI.Sprint4.Task5.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Ломакин В. И. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант 22                                                              *");
            Console.WriteLine("* Выполнил: Ломакин Владислав Игоревич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -8 до 9. Найти количество          *");
            Console.WriteLine("* отрицательных элементов массива.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int columns = 5;
            int[,] numsArray = new int[rows, columns];

            Console.WriteLine("Количество строк = " + rows);
            Console.WriteLine("Количество столбцов = " + columns);

            for (int i = 0; i < numsArray.GetLength(0); i++)
            {
                for (int j = 0; j < numsArray.GetLength(1); j++)
                {
                    numsArray[i, j] = rnd.Next(-8, 10);
                }
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < numsArray.GetLength(0); i++)
            {
                for (int j = 0; j < numsArray.GetLength(1); j++)
                {
                    Console.Write(numsArray[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(numsArray);

            Console.WriteLine("Количество отрицательных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}
