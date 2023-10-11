using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZaripovEO.Sprint2.Task6.V11.Lib;

namespace Tyuiu.ZaripovEO.Sprint2.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №2 | Выполнил: Зарипов Е. О. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Зарипов Егор Олегович | ИСТНб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами:*");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число)                        *");
            Console.WriteLine("* По заданным g, n и m определить дату следующего дня.                    *");
            Console.WriteLine("* Заданный год не является високосным.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер дня: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяцы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            string res;

            res = ds.FindDateOfNextDay(n, m, g);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}