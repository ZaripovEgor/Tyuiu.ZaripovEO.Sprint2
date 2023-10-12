using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZaripovEO.Sprint2.Task7.V15.Lib;

namespace Tyuiu.ZaripovEO.Sprint2.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт №2 | Выполнил: Зарипов Е. О. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Зарипов Егор Олегович | ИСТНб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает исходные данные (вещественные   *");
            Console.WriteLine("* значения) и вычисляет, находится ли точка с координатами X,Y            *");
            Console.WriteLine("* в заштрихованной области.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());


            bool res;

            res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res == true)
            {
                Console.WriteLine(res + " - точка с координатами (" + x + ";" + y + ") лежит в закрашенной области.");
            }
            else
            {
                Console.WriteLine(res + " - точка с координатами (" + x + ";" + y + ") не лежит в закрашенной области.");
            }
            Console.ReadKey();
        }
    }
}
