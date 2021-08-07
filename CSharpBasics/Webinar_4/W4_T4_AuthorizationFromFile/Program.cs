using System;
using System.IO;
using MyLib;

namespace W4_T4_AuthorizationFromFile
{
    /*
     Работа Долгова Константина

    Вебинар 4. Задача 4.
    Решить задачу с логинами из урока 2, только логины и пароли считать из 
    файла в массив. Создайте структуру Account, содержащую Login и Password. 
     */
    struct Account
    {
        private string login;
        private string password;

        public void LoadAuthData(string path)
        {
            try
            {
                string[] authData = new string[2];
                string line;
                int count = 0;
                StreamReader sr = new StreamReader(path);
                
                while ((line = sr.ReadLine()) != null)
                {
                    authData[count] = line;
                    count++;
                }
                this.login = authData[0];
                this.password = authData[1];
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not found!");
                Console.WriteLine(ex.Message);
            }
        }
        public bool ComparsionAuthData(string login, string password)
        {
            return this.login == login && this.password == password ? true : false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../data.txt";
            Account ac = new Account();
            int attemptConut = 3;

            // Получение логина и пароля из файла
            ac.LoadAuthData(path);

            do
            {
                string[] messages = { "Авторизация пользователя:", "Логин:", "Пароль:" };
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

                if (!ac.ComparsionAuthData(login, password) && attemptConut > 0)
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
