using Tyuiu.FedorovaDA.Sprint4.Task6.V8.Lib;
namespace Tyuiu.FedorovaDA.Sprint4.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Федрова Д. А. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Федорова Дарья Артемовна | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Пицца\", \"Борщ\", \"Пельмени\",         *");
            Console.WriteLine("* \"Омлет\", \"Салат\", \"Суп\", \"Роллы\"], используя класс Array,       *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 4 символов.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] dishes = { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < dishes.Length; i++)
            {
                Console.WriteLine(dishes[i]);
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Слова которые имеют больше 4 символов: ");
            string[] res = ds.Calculate(dishes);
            

            Console.WriteLine(res);
        }
    }
}
