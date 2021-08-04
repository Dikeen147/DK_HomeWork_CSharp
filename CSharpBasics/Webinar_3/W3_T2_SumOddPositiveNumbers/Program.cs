using System;

namespace W3_T2_SumOddPositiveNumbers
{
    class Program
    {
        /*
         Работа Долгова Константина

        Задача 2.
        а)  С клавиатуры вводятся числа, пока не будет введён 0 
        (каждое число в новой строке). Требуется подсчитать сумму всех 
        нечётных положительных чисел. Сами числа и сумму вывести на экран, 
        используя tryParse.
         */static bool isOdd(int number)
        {
            return number % 2 == 1 ? true : false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма всех нечетных положительных чисел!" +
                "\nВведите числа (0 для выхода):");

            int number;
            bool flag;
            int sum = 0;

            do
            {
                flag = int.TryParse(Console.ReadLine(), out number);
                if (isOdd(number) && number > 0)
                {
                    sum += number;
                }
                if (!flag)
                {
                    Console.WriteLine("Ошибка! Введите целое число!");
                }
            } while (number != 0);

            Console.WriteLine("Сумма нечетных положительных чисел равна: " + sum);
        }
    }
}
