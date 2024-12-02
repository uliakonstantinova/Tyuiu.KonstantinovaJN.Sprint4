using Tyuiu.KonstantinovaJN.Sprint4.Task1.V29.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 4 | Выполнила: Константинова Ю. Н.| ИСПБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры).                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Константинова Юлия Николаевна | ИСПБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9. Подсчитать сумму нечетных*");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = new int[14];
            Console.Write("Введите 14 целых чисел в диапазоне от 1 до 9: ");

            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Исходный массив: " + string.Join(", ", numsArray));


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма нечетных элементов массива: " + ds.Calculate(numsArray));

            Console.ReadKey();

        }
    }
}