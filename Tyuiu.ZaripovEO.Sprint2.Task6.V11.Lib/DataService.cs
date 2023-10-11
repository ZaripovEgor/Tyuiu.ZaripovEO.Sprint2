using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZaripovEO.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int n, int m, int g)
        {
            string res;
            switch (n)
            {

                case 28:

                    switch (m)
                    {
                        case 2:
                            n = 1;
                            m = 3;
                            break;
                        default:
                            n = 29;
                            break;
                    }
                default:
                    Console.WriteLine("Введено неверное число: кол-во дней в данном месяце не > 28");
                    break;


                case 30:
                    switch (m)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            n = 31;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            n = 1;
                            m += 1;
                            break;
                    }
                    break;
                case 31:
                    switch (m)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                            n = 1;
                            m += 1;
                            break;
                        case 12:
                            n = 1;
                            m = 1;
                            g += 1;
                            break;
                    }
                    break;
            }
            res = ($"Дата следующего дня: {n}.{m}.{g}");
            return res;
        }
    }
}
