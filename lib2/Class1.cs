using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib2
{
    public class Math_2
    {
        public static double Formula(double r, double r1, double l)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Переменная h не может быть отрицательной");
            }
            if (r1 <= 0)
            {
                throw new ArgumentException("Переменная r1 не может быть отрицательной");
            }
            if (l <= 0)
            {
                throw new ArgumentException("Переменная l не может быть отрицательной");
            }
            return Math.PI * (r + r1) * l;
        }
    }
}
