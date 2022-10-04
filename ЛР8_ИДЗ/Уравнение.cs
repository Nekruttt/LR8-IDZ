using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР8_ИДЗ
{
    internal class Уравнение
    {
        public static double Equation1(double x, double y, int n, int r)
        {
            double result = 0;
            double chisl = 0;

            for (int i = 1; i <= n; i++)
            {
                double znam = i + 1;
                if (i % 2 == 0)
                    chisl = chisl + (Math.Pow(y, (i)));
                else
                    chisl = chisl - (Math.Pow(x, (i)));
                result += chisl / znam;
                chisl = 0;
            }
            return result;
        }

        public static double Equation2(int n, int r)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; i <= r; i++)
                {
                    result += (j * j + i) / (Math.Pow(i, j) + j);
                }
            }
            return result;
        }
    }
}
