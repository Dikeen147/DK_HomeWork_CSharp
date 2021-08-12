using System;

namespace W6_T1_DelegateFunc
{
    class DelegateFunc
    {
        public delegate double Fun(double a, double x);

        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- A ----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} ", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("-----------------------------");
        }
        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }
        public static void StartDemo()
        {
            Console.WriteLine("Таблица функции a * x^2:");
            Table(MyFunc, 1, -2, 2);
            Console.WriteLine("Таблица функции sin(x):");
            Table(delegate (double a, double x) { return Math.Sin(x); }, 1, 1, 4);
            Console.WriteLine("Таблица функции a * Sin(x):");
            Table(delegate (double a, double x) { return a * Math.Sin(x); }, 2, 1, 4);
        }
    }
}
