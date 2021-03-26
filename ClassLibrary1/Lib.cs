using System;

namespace TRPO_Lab3.Lib
{
    public class Math_1
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
