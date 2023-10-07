using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZaripovEO.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0)
            {
                y = (x + (Math.Pow(((x - 15) / (x - 19)), x)));
            }
            else
            {
                if (x == 0)
                {
                    y = ((Math.Cos(0) + 10) / (Math.Sin(0) + 12));
                }
                else
                {
                    if ((x > -15) && (x < 0))
                    {
                        y = (Math.Pow(1 + 1 / (x * x), x));
                    }
                    else
                    {
                        if (x < -15)
                        {
                            y = (x + 10 * x - (1 / x));
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
