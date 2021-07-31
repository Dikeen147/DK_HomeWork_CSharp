using System;

namespace Task_3_SumOddPositiveNumbers
{
    class Program
    {
        /*
         Работа Долгова Константина

        Задача 3.
        С клавиатуры вводятся числа, пока не будет введен 0. 
        Подсчитать сумму всех нечетных положительных чисел.
         */
        static bool isOdd(int number)
        {
            return number % 2 == 1 ? true : false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вывода суммы нечетных положительных чисел!\n" +
                "Введите числа (введите число 0, чтобы прекратить ввод):");

            int number;
            int sum = 0;

            do
            {
                number = Convert.ToInt32(Console.ReadLine());

                if (isOdd(number) && number > 0)
                {
                    Console.WriteLine("Нечетное положительное число: " + number);
                    sum += number;
                }
            } while (number != 0);

            Console.WriteLine("Сумма нечетных положительных чисел равна: " + sum);
        }
    }
}
