using System;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.ConsoleApp
{
    class Program//commit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите r");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите r1");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите l");
            double l = Convert.ToDouble(Console.ReadLine());
            if (r <= 0)
            {
                Console.WriteLine("Введите положительное число");
            }
            else if (r1 <= 0)
            {
                Console.WriteLine("Введите положительное число");
            }
            else if (l <= 0)
            {
                Console.WriteLine("Введите положительное число");
            }
            else
            {
                double answer = Math.Round(Math_1.Formula(r, r1, l), 3);
                Console.WriteLine($"{answer}");
            }
            Console.ReadKey();
        }
    }
}
