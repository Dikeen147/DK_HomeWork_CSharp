using System;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Работа Долгова Константина
                
                Задача 3.
                а) Написать программу, которая подсчитывает расстояние между точками 
                  с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
                  Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
                б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
             */
            Console.WriteLine("Программа вычисления расстояния между двумя точками.\n");
            Console.Write("Введите x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Расстояние между точками равно: {result:F2}");
        }
    }
}
