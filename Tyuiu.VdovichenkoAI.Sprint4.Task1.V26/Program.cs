using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VdovichenkoAI.Sprint4.Task1.V26.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint4.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Вдовиченко А.И. | ИИПб-23-1";
            // Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнила: Вдовиченко А.И. | ИИПб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапозоне от 0 до 8.                          *");
            Console.WriteLine("* Необходимо подсчитать сумму чётных элементов массива.                   *");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
