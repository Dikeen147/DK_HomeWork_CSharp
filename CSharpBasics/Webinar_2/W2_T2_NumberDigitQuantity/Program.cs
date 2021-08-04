using System;

namespace W2_T2_NumberDigitQuantity
{
    class Program
    {
        /*
         Работа Долгова Константина

        Задача 2.
        Написать метод подсчета количества цифр числа.
         */

        static int NumberDigitQuantity(int number)
        {
            int i = 0;

            while (number > 0)
            {
                number /= 10;
                i++;
            }

            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчитывает количество цифр числа.\n");
            Console.Write("Введите целое число: ");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"В числе: {number} количество цифр равно: {NumberDigitQuantity(number)}") ;
        }
    }
}
