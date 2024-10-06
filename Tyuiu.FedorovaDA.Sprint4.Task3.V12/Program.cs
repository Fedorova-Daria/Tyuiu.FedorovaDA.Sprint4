using Tyuiu.FedorovaDA.Sprint4.Task3.V12.Lib;
namespace Tyuiu.FedorovaDA.Sprint4.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[5, 5] { { 9, 7, 4, 9, 7 },
                { 5, 2, 5, 7, 6 },
                { 8, 3, 3, 5, 7 },
                { 8, 4, 2, 4, 5 },
                { 8, 8, 9, 5, 6 } };
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Федрова Д. А. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Федорова Дарья Артемовна | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 2 до 9.              *");
            Console.WriteLine("* Найдите минимальный элемент третьем столбце массива.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{array[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Минимальный элемент массива в третьем столбце: " + res);
        }
    }
}
