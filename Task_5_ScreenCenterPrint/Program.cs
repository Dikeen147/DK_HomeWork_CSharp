using System;

namespace Task_5_ScreenCenterPrint
{
    class Program
    {
        /*
            Работа Долгова Константина.

            Задача 5.
            а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) Сделать задание, только вывод организовать в центре экрана.
            в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
         */

        static void Print(string msg)
        {
            int x = Console.WindowWidth / 2 - msg.Length / 2;
            int y = Console.WindowHeight / 2;

            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа вывода сообщения. В том числе в центр экрана.\n");
            Console.Write("Введите имя фамилию и город: ");

            string nameAndCity = Console.ReadLine();

            Console.Clear();
            Print(nameAndCity);
            Pause();

        }
    }
}
