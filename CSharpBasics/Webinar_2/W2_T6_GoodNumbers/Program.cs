using System;

namespace W2_T6_GoodNumbers
{
    class Program
    {
        /*
         Работа Долгова КОнстантина

        Задача 6.
        *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        *«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт 
        *времени выполнения программы, используя структуру DateTime.

         */
        static long NumberDigitSum(long a)
        {
            long s = 0;

            while(a > 0)
            {
                s += a % 10;
                a /= 10;
            }

            return s;
        }
        static void Main(string[] args)
        {
            DateTime begin = DateTime.Now;
            long count = 0;

            Console.WriteLine("Программа подсчета хороших чисел от 1 до 1 000 000 000." +
                "\nИдёт вычисление, подождите:");

            for (long i = 1; i <= 1_000_000_000; i++)
            {
                long s = NumberDigitSum(i);

                if (i % s == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество хороших чисел: {count:N}");

            DateTime end = DateTime.Now;
            var result = end - begin;

            Console.WriteLine($"{result.TotalSeconds} сек.");

        }
    }
}
