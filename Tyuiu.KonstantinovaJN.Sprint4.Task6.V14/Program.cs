using Tyuiu.KonstantinovaJN.Sprint4.Task6.V14.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт 4 | Выполнила: Константинова Ю. Н.| ИСПБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Константинова Юлия Николаевна | ИСПБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Январь\", \"Февраль\", \"Март\",         *");
            Console.WriteLine("* \"Апрель\", \"Май\", \"Июнь\", \"Июль\"], используя класс Array,        *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 3 символов.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            Console.WriteLine("Исходный массив: ");
            Console.WriteLine(String.Join(", ", months));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(months);
            Console.WriteLine("Элементы массива, длина которых больше 3 символов: ");
            foreach (var month in res)
            {
                Console.WriteLine(month);
            }

            Console.ReadKey();
        }
    }
}