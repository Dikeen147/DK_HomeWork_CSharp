using System;
using MyLib;

namespace W1_T5_ScreenCenterPrint
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

        static void Main(string[] args)
        {
            Console.WriteLine("Программа вывода сообщения. В том числе в центр экрана.\n");
            Console.Write("Введите имя фамилию и город: ");

            string nameAndCity = Console.ReadLine();

            Console.Clear();
            MyMethods.PrintScreenCenter(nameAndCity);
            MyMethods.Pause();

        }
    }
}
