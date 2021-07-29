using System;

namespace Task_1_MinOfThreeNumbers
{
    class Program
    {
        /*
         Работа Долгова Константина

        Задача 1.
        Написать метод, возвращающий минимальное из трёх чисел.
         */

        static double MinOfThreeNumb(double a, double b, double c)
        {
            return a < b ? c < a ? c : a : c < b ? c : b; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вывода минимального из 3-ёх чисел!\n");
            Console.Write("Введите число A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nМинимальное из трёх чисел: " + MinOfThreeNumb(a, b, c));
        }
    }
}
