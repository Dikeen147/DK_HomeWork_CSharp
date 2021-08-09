using System;
using System.Collections.Generic;
using System.Linq;

namespace W5_T4_TheWorstStudents
{
    /*
     Работа Долгова Константина

    Вебинар 5. Задача 4.

      *Задача ЕГЭ.
    На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой 
    средней школы. В первой строке сообщается количество учеников N, которое не меньше 10, 
    но не превосходит 100, каждая из следующих N строк имеет следующий формат:
    <Фамилия> <Имя> <оценки>,
    где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, 
    состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа, 
    соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> 
    и <оценки> разделены одним пробелом. Пример входной строки: Иванов Петр 4 5 3

    Требуется написать как можно более эффективную программу, которая будет выводить 
    на экран фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных 
    есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести 
    и их фамилии и имена.
     */
    class Student
    {
        private string name;
        private string surname;
        private int[] marks;
        private double averageMark;
        public Student(string surname, string name, int[] marks)
        {
            this.name = name;
            this.surname = surname;
            this.marks = marks;
            int sum = 0;

            foreach (var item in marks)
                sum += item;

            this.averageMark = sum / (double)marks.Length;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string SurName
        {
            get { return this.surname; }
            set { this.surname = value; }
        }
        public double AverageMark
        {
            get { return this.averageMark; }
        }
        public void Show()
        {
            string marksLine = String.Empty;

            foreach (var item in this.marks)
                marksLine += item + " ";

            Console.WriteLine($"{this.surname} {this.name} {marksLine.TrimEnd()}");
        }
    }

    class Generation
    {
        string[] manNameBase = { "Пётр", "Иван", "Николай", "Сергей", "Евгений", "Максим", 
                            "Александр", "Алексей", "Константин", "Павел", "Андрей", "Юра", "Олег", "Гена", 
                            "Аркадий", "Арсентий", "Антон", "Дмитрий", "Владимир"};
        string[] womanNamebase = { "Екатерина", "Людмила", "Надежда", "Карина", "Валентина", 
                            "Мария", "Марина", "Александра", "Наталья", "Вера", "Лидия", "Любовь", 
                            "Ольга", "Юлия", "Эльвира", "Ева", "Алена", "Алина"};
        string[] surnameBase = { "Глазаболев", "Четаксложнов", "Многоедов", "Ошибатов", "Несидетов", 
                            "Многосидев", "Пешодрапов", "Надоедов", "Рукожопов", "Шарпов", "Програмов", 
                            "Ноутов", "Консолев", "Клавов", "Мышков", "Криворуков", "Правоглазов", 
                            "Нестоятов", "Дисплеев", "Подушков", "Связев" };

        Random rnd = new Random();
        /// <summary>
        /// Метод генерирует массив случайных чисел от 2 до 5 включительно
        /// </summary>
        /// <param name="count"> Количество чисел </param>
        /// <returns> Массив случайных чисел указанного размера </returns>
        public int[] GetMarks(int count)
        {
            int[] marks = new int[count];

            for (int i = 0; i < count; i++)
                marks[i] = rnd.Next(2, 6);

            return marks;
        }
        /// <summary>
        /// Метод генерирует случайные фамилии и имена из базы фамилий и имен
        /// </summary>
        /// <returns> Строка с случайной фамилией и именем </returns>
        public string GetName()
        {
            int option = rnd.Next(0, 2);
            string name = option == 0 
                ? manNameBase[rnd.Next(0, manNameBase.Length)] 
                : womanNamebase[rnd.Next(0, womanNamebase.Length)];

            string surname = option == 0
                ? surnameBase[rnd.Next(0, surnameBase.Length)]
                : surnameBase[rnd.Next(0, surnameBase.Length)] + "а";

            return $"{surname} {name}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generation gen = new Generation();
            List<Student> students = new List<Student>();
            
            // Генерация случайных фамилий имен и оценок
            for (int i = 0; i < 50; i++)
            {
                var surnameAndName = gen.GetName().Split(" ");
                Student st = new Student(surnameAndName[0], surnameAndName[1], gen.GetMarks(3));
                students.Add(st);
            }

            // Вывод студентов
            Console.WriteLine("N: " + students.Count);
            foreach (var item in students)
                item.Show();

            // Массив средних оценок студентов
            double[] avergareMarks = students.Select(st => st.AverageMark).Distinct().ToArray();
            Array.Sort(avergareMarks);
            // Получение списка студентов с плохими оценками
            var worstStudents = students.Where(st => st.AverageMark <= avergareMarks[2]);

            Console.WriteLine("\nХудшие ученики:");
            foreach (var item in worstStudents)
                item.Show();
        }
    }
}
