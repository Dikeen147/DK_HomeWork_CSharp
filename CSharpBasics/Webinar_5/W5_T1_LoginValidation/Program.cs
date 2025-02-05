﻿using System;
using System.Text.RegularExpressions;

namespace W5_T1_LoginValidation
{
    /*
     Работа Долгова Константина

     Вебинар 5. Задача 1.
     Создать программу, которая будет проверять корректность ввода логина.
    Корректным логином будет строка от 2 до 10 символов, содержащая только
    буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    а) без использования регулярных выражений;
    б) **с использованием регулярных выражений.
     */
    class LoginValidation
    {
        private string login;
        public LoginValidation(string login)
        {
            this.login = login;
        }
        public bool isValid()
        {
            bool valid = false;

            if (this.login.Length >= 2 && this.login.Length <= 10 & !char.IsNumber(this.login[0]))
            {
                valid = true;
                bool cond = false;

                for (int i = 0; i < this.login.Length; i++)
                {
                    cond = (this.login[i] >= '0' && this.login[i] <= '9') 
                        || (this.login[i] >= 'A' && this.login[i] <= 'Z')
                        || (this.login[i] >= 'a' && this.login[i] <= 'z');

                    if (!cond) return false;
                }
            }

            return valid;
        }
        public bool isValidRegex()
        {
            return new Regex(@"^[A-Za-z]{1}[A-Za-z0-9]{1,9}$").IsMatch(this.login);
        }
        public string PrintMessage()
        {
            // Добавлены сразу два условия проверки для наглядности работы двух методов
            return isValidRegex() == true && isValidRegex() == true
                ? $"\nОтлично! Ваш логин: {this.login} валиден :D"
                : $"\nУпс :( Ошибка валидации!" +
                $"\nДоступны буквы латинского алфавита и цифры от 2 до 10 символов." +
                $"\nПервым символом не может быть цифра.\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = String.Empty;
            do
            {
                Console.Write("Введите логин: ");
                str = Console.ReadLine();

                LoginValidation login = new LoginValidation(str);
                Console.WriteLine(login.PrintMessage());

            } while (str != "quit");
        }
    }
}
