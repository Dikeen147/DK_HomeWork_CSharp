using System;

namespace Task_4_ExchangeOfValues
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Работа Долгова Константина.

            Задача 4.
            Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            а) с использованием третьей переменной;
            б) *без использования третьей переменной.
             */
            Console.WriteLine("Программа обмена значениями двух переменных.\n");
            Console.Write("Введите первую целочисленную переменную A: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите вторую целочисленную переменную B: ");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Переменные ДО обмена: A: {a}, B: {b} ");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Переменные ПОСЛЕ обмена: A: {a}, B: {b} ");

            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;

            Console.WriteLine($"Без использования третьей переменной A: {a}, B: {b}");
        }
    }
}
