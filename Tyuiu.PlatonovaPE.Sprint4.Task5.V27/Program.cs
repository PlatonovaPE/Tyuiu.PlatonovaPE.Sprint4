using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PlatonovaPE.Sprint4.Task5.V27.Lib;

namespace Tyuiu.PlatonovaPE.Sprint4.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Платонова П. Е. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Платонова Полина Евгеньевна | ИСПб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -5 до 7. Найти сумму положительных *");
            Console.WriteLine("* элементов                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите кол-во строк и столбцов через enter");
            int rows = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, length];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = rnd.Next(-5, 7);
                }

            }

            Console.WriteLine("Ваш массив");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine($"Сумма отрицательных элементов = {res}");

            Console.ReadKey();
        }
    }
}