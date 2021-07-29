using System;
using MyLib;

namespace Task_4_Authorization
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

            return login == _login || password == _password ? true : false;
        }
        static void Main(string[] args)
        {
            int attemptConut = 2;

            do
            {
                Console.WriteLine("Авторизация пользователя\n Логин: \nПароль:");
                Console.SetCursorPosition(9, 1);

                string login = Console.ReadLine();

                Console.SetCursorPosition(9, 2);

                string password = Console.ReadLine();

                if (!Authorization(login, password) && attemptConut > 0)
                {
                    Console.Clear();
                    MyMethods.PrintScreenCenter("Ошибка авторизации! Осталось попыток: " + attemptConut--);
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

            if (attemptConut == 0)
            {
                MyMethods.PrintScreenCenter("Количество попыток исчерпано! Попробуйте позже!");
            }

            MyMethods.Pause();
        }
    }
}
