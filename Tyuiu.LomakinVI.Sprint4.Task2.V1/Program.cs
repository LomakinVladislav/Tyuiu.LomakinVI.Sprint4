using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LomakinVI.Sprint4.Task2.V1.Lib;

namespace Tyuiu.LomakinVI.Sprint4.Task2.V1
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант 1                                                               *");
            Console.WriteLine("* Выполнил: Ломакин Владислав Игоревич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* случайными числами в диапазоне от 1 до 9 подсчитать произведение четных *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int length = 10;
            int[] numsArray = new int[length];

            Console.WriteLine("Длина массива = " + length);

            for (int i = 0; i < numsArray.Length; i++)
            {
                numsArray[i] = rnd.Next(1, 10);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(numsArray);

            Console.WriteLine("Произведение чётных элементов = " + result);
            Console.ReadKey();
        }
    }
}
