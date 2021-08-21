using System;

namespace W8_T1_DateTimeReflection
{
    /*
     Работа Долгова Константина

    Вебинар 8. Задача 1.
    С помощью рефлексии выведите все свойства структуры DateTime
     */
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in new DateTime().GetType().GetProperties())
                Console.WriteLine($"{item,30} | {item.Name}");
        }
    }
}
