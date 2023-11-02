using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LomakinVI.Sprint4.Task3.V5.Lib;

namespace Tyuiu.LomakinVI.Sprint4.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Ломакин В. И. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант 5                                                               *");
            Console.WriteLine("* Выполнил: Ломакин Владислав Игоревич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9.                          *");
            Console.WriteLine("* Найдите сумму элементов в первом столбце массива.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] myArray = { { 3, 4, 8, 6, 3 }, { 9, 9, 3, 6, 9 }, { 5, 6, 7, 2, 3 }, { 3, 6, 2, 3, 8 }, { 5, 7, 2, 6, 4 } };

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(myArray);
            Console.WriteLine("Сумма элементов первого столбца массива = " + result);

            Console.ReadKey();
        }
    }
}
