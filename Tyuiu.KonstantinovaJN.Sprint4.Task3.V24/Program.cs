using Tyuiu.KonstantinovaJN.Sprint4.Task3.V24.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DataService ds = new DataService();

            Console.Title = "Спринт 4 | Выполнила: Константинова Ю. Н.| ИСПБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод).                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Константинова Юлия Николаевна | ИСПБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8. Найти минимальный        *");
            Console.WriteLine("* элемент во втором столбце массива.                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5]
            {
                { 3, 6, 1, 7, 3 },
                { 2, 3, 7, 1, 1 },
                { 1, 2, 5, 5, 1 },
                { 7, 6, 7, 6, 2 },
                { 7, 6, 4, 5, 8 }
            };

            Console.WriteLine("Массив:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                    Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(matrix);

            Console.WriteLine("Минимальный элемент во втором столбце массива: " + res);
            Console.ReadKey();
        }
    }
}