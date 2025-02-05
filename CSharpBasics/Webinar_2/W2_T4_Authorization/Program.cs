﻿using System;
using MyLib;

namespace W2_T4_Authorization
{
    class Program
    {
        /*
         Работа Долгова Константина

        Задача 4.
        Реализовать метод проверки логина и пароля. 
        На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, 
        и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки 
        логина и пароля, написать программу: пользователь вводит логин и пароль, программа 
        пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод 
        пароля тремя попытками.
         */
        static bool Authorization(string login, string password)
        {
            const string _login = "root";
            const string _password = "GeekBrains";

            return login == _login && password == _password ? true : false;
        }
        static void Main(string[] args)
        {
            int attemptConut = 3;

            do
            {
                string[] messages = { "Авторизация пользователя:", "Логин:", "Пароль:"};
                int x = Console.WindowWidth / 2 - messages[0].Length / 2;
                int y = Console.WindowHeight / 2;
                int count = messages.Length;

                for (int i = 0; i < messages.Length; i++)
                {
                    Console.SetCursorPosition(x, y - count);
                    Console.WriteLine(messages[i]);
                    count--;
                }

                count = messages.Length - 1;
                Console.SetCursorPosition(x + messages[1].Length + 1, y - count);

                string login = Console.ReadLine();
                count--;
                Console.SetCursorPosition(x + messages[2].Length + 1, y - count);

                string password = Console.ReadLine();

                if (!Authorization(login, password) && attemptConut > 0)
                {
                    Console.Clear();
                    MyMethods.PrintScreenCenter("Ошибка авторизации! Осталось попыток: " + --attemptConut);

                    if (attemptConut == 0)
                    {
                        MyMethods.PrintScreenCenter("Количество попыток исчерпано! Попробуйте позже!");
                        break;
                    }
                    MyMethods.Pause();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    MyMethods.PrintScreenCenter("Вы успешно авторизировались!");
                    break;
                }
            } while (attemptConut >= 0);

            MyMethods.Pause();
        }
    }
}
