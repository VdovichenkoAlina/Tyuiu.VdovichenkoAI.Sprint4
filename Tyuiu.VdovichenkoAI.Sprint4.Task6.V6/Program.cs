using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VdovichenkoAI.Sprint4.Task6.V6.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint4.Task6.V6
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
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Вдовиченко А.И. | ИИПб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных:                                            *");
            Console.WriteLine("* ['Борис', 'Анна', 'Михаил', 'Ирина', 'Сергей', 'Татьяна', 'Олег'].      *");
            Console.WriteLine("* Используя класс Array, выведите элементы массива,                       *");
            Console.WriteLine("* длина которых равна 5 символам.                                         *");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] names = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            Console.Write("Исходный массив: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]);
                if (i != names.Length - 1) { Console.Write(", "); }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] res = ds.Calculate(names);
            Console.WriteLine($"Элементы массива, длина которых равна 5:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]);
                if (i != res.Length - 1) { Console.Write(", "); }
            }
            Console.ReadKey();
        }
    }
}
