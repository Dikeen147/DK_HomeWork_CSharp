using System;

namespace Questionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Работа Долгова Константина

             Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
             В результате вся информация выводится в одну строчку:
                а) используя  склеивание;
	            б) используя форматированный вывод;
	            в) используя вывод со знаком $.

             */
            Console.WriteLine("Анкета ввода ваших данных.\n");
            Console.Write("Ваше имя: ");

            string userName = Console.ReadLine();

            Console.Write("Ваша фамилия: ");

            string userSurName = Console.ReadLine();

            Console.Write("Ваша возраст: ");

            string userAge = Console.ReadLine();

            Console.Write("Ваша рост: ");

            string userHeight = Console.ReadLine();

            Console.Write("Ваша вес: ");

            string userWeight = Console.ReadLine();

            Console.WriteLine("\n-----Вывод A. Склеивание. (\"Имя: \" + userName)");
            Console.WriteLine("Имя:" + userName + "\nФамилия:" + userSurName
                            + "\nВозраст:" + userAge + "\nРост:" + userHeight + "\nВес:" + userWeight);

            Console.WriteLine("\n-----Вывод Б. Форматированный вывод. (\"Имя: {0}\", userName)");
            Console.WriteLine("Имя: {0} \nФамилия: {1} \nВозраст: {2} \nРост: {3} \nВес: {4}", 
                                userName, userSurName, userAge, userHeight, userWeight);

            Console.WriteLine("\n-----Вывод В. Интерполяция строк: ($\"Имя: {userName}\")");
            Console.WriteLine($"Имя: {userName} \nФамилия: {userSurName} \nВозраст: {userAge} \nРост: {userHeight} \nВес: {userWeight}");
        }
    }
}
