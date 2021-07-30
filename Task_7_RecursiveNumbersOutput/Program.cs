using System;

namespace Task_7_RecursiveNumbersOutput
{
    class Program
    {
        /*
         Работа Долгова Константина

        Задача 7.
        a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
         */
        static void PrintNumber(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                PrintNumber(a + 1, b);
            }
        }
        static int ABnumbersSum(int a, int b)
        {
            if (a == b) return a;
            else return ABnumbersSum(a + 1, b) + a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вывод на экран числа от А до В (рекурсивно):\n");
            Console.Write("Введите число A: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число B (больше числа A): ");

            int b = Convert.ToInt32(Console.ReadLine());

            PrintNumber(a, b);

            Console.WriteLine($"Сумма чисел от {a} до {b} равна: {ABnumbersSum(a, b)}");
        }
    }
}
